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
using System.Threading;
using System.Threading.Tasks;
using static IPFSLocalNetwork.Progress.FileStreamWithProgress;

namespace IPFSLocalNetwork
{
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
            //var ipfsProcesses = Process.GetProcessesByName(_daemonProcess.ProcessName);
            //foreach (var process in ipfsProcesses)
            //{
            //    process.Kill();
            //
        //}
            ////Ipfs.ShutdownAsync().Wait();
            //if (ipfsProcess != null)
            //{
            //    _daemonProcess.Kill();
            //}

            try
            {
                await Ipfs.ShutdownAsync();
            }catch(Exception e)
            {

            }
        }
        public Task<Peer> GetInfo()
        {
            return Ipfs.IdAsync();
        }

        public  Task<string> Getstate()
        {
            if (_daemonProcess == null)
                return Task.FromResult( string.Empty);

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
                var task = await Ipfs.FileSystem.AddAsync(fileStream, Path.GetFileName(filePath), new AddFileOptions { Pin = pin });
                fileStream.ProgressCallBack = null;
                return task.Id.Hash.ToString();
            }
            //    var task = await Ipfs.FileSystem.AddAsync(filePath, new AddFileOptions { Pin = pin });
            //return task.Id.Hash.ToString();
        }


        public async Task<string> AddDirectoryAsync(string path, bool pin)
        {
            var task = await Ipfs.FileSystem.AddDirectoryAsync(path, true, new AddFileOptions { Pin = pin });
            return task.Id.Hash.ToString();

        }

        public async Task<IFileSystemNode> GetFileInfoAsync(string ipfsPath)
        {
            return await Ipfs.FileSystem.ListFileAsync(ipfsPath);
        }

        public async Task DownloadFileAsync(string ipfsPath, string path, bool pin , DownloadProgressDelegate progressCallBack)
        {
            var fileInfo = await GetFileInfoAsync(ipfsPath);
            using (var stream = await Ipfs.FileSystem.ReadFileAsync(ipfsPath))
            {
                using (var fileStream = new FileStreamWithProgress(path , FileMode.Create))//File.Create(path))
                {
                    fileStream.SetTotalLength(fileInfo.Size);
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

        internal Task DownloadFileAsync(string ipfsPath, string fileName, bool pin, object updateDownloadProgress)
        {
            throw new NotImplementedException();
        }

        public async Task ClearUnPinned()
        {
            await Ipfs.DoCommandAsync("repo/gc", default(CancellationToken));
        }
        #endregion

        #region peers
        public Task<IEnumerable<Peer>> ListPeersAsync()
        {

            return Ipfs.Swarm.PeersAsync();
        }

        //public void AddBootStrapPeer(string peerId)
        //{
        //    ipfsClient.Bootstrap.AddAsync();
        //}

        public Task<IEnumerable<MultiAddress>> ListBootStraAsync()
        {
            return Ipfs.Bootstrap.ListAsync();
        }
        #endregion

        #region bootstrap
        public Task AddToBootStapAsync(string address)
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
