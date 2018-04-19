namespace IPFSLocalNetwork
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_init_repo = new System.Windows.Forms.Button();
            this.btn_run_local_node = new System.Windows.Forms.Button();
            this.btn_stop_local_node = new System.Windows.Forms.Button();
            this.grid_Log = new System.Windows.Forms.DataGridView();
            this.Log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chck_run_offline = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_clear_unpinned = new System.Windows.Forms.Button();
            this.chck_pin_upload_file = new System.Windows.Forms.CheckBox();
            this.chck_pin_upload_dir = new System.Windows.Forms.CheckBox();
            this.txt_upload_directory_hash = new System.Windows.Forms.TextBox();
            this.btn_upload_directory = new System.Windows.Forms.Button();
            this.chck_pin_download = new System.Windows.Forms.CheckBox();
            this.txt_upload_file_hash = new System.Windows.Forms.TextBox();
            this.txt_download_hash = new System.Windows.Forms.TextBox();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_upload_file = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.list_peers = new System.Windows.Forms.ListBox();
            this.btn_ListPeers = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_reset_bootstrap = new System.Windows.Forms.Button();
            this.btn_remove_all_bootstrap = new System.Windows.Forms.Button();
            this.txt_Add_Bootstrap = new System.Windows.Forms.TextBox();
            this.btn_RemoveBootstap = new System.Windows.Forms.Button();
            this.btn_AddBootstap = new System.Windows.Forms.Button();
            this.list_bootstrap = new System.Windows.Forms.ListBox();
            this.btn_listBootstrap = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.rich_txt_stat = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_uplaod_progress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Log)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Info
            // 
            this.btn_Info.Location = new System.Drawing.Point(263, 115);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(103, 24);
            this.btn_Info.TabIndex = 0;
            this.btn_Info.Text = "Local node info";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_init_repo
            // 
            this.btn_init_repo.Location = new System.Drawing.Point(31, 30);
            this.btn_init_repo.Name = "btn_init_repo";
            this.btn_init_repo.Size = new System.Drawing.Size(106, 24);
            this.btn_init_repo.TabIndex = 3;
            this.btn_init_repo.Text = "Init repo";
            this.btn_init_repo.UseVisualStyleBackColor = true;
            this.btn_init_repo.Click += new System.EventHandler(this.btn_init_repo_Click);
            // 
            // btn_run_local_node
            // 
            this.btn_run_local_node.Location = new System.Drawing.Point(260, 30);
            this.btn_run_local_node.Name = "btn_run_local_node";
            this.btn_run_local_node.Size = new System.Drawing.Size(106, 24);
            this.btn_run_local_node.TabIndex = 4;
            this.btn_run_local_node.Text = "Run local node";
            this.btn_run_local_node.UseVisualStyleBackColor = true;
            this.btn_run_local_node.Click += new System.EventHandler(this.btn_run_local_node_Click);
            // 
            // btn_stop_local_node
            // 
            this.btn_stop_local_node.Location = new System.Drawing.Point(260, 77);
            this.btn_stop_local_node.Name = "btn_stop_local_node";
            this.btn_stop_local_node.Size = new System.Drawing.Size(106, 24);
            this.btn_stop_local_node.TabIndex = 5;
            this.btn_stop_local_node.Text = "Stop local node";
            this.btn_stop_local_node.UseVisualStyleBackColor = true;
            this.btn_stop_local_node.Click += new System.EventHandler(this.btn_stop_local_node_Click);
            // 
            // grid_Log
            // 
            this.grid_Log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Log,
            this.Value});
            this.grid_Log.Location = new System.Drawing.Point(16, 390);
            this.grid_Log.Margin = new System.Windows.Forms.Padding(2);
            this.grid_Log.Name = "grid_Log";
            this.grid_Log.ReadOnly = true;
            this.grid_Log.RowTemplate.Height = 24;
            this.grid_Log.Size = new System.Drawing.Size(843, 184);
            this.grid_Log.TabIndex = 6;
            // 
            // Log
            // 
            this.Log.HeaderText = "Log";
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.Width = 200;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 354);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.rich_txt_stat);
            this.tabPage5.Controls.Add(this.chck_run_offline);
            this.tabPage5.Controls.Add(this.btn_init_repo);
            this.tabPage5.Controls.Add(this.btn_Info);
            this.tabPage5.Controls.Add(this.btn_run_local_node);
            this.tabPage5.Controls.Add(this.btn_stop_local_node);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(672, 328);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Node";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chck_run_offline
            // 
            this.chck_run_offline.AutoSize = true;
            this.chck_run_offline.Location = new System.Drawing.Point(167, 30);
            this.chck_run_offline.Name = "chck_run_offline";
            this.chck_run_offline.Size = new System.Drawing.Size(77, 17);
            this.chck_run_offline.TabIndex = 6;
            this.chck_run_offline.Text = "Run offline";
            this.chck_run_offline.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lbl_uplaod_progress);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.btn_clear_unpinned);
            this.tabPage6.Controls.Add(this.chck_pin_upload_file);
            this.tabPage6.Controls.Add(this.chck_pin_upload_dir);
            this.tabPage6.Controls.Add(this.txt_upload_directory_hash);
            this.tabPage6.Controls.Add(this.btn_upload_directory);
            this.tabPage6.Controls.Add(this.chck_pin_download);
            this.tabPage6.Controls.Add(this.txt_upload_file_hash);
            this.tabPage6.Controls.Add(this.txt_download_hash);
            this.tabPage6.Controls.Add(this.btn_Download);
            this.tabPage6.Controls.Add(this.btn_upload_file);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(672, 328);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Files";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_clear_unpinned
            // 
            this.btn_clear_unpinned.Location = new System.Drawing.Point(288, 222);
            this.btn_clear_unpinned.Name = "btn_clear_unpinned";
            this.btn_clear_unpinned.Size = new System.Drawing.Size(176, 42);
            this.btn_clear_unpinned.TabIndex = 9;
            this.btn_clear_unpinned.Text = "Clear unpinned";
            this.btn_clear_unpinned.UseVisualStyleBackColor = true;
            this.btn_clear_unpinned.Click += new System.EventHandler(this.btn_clear_unpinned_Click);
            // 
            // chck_pin_upload_file
            // 
            this.chck_pin_upload_file.AutoSize = true;
            this.chck_pin_upload_file.Checked = true;
            this.chck_pin_upload_file.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_pin_upload_file.Location = new System.Drawing.Point(420, 46);
            this.chck_pin_upload_file.Margin = new System.Windows.Forms.Padding(2);
            this.chck_pin_upload_file.Name = "chck_pin_upload_file";
            this.chck_pin_upload_file.Size = new System.Drawing.Size(44, 17);
            this.chck_pin_upload_file.TabIndex = 8;
            this.chck_pin_upload_file.Text = "Pin ";
            this.chck_pin_upload_file.UseVisualStyleBackColor = true;
            // 
            // chck_pin_upload_dir
            // 
            this.chck_pin_upload_dir.AutoSize = true;
            this.chck_pin_upload_dir.Checked = true;
            this.chck_pin_upload_dir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chck_pin_upload_dir.Location = new System.Drawing.Point(420, 101);
            this.chck_pin_upload_dir.Margin = new System.Windows.Forms.Padding(2);
            this.chck_pin_upload_dir.Name = "chck_pin_upload_dir";
            this.chck_pin_upload_dir.Size = new System.Drawing.Size(44, 17);
            this.chck_pin_upload_dir.TabIndex = 7;
            this.chck_pin_upload_dir.Text = "Pin ";
            this.chck_pin_upload_dir.UseVisualStyleBackColor = true;
            this.chck_pin_upload_dir.Visible = false;
            // 
            // txt_upload_directory_hash
            // 
            this.txt_upload_directory_hash.Location = new System.Drawing.Point(16, 98);
            this.txt_upload_directory_hash.Margin = new System.Windows.Forms.Padding(2);
            this.txt_upload_directory_hash.Name = "txt_upload_directory_hash";
            this.txt_upload_directory_hash.ReadOnly = true;
            this.txt_upload_directory_hash.Size = new System.Drawing.Size(386, 20);
            this.txt_upload_directory_hash.TabIndex = 6;
            this.txt_upload_directory_hash.Text = "Upload hash";
            this.txt_upload_directory_hash.Visible = false;
            // 
            // btn_upload_directory
            // 
            this.btn_upload_directory.Location = new System.Drawing.Point(468, 97);
            this.btn_upload_directory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_upload_directory.Name = "btn_upload_directory";
            this.btn_upload_directory.Size = new System.Drawing.Size(124, 29);
            this.btn_upload_directory.TabIndex = 5;
            this.btn_upload_directory.Text = "Upload directory";
            this.btn_upload_directory.UseVisualStyleBackColor = true;
            this.btn_upload_directory.Visible = false;
            this.btn_upload_directory.Click += new System.EventHandler(this.btn_upload_directory_Click);
            // 
            // chck_pin_download
            // 
            this.chck_pin_download.AutoSize = true;
            this.chck_pin_download.Location = new System.Drawing.Point(420, 147);
            this.chck_pin_download.Margin = new System.Windows.Forms.Padding(2);
            this.chck_pin_download.Name = "chck_pin_download";
            this.chck_pin_download.Size = new System.Drawing.Size(44, 17);
            this.chck_pin_download.TabIndex = 4;
            this.chck_pin_download.Text = "Pin ";
            this.chck_pin_download.UseVisualStyleBackColor = true;
            // 
            // txt_upload_file_hash
            // 
            this.txt_upload_file_hash.Location = new System.Drawing.Point(16, 44);
            this.txt_upload_file_hash.Margin = new System.Windows.Forms.Padding(2);
            this.txt_upload_file_hash.Name = "txt_upload_file_hash";
            this.txt_upload_file_hash.ReadOnly = true;
            this.txt_upload_file_hash.Size = new System.Drawing.Size(386, 20);
            this.txt_upload_file_hash.TabIndex = 3;
            this.txt_upload_file_hash.Text = "Upload hash";
            // 
            // txt_download_hash
            // 
            this.txt_download_hash.Location = new System.Drawing.Point(16, 150);
            this.txt_download_hash.Margin = new System.Windows.Forms.Padding(2);
            this.txt_download_hash.Name = "txt_download_hash";
            this.txt_download_hash.Size = new System.Drawing.Size(386, 20);
            this.txt_download_hash.TabIndex = 2;
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(468, 143);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(124, 28);
            this.btn_Download.TabIndex = 1;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_upload_file
            // 
            this.btn_upload_file.Location = new System.Drawing.Point(468, 44);
            this.btn_upload_file.Margin = new System.Windows.Forms.Padding(2);
            this.btn_upload_file.Name = "btn_upload_file";
            this.btn_upload_file.Size = new System.Drawing.Size(124, 29);
            this.btn_upload_file.TabIndex = 0;
            this.btn_upload_file.Text = "Upload file";
            this.btn_upload_file.UseVisualStyleBackColor = true;
            this.btn_upload_file.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.list_peers);
            this.tabPage1.Controls.Add(this.btn_ListPeers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(672, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Peers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // list_peers
            // 
            this.list_peers.FormattingEnabled = true;
            this.list_peers.Location = new System.Drawing.Point(4, 41);
            this.list_peers.Margin = new System.Windows.Forms.Padding(2);
            this.list_peers.Name = "list_peers";
            this.list_peers.Size = new System.Drawing.Size(657, 303);
            this.list_peers.TabIndex = 10;
            this.list_peers.DoubleClick += new System.EventHandler(this.list_peers_DoubleClick);
            // 
            // btn_ListPeers
            // 
            this.btn_ListPeers.Location = new System.Drawing.Point(2, 5);
            this.btn_ListPeers.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ListPeers.Name = "btn_ListPeers";
            this.btn_ListPeers.Size = new System.Drawing.Size(179, 32);
            this.btn_ListPeers.TabIndex = 7;
            this.btn_ListPeers.Text = "List Peers";
            this.btn_ListPeers.UseVisualStyleBackColor = true;
            this.btn_ListPeers.Click += new System.EventHandler(this.btn_ListPeers_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_reset_bootstrap);
            this.tabPage2.Controls.Add(this.btn_remove_all_bootstrap);
            this.tabPage2.Controls.Add(this.txt_Add_Bootstrap);
            this.tabPage2.Controls.Add(this.btn_RemoveBootstap);
            this.tabPage2.Controls.Add(this.btn_AddBootstap);
            this.tabPage2.Controls.Add(this.list_bootstrap);
            this.tabPage2.Controls.Add(this.btn_listBootstrap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(672, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bootstrap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_reset_bootstrap
            // 
            this.btn_reset_bootstrap.Location = new System.Drawing.Point(479, 263);
            this.btn_reset_bootstrap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset_bootstrap.Name = "btn_reset_bootstrap";
            this.btn_reset_bootstrap.Size = new System.Drawing.Size(179, 26);
            this.btn_reset_bootstrap.TabIndex = 19;
            this.btn_reset_bootstrap.Text = "Reset";
            this.btn_reset_bootstrap.UseVisualStyleBackColor = true;
            this.btn_reset_bootstrap.Click += new System.EventHandler(this.btn_reset_bootstrap_Click);
            // 
            // btn_remove_all_bootstrap
            // 
            this.btn_remove_all_bootstrap.Location = new System.Drawing.Point(239, 263);
            this.btn_remove_all_bootstrap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove_all_bootstrap.Name = "btn_remove_all_bootstrap";
            this.btn_remove_all_bootstrap.Size = new System.Drawing.Size(179, 26);
            this.btn_remove_all_bootstrap.TabIndex = 18;
            this.btn_remove_all_bootstrap.Text = "Remove all";
            this.btn_remove_all_bootstrap.UseVisualStyleBackColor = true;
            this.btn_remove_all_bootstrap.Click += new System.EventHandler(this.btn_remove_all_bootstrap_Click);
            // 
            // txt_Add_Bootstrap
            // 
            this.txt_Add_Bootstrap.Location = new System.Drawing.Point(6, 221);
            this.txt_Add_Bootstrap.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Add_Bootstrap.Name = "txt_Add_Bootstrap";
            this.txt_Add_Bootstrap.Size = new System.Drawing.Size(459, 20);
            this.txt_Add_Bootstrap.TabIndex = 17;
            // 
            // btn_RemoveBootstap
            // 
            this.btn_RemoveBootstap.Location = new System.Drawing.Point(6, 263);
            this.btn_RemoveBootstap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RemoveBootstap.Name = "btn_RemoveBootstap";
            this.btn_RemoveBootstap.Size = new System.Drawing.Size(179, 26);
            this.btn_RemoveBootstap.TabIndex = 16;
            this.btn_RemoveBootstap.Text = "Remve selected from bootstap";
            this.btn_RemoveBootstap.UseVisualStyleBackColor = true;
            this.btn_RemoveBootstap.Click += new System.EventHandler(this.btn_RemoveBootstap_Click);
            // 
            // btn_AddBootstap
            // 
            this.btn_AddBootstap.Location = new System.Drawing.Point(479, 217);
            this.btn_AddBootstap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddBootstap.Name = "btn_AddBootstap";
            this.btn_AddBootstap.Size = new System.Drawing.Size(179, 26);
            this.btn_AddBootstap.TabIndex = 15;
            this.btn_AddBootstap.Text = "Add to bootstap";
            this.btn_AddBootstap.UseVisualStyleBackColor = true;
            this.btn_AddBootstap.Click += new System.EventHandler(this.btn_AddBootstap_Click);
            // 
            // list_bootstrap
            // 
            this.list_bootstrap.FormattingEnabled = true;
            this.list_bootstrap.Location = new System.Drawing.Point(6, 39);
            this.list_bootstrap.Margin = new System.Windows.Forms.Padding(2);
            this.list_bootstrap.Name = "list_bootstrap";
            this.list_bootstrap.Size = new System.Drawing.Size(654, 173);
            this.list_bootstrap.TabIndex = 14;
            this.list_bootstrap.DoubleClick += new System.EventHandler(this.list_bootstrap_DoubleClick);
            // 
            // btn_listBootstrap
            // 
            this.btn_listBootstrap.Location = new System.Drawing.Point(4, 10);
            this.btn_listBootstrap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listBootstrap.Name = "btn_listBootstrap";
            this.btn_listBootstrap.Size = new System.Drawing.Size(179, 26);
            this.btn_listBootstrap.TabIndex = 13;
            this.btn_listBootstrap.Text = "List bootstap";
            this.btn_listBootstrap.UseVisualStyleBackColor = true;
            this.btn_listBootstrap.Click += new System.EventHandler(this.btn_listBootstrap_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(605, 20);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(6, 6);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rich_txt_stat
            // 
            this.rich_txt_stat.Location = new System.Drawing.Point(389, 30);
            this.rich_txt_stat.Name = "rich_txt_stat";
            this.rich_txt_stat.Size = new System.Drawing.Size(265, 115);
            this.rich_txt_stat.TabIndex = 7;
            this.rich_txt_stat.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // lbl_uplaod_progress
            // 
            this.lbl_uplaod_progress.AutoSize = true;
            this.lbl_uplaod_progress.Location = new System.Drawing.Point(607, 50);
            this.lbl_uplaod_progress.Name = "lbl_uplaod_progress";
            this.lbl_uplaod_progress.Size = new System.Drawing.Size(35, 13);
            this.lbl_uplaod_progress.TabIndex = 11;
            this.lbl_uplaod_progress.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 583);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grid_Log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Log)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_init_repo;
        private System.Windows.Forms.Button btn_run_local_node;
        private System.Windows.Forms.Button btn_stop_local_node;
        private System.Windows.Forms.DataGridView grid_Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox list_peers;
        private System.Windows.Forms.Button btn_ListPeers;
        private System.Windows.Forms.ListBox list_bootstrap;
        private System.Windows.Forms.Button btn_listBootstrap;
        private System.Windows.Forms.Button btn_RemoveBootstap;
        private System.Windows.Forms.Button btn_AddBootstap;
        private System.Windows.Forms.TextBox txt_Add_Bootstrap;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txt_upload_file_hash;
        private System.Windows.Forms.TextBox txt_download_hash;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_upload_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_reset_bootstrap;
        private System.Windows.Forms.Button btn_remove_all_bootstrap;
        private System.Windows.Forms.CheckBox chck_pin_download;
        private System.Windows.Forms.TextBox txt_upload_directory_hash;
        private System.Windows.Forms.Button btn_upload_directory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chck_pin_upload_file;
        private System.Windows.Forms.CheckBox chck_pin_upload_dir;
        private System.Windows.Forms.Button btn_clear_unpinned;
        private System.Windows.Forms.CheckBox chck_run_offline;
        private System.Windows.Forms.RichTextBox rich_txt_stat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_uplaod_progress;
        private System.Windows.Forms.Label label1;
    }
}

