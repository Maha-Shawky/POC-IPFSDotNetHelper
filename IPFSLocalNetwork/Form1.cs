using ByteSizeLib;
using IPFSLocalNetwork.Progress;
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
            rich_txt_stat.Font = new System.Drawing.Font("Arial", 14);
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
                nodeManager.RunNode(chck_run_offline.Checked);
            }
            catch (Exception ex) { HandleException(ex); }

        }

        private void btn_stop_local_node_Click(object sender, EventArgs e)
        {
            try
            {
                nodeManager.KillNode();
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

        private void UpdateProgress(StreamingProgressData progress)
        {
            lbl_uplaod_progress.Invoke(new Action(() => lbl_uplaod_progress.Text = $"{progress.progressPercentage}%"));
        }

        private async void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                var dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    lbl_uplaod_progress.Text = string.Empty;
                    txt_upload_file_hash.Text = string.Empty;

                    var pin = chck_pin_upload_file.Checked;
                    string hash = await nodeManager.AddFileAsync(openFileDialog1.FileName, pin, UpdateProgress);
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
                    var pin = chck_pin_upload_dir.Checked;
                    string hash = await nodeManager.AddDirectoryAsync(folderBrowserDialog1.SelectedPath, pin);
                    txt_upload_directory_hash.Text = hash;
                }
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private async void btn_Download_Click(object sender, EventArgs e)
        {
            try
            {
                string ipfsPath = txt_download_hash.Text;

                //var nodeInfo = await nodeManager.GetFileInfoAsync(ipfsPath);

                DialogResult dr = saveFileDialog1.ShowDialog();
                var pin = chck_pin_download.Checked;
                if (dr == DialogResult.OK)
                {
                    await nodeManager.DownloadFileAsync(ipfsPath, saveFileDialog1.FileName, pin);

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
                list_peers.Items.Clear();
                var peers = await nodeManager.ListPeersAsync();
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
            list_bootstrap.Items.Clear();
            var bootstrap = await nodeManager.ListBootStraAsync();
            foreach (var peer in bootstrap)
            {
                list_bootstrap.Items.Add(peer);
            }
        }
        private void btn_listBootstrap_Click(object sender, EventArgs e)
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

        private async void btn_clear_unpinned_Click(object sender, EventArgs e)
        {
            try
            {
                await nodeManager.ClearUnPinned();

            }
            catch (Exception ex) { HandleException(ex); }
        }

        private double FromDynamicBytesToKillos(dynamic bytes)
        {
            return Math.Round(ByteSize.FromBytes((double)bytes).KiloBytes,2);
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var statAsStr  = await nodeManager.Getstate();
                dynamic statAsObj = Newtonsoft.Json.JsonConvert.DeserializeObject(statAsStr);
                if (statAsObj != null)
                {
                    var totalIn = FromDynamicBytesToKillos(statAsObj.TotalIn);
                    var totalOut = FromDynamicBytesToKillos(statAsObj.TotalOut);
                    var rateIn = FromDynamicBytesToKillos(statAsObj.RateIn);
                    var rateOut = FromDynamicBytesToKillos(statAsObj.RateOut);

                    var text = $"Total in = {totalIn} kB \nTotal out = {totalOut} kB \nRange in = {rateIn} kB\\s \nRange out = {rateOut} kB\\s";
                    rich_txt_stat.Text = text;
                    //var count = chart_state.Series["TotalIn"].Points.Count;
                    //if (chart_state.Series["TotalIn"].Points.Count > 5)
                    //{
                    //    chart_state.Series["TotalIn"].Points.RemoveAt(0);
                    //}

                    //chart_state.Series["TotalIn"].Points.AddXY(count, TotalIn);

                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}
