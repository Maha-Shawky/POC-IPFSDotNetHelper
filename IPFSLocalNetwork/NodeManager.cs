//https://ipfs.io/docs/getting-started/
///////https://github.com/TrekDev/net-ipfs-api/blob/master/src/Ipfs/Commands/IpfsRoot.cs
//https://github.com/richardschneider/net-ipfs-api/blob/master/src/CoreApi/KeyApi.cs

using Ipfs;
using Ipfs.Api;
using Ipfs.CoreApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

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

        #region node
        public void InitRepo()
        {
            var processInfo = new ProcessStartInfo(_ipfsEXEPath, "init");
            _daemonProcess = Process.Start(processInfo);
        }
        public void RunNode()
        {
            var processInfo = new ProcessStartInfo(_ipfsEXEPath, "daemon");
            _daemonProcess = Process.Start(processInfo);
        }
        public async void KillNodeAsync()
        {
            await Ipfs.ShutdownAsync();
            //if (_daemonProcess != null)
            //{
            //    _daemonProcess.Kill();
            //}
        }
        public Task<Peer> GetInfo()
        {
            return Ipfs.IdAsync();
        }
        #endregion

        #region files
        public async Task<string> AddFileAsync( string filePath, bool pin)
        {
            var task = await Ipfs.FileSystem.AddFileAsync(filePath, new AddFileOptions { Pin = pin });
            return task.Id.Hash.ToString();
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
        
        public async Task DownloadFileAsync(string ipfsPath, string path, bool pin)
        {
            using (var stream = await Ipfs.FileSystem.ReadFileAsync(ipfsPath))
            {
                using (var fileStream = File.Create(path))
                {
                    stream.CopyTo(fileStream);
                    if (pin)
                    {
                        await Ipfs.Pin.AddAsync(ipfsPath);
                    }
                }
            }
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

        public void AddBootStrapPeer(string peerId)
        {
            // ipfsClient.Bootstrap.AddAsync()
        }

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
