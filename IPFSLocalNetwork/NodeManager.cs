//https://ipfs.io/docs/getting-started/
///////https://github.com/TrekDev/net-ipfs-api/blob/master/src/Ipfs/Commands/IpfsRoot.cs
//https://github.com/richardschneider/net-ipfs-api/blob/master/src/CoreApi/KeyApi.cs

using Ipfs;
using Ipfs.Api;
using Ipfs.CoreApi;
using IPFSLocalNetwork.Progress;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static IPFSLocalNetwork.Progress.FileStreamWithProgress;

namespace IPFSLocalNetwork
{
    public class IPFSFileInfo
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
    }
    public class NodeManager
    {
        private string _nodeUrl;
        private Process _daemonProcess;
        private string _ipfsEXEPath;
        private IpfsClient Ipfs => new IpfsClient(_nodeUrl);
        public NodeManager(string nodeUrl = "http://127.0.0.1:5001", string ipfsEXEPath = "ipfs.exe")
        {
            _nodeUrl = nodeUrl;
            _ipfsEXEPath = ipfsEXEPath;
        }

        #region private key //TODO
        // private string _ipfsInitPath => read init path variable;
        public void SetPrivateKey(string privateKey)
        {
            throw new NotImplementedException();
        }
        public string getPrivateKey()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IPSNS //TODO
        //var x = await Ipfs.Name.PublishAsync("");
        //https://decentralized.blog/ten-terrible-attempts-to-make-ipfs-human-friendly.html
        #endregion

        #region node
        public void InitRepo()
        {
            // return Ipfs.DoCommandAsync("init", default(CancellationToken));

            var processInfo = new ProcessStartInfo(_ipfsEXEPath, "init");
            Process.Start(processInfo);
        }
        public void RunNode(bool offlineMode = false)
        {
            var processInfo = new ProcessStartInfo(_ipfsEXEPath, offlineMode ? "daemon --offline" : "daemon");
            _daemonProcess = Process.Start(processInfo);

        }
        public async Task KillNode()
        {

            try
            {
                await Ipfs.ShutdownAsync();
            }
            catch (Exception e)
            {

            }
        }
        public Task<Peer> GetInfo()
        {
            return Ipfs.IdAsync();
        }

        public Task<string> Getstate()
        {
            if (_daemonProcess == null)
                return Task.FromResult(string.Empty);

            return Ipfs.DoCommandAsync("stats/bw", default(CancellationToken));
        }
        #endregion

        #region files


        public async Task<string> AddFileAsync(string filePath, bool pin, DownloadProgressDelegate progressCallBack)
        {
            using (var fileStream = new FileStreamWithProgress(filePath, FileMode.Open, FileAccess.Read))
            {
                fileStream.SetTotalLength(fileStream.Length);
                fileStream.SetCaption("upload progress");
                fileStream.ProgressCallBack += progressCallBack;
                var task = await Ipfs.FileSystem.AddAsync(fileStream, Path.GetFileName(filePath), new AddFileOptions { Pin = pin, Wrap = true });
                fileStream.ProgressCallBack = null;
                return task.Id.Hash.ToString();

            }
        }


        public async Task<string> AddDirectoryAsync(string path, bool pin)
        {
            var task = await Ipfs.FileSystem.AddDirectoryAsync(path, true, new AddFileOptions { Pin = pin });
            return task.Id.Hash.ToString();

        }
        public async Task DownloadFileAsync(string ipfsPath, string path, long fileSize, bool pin, DownloadProgressDelegate progressCallBack)
        {
            // using (var stream = await Ipfs.DownloadAsync("object/get", default(CancellationToken), ipfsPath))
            using (var stream = await Ipfs.FileSystem.ReadFileAsync(ipfsPath))
            {
                using (var fileStream = new FileStreamWithProgress(path, FileMode.Create))//File.Create(path))
                {
                    fileStream.SetTotalLength(fileSize);
                    fileStream.ProgressCallBack += progressCallBack;
                    stream.CopyTo(fileStream);

                    fileStream.ProgressCallBack = null;

                    if (pin)
                    {
                        await Ipfs.Pin.AddAsync(ipfsPath);
                    }
                }
            }
        }

        public async Task<IFileSystemNode> GetFileInfoAsync(string ipfsPath)
        {
            return await Ipfs.FileSystem.ListFileAsync(ipfsPath);
        }

        public async Task<IEnumerable<IPFSFileInfo>> ListAllFiles()
        {
            var json = await Ipfs.DoCommandAsync("refs/local", default(CancellationToken));
            var matchList = Regex.Matches(json, "\"Ref\":\"([\\w]*)");

            var filesInfo = new List<IPFSFileInfo>();
            foreach (Match match in matchList)
            {
                var refHash = match.Groups[1]?.Value;
                if (refHash == null)
                    continue;
                try
                {
                    var file = await GetFileInfoAsync(refHash);
                    if (file.IsDirectory)
                    {
                        foreach (var link in file.Links)
                        {

                            var fileInfo = new IPFSFileInfo
                            {
                                Id = link.Id.Hash.ToString(),
                                ParentId = file.Id.Hash.ToString(),
                                Name = link.Name,
                                Size = link.Size,
                            };
                            filesInfo.Add(fileInfo);
                        }
                    }
                }
                catch (Exception e)
                {

                }
            }
            return filesInfo;
        }

        public async Task RemoveFile(string ipfsPath)
        {
            await Ipfs.Pin.RemoveAsync(ipfsPath);
            await ClearUnPinned();
        }
        public Task ClearUnPinned()
        {
              return Ipfs.DoCommandAsync("repo/gc", default(CancellationToken));
        }
        #endregion

        #region peers
        public Task<IEnumerable<Peer>> ListPeersAsync()
        {

            return Ipfs.Swarm.PeersAsync();
        }

        public Task ConnectToPeerAsync(MultiAddress address)
        {
            return Ipfs.Swarm.ConnectAsync(address);
        }


        public Task<IEnumerable<MultiAddress>> ListBootStraAsync()
        {
            return Ipfs.Bootstrap.ListAsync();
        }
        #endregion

        #region bootstrap
        public Task AddToBootStapAsync(MultiAddress address)
        {
            return Ipfs.Bootstrap.AddAsync(address);
        }

        public Task RemoveFromBootStapAsync(string address)
        {
            return Ipfs.Bootstrap.RemoveAsync(address);
        }

        public Task RemoveAllBootstrap()
        {
            return Ipfs.Bootstrap.RemoveAllAsync();
        }
        public Task ResetBootStrap()
        {
            return Ipfs.Bootstrap.AddDefaultsAsync();
        }
        #endregion
    }
}
