//https://ipfs.io/docs/getting-started/
//https://github.com/TrekDev/net-ipfs-api/blob/master/src/Ipfs/Commands/IpfsRoot.cs
//https://github.com/richardschneider/net-ipfs-api/blob/master/src/CoreApi/KeyApi.cs

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IPFSLocalNetwork
{
    public partial class Form1 : Form
    {
        NodeManager nodeManager = new NodeManager();
        public Form1()
        {
            InitializeComponent();
        }
        private void WriteLineLog(string text, string title = "")
        {
            grid_Log.Rows.Add(title, text);
        }
        private void HandleException(Exception ex)
        {
            WriteLineLog(ex.StackTrace, "Exception");
            MessageBox.Show(ex.Message);
        }

        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // nodeManager.RunNode();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //  nodeManager.KillNode();
            }
            catch (Exception ex) { HandleException(ex); }

        }
        #endregion

        #region node
        private void btn_init_repo_Click(object sender, EventArgs e)
        {
            try
            {
                nodeManager.InitRepo();
            }
            catch (Exception ex) { HandleException(ex); }


        }

        private void btn_run_local_node_Click(object sender, EventArgs e)
        {
            try
            {
                nodeManager.RunNode();
            }
            catch (Exception ex) { HandleException(ex); }

        }

        private void btn_stop_local_node_Click(object sender, EventArgs e)
        {
            try
            {
                nodeManager.KillNodeAsync();
            }
            catch (Exception ex) { HandleException(ex); }
        }
        private async void btn_Info_Click(object sender, EventArgs e)
        {
            try
            {
                // await nodeManager.GetInfo();
                var ipfsId = await nodeManager.GetInfo();
                WriteLineLog("", "Node info");

                WriteLineLog(ipfsId.Id.ToString(), "Id");

                WriteLineLog(ipfsId.PublicKey, "PublicKey");

                var mutiAddresses = ipfsId.Addresses as IEnumerable<Ipfs.MultiAddress>;
                var strMutiAddresses = string.Empty;

                foreach (var add in mutiAddresses)
                {
                    strMutiAddresses += $"{add.ToString()}\n";
                }
                WriteLineLog(strMutiAddresses, "Addresses");
            }
            catch (Exception ex) { HandleException(ex); }
        }
        #endregion

        #region Files
        private async void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                var dr = openFileDialog1.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    string hash = await nodeManager.AddFileAsync(openFileDialog1.FileName);
                    txt_upload_file_hash.Text = hash;
                }

            }
            catch (Exception ex) { HandleException(ex); }

        }
        private async void btn_upload_directory_Click(object sender, EventArgs e)
        {
            try
            {
                var dr = folderBrowserDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string hash = await nodeManager.AddDirectoryAsync(folderBrowserDialog1.SelectedPath);
                    txt_upload_directory_hash.Text = hash;
                }
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private async void btn_Download_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var stream = await nodeManager.GetFileAsync(txt_download_hash.Text, chck_pin_file.Checked);
                   // stream.w
                   //TODO
                }
            }
            catch (Exception ex) { HandleException(ex); }
        }
        #endregion

        #region peers
        private async void btn_ListPeers_Click(object sender, EventArgs e)
        {
            try
            {
                var peers = await nodeManager.ListPeersAsync();
                list_peers.Items.Clear();
                foreach (var peer in peers)
                {
                    list_peers.Items.Add(peer);
                }
            }
            catch (Exception ex) { HandleException(ex); }
        }


        private void list_peers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var peer = list_peers.SelectedItem as Ipfs.Peer;

                var messge = $"Id: {peer.Id}\nConnectionAddress: {peer.ConnectedAddress}";
                MessageBox.Show(messge, "Info copie to clipboard");
                Clipboard.SetText(messge);
            }
            catch (Exception ex) { HandleException(ex); }

        }

        #endregion

        #region bootstrap
        private async void ResetBootStrap()
        {
            var bootstrap = await nodeManager.ListBootStraAsync();
            list_bootstrap.Items.Clear();
            foreach (var peer in bootstrap)
            {
                list_bootstrap.Items.Add(peer);
            }
        }
        private  void btn_listBootstrap_Click(object sender, EventArgs e)
        {
            try
            {
                ResetBootStrap();
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private async void btn_AddBootstap_Click(object sender, EventArgs e)
        {
            try
            {
                var address = txt_Add_Bootstrap.Text;
                await nodeManager.AddToBootStapAsync(address);
                ResetBootStrap();
            }
            catch (Exception ex) { HandleException(ex); }

        }

        private async void btn_RemoveBootstap_Click(object sender, EventArgs e)
        {
            try
            {
                var address = list_bootstrap.SelectedItem.ToString();
                await nodeManager.RemoveFromBootStapAsync(address);
                ResetBootStrap();
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private void list_bootstrap_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var bootstrap = list_bootstrap.SelectedItem;
                Clipboard.SetText(bootstrap.ToString());
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private async void btn_remove_all_bootstrap_Click(object sender, EventArgs e)
        {
            try
            {
                await nodeManager.RemoveAllBootstrap();
                ResetBootStrap();
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private async void btn_reset_bootstrap_Click(object sender, EventArgs e)
        {
            try
            {
                await nodeManager.ResetBootStrap();
                ResetBootStrap();
            }
            catch (Exception ex) { HandleException(ex); }
        }
        #endregion
    }
}
