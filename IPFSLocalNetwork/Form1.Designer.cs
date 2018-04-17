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
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_init_repo = new System.Windows.Forms.Button();
            this.btn_run_local_node = new System.Windows.Forms.Button();
            this.btn_stop_local_node = new System.Windows.Forms.Button();
            this.grid_Log = new System.Windows.Forms.DataGridView();
            this.Log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chck_pin_file = new System.Windows.Forms.CheckBox();
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
            this.txt_upload_directory_hash = new System.Windows.Forms.TextBox();
            this.btn_upload_directory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
            this.btn_Info.Location = new System.Drawing.Point(252, 142);
            this.btn_Info.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(137, 30);
            this.btn_Info.TabIndex = 0;
            this.btn_Info.Text = "Local node info";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_init_repo
            // 
            this.btn_init_repo.Location = new System.Drawing.Point(41, 37);
            this.btn_init_repo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_init_repo.Name = "btn_init_repo";
            this.btn_init_repo.Size = new System.Drawing.Size(141, 30);
            this.btn_init_repo.TabIndex = 3;
            this.btn_init_repo.Text = "Init repo";
            this.btn_init_repo.UseVisualStyleBackColor = true;
            this.btn_init_repo.Click += new System.EventHandler(this.btn_init_repo_Click);
            // 
            // btn_run_local_node
            // 
            this.btn_run_local_node.Location = new System.Drawing.Point(248, 37);
            this.btn_run_local_node.Margin = new System.Windows.Forms.Padding(4);
            this.btn_run_local_node.Name = "btn_run_local_node";
            this.btn_run_local_node.Size = new System.Drawing.Size(141, 30);
            this.btn_run_local_node.TabIndex = 4;
            this.btn_run_local_node.Text = "Run local node";
            this.btn_run_local_node.UseVisualStyleBackColor = true;
            this.btn_run_local_node.Click += new System.EventHandler(this.btn_run_local_node_Click);
            // 
            // btn_stop_local_node
            // 
            this.btn_stop_local_node.Location = new System.Drawing.Point(248, 95);
            this.btn_stop_local_node.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stop_local_node.Name = "btn_stop_local_node";
            this.btn_stop_local_node.Size = new System.Drawing.Size(141, 30);
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
            this.grid_Log.Location = new System.Drawing.Point(22, 480);
            this.grid_Log.Name = "grid_Log";
            this.grid_Log.ReadOnly = true;
            this.grid_Log.RowTemplate.Height = 24;
            this.grid_Log.Size = new System.Drawing.Size(1124, 226);
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
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 436);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_init_repo);
            this.tabPage5.Controls.Add(this.btn_Info);
            this.tabPage5.Controls.Add(this.btn_run_local_node);
            this.tabPage5.Controls.Add(this.btn_stop_local_node);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(899, 407);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Node";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txt_upload_directory_hash);
            this.tabPage6.Controls.Add(this.btn_upload_directory);
            this.tabPage6.Controls.Add(this.chck_pin_file);
            this.tabPage6.Controls.Add(this.txt_upload_file_hash);
            this.tabPage6.Controls.Add(this.txt_download_hash);
            this.tabPage6.Controls.Add(this.btn_Download);
            this.tabPage6.Controls.Add(this.btn_upload_file);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(899, 407);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Files";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chck_pin_file
            // 
            this.chck_pin_file.AutoSize = true;
            this.chck_pin_file.Enabled = false;
            this.chck_pin_file.Location = new System.Drawing.Point(665, 172);
            this.chck_pin_file.Name = "chck_pin_file";
            this.chck_pin_file.Size = new System.Drawing.Size(54, 21);
            this.chck_pin_file.TabIndex = 4;
            this.chck_pin_file.Text = "Pin ";
            this.chck_pin_file.UseVisualStyleBackColor = true;
            // 
            // txt_upload_file_hash
            // 
            this.txt_upload_file_hash.Location = new System.Drawing.Point(22, 54);
            this.txt_upload_file_hash.Name = "txt_upload_file_hash";
            this.txt_upload_file_hash.ReadOnly = true;
            this.txt_upload_file_hash.Size = new System.Drawing.Size(514, 22);
            this.txt_upload_file_hash.TabIndex = 3;
            this.txt_upload_file_hash.Text = "Upload hash";
            // 
            // txt_download_hash
            // 
            this.txt_download_hash.Location = new System.Drawing.Point(22, 185);
            this.txt_download_hash.Name = "txt_download_hash";
            this.txt_download_hash.Size = new System.Drawing.Size(514, 22);
            this.txt_download_hash.TabIndex = 2;
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(554, 172);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(105, 35);
            this.btn_Download.TabIndex = 1;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_upload_file
            // 
            this.btn_upload_file.Location = new System.Drawing.Point(554, 50);
            this.btn_upload_file.Name = "btn_upload_file";
            this.btn_upload_file.Size = new System.Drawing.Size(165, 36);
            this.btn_upload_file.TabIndex = 0;
            this.btn_upload_file.Text = "Upload file";
            this.btn_upload_file.UseVisualStyleBackColor = true;
            this.btn_upload_file.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.list_peers);
            this.tabPage1.Controls.Add(this.btn_ListPeers);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Peers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // list_peers
            // 
            this.list_peers.FormattingEnabled = true;
            this.list_peers.ItemHeight = 16;
            this.list_peers.Location = new System.Drawing.Point(6, 51);
            this.list_peers.Name = "list_peers";
            this.list_peers.Size = new System.Drawing.Size(875, 372);
            this.list_peers.TabIndex = 10;
            this.list_peers.DoubleClick += new System.EventHandler(this.list_peers_DoubleClick);
            // 
            // btn_ListPeers
            // 
            this.btn_ListPeers.Location = new System.Drawing.Point(3, 6);
            this.btn_ListPeers.Name = "btn_ListPeers";
            this.btn_ListPeers.Size = new System.Drawing.Size(239, 39);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(899, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bootstrap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_reset_bootstrap
            // 
            this.btn_reset_bootstrap.Location = new System.Drawing.Point(639, 324);
            this.btn_reset_bootstrap.Name = "btn_reset_bootstrap";
            this.btn_reset_bootstrap.Size = new System.Drawing.Size(239, 32);
            this.btn_reset_bootstrap.TabIndex = 19;
            this.btn_reset_bootstrap.Text = "Reset";
            this.btn_reset_bootstrap.UseVisualStyleBackColor = true;
            this.btn_reset_bootstrap.Click += new System.EventHandler(this.btn_reset_bootstrap_Click);
            // 
            // btn_remove_all_bootstrap
            // 
            this.btn_remove_all_bootstrap.Location = new System.Drawing.Point(319, 324);
            this.btn_remove_all_bootstrap.Name = "btn_remove_all_bootstrap";
            this.btn_remove_all_bootstrap.Size = new System.Drawing.Size(239, 32);
            this.btn_remove_all_bootstrap.TabIndex = 18;
            this.btn_remove_all_bootstrap.Text = "Remove all";
            this.btn_remove_all_bootstrap.UseVisualStyleBackColor = true;
            this.btn_remove_all_bootstrap.Click += new System.EventHandler(this.btn_remove_all_bootstrap_Click);
            // 
            // txt_Add_Bootstrap
            // 
            this.txt_Add_Bootstrap.Location = new System.Drawing.Point(8, 272);
            this.txt_Add_Bootstrap.Name = "txt_Add_Bootstrap";
            this.txt_Add_Bootstrap.Size = new System.Drawing.Size(611, 22);
            this.txt_Add_Bootstrap.TabIndex = 17;
            // 
            // btn_RemoveBootstap
            // 
            this.btn_RemoveBootstap.Location = new System.Drawing.Point(8, 324);
            this.btn_RemoveBootstap.Name = "btn_RemoveBootstap";
            this.btn_RemoveBootstap.Size = new System.Drawing.Size(239, 32);
            this.btn_RemoveBootstap.TabIndex = 16;
            this.btn_RemoveBootstap.Text = "Remve selected from bootstap";
            this.btn_RemoveBootstap.UseVisualStyleBackColor = true;
            this.btn_RemoveBootstap.Click += new System.EventHandler(this.btn_RemoveBootstap_Click);
            // 
            // btn_AddBootstap
            // 
            this.btn_AddBootstap.Location = new System.Drawing.Point(639, 267);
            this.btn_AddBootstap.Name = "btn_AddBootstap";
            this.btn_AddBootstap.Size = new System.Drawing.Size(239, 32);
            this.btn_AddBootstap.TabIndex = 15;
            this.btn_AddBootstap.Text = "Add to bootstap";
            this.btn_AddBootstap.UseVisualStyleBackColor = true;
            this.btn_AddBootstap.Click += new System.EventHandler(this.btn_AddBootstap_Click);
            // 
            // list_bootstrap
            // 
            this.list_bootstrap.FormattingEnabled = true;
            this.list_bootstrap.ItemHeight = 16;
            this.list_bootstrap.Location = new System.Drawing.Point(8, 48);
            this.list_bootstrap.Name = "list_bootstrap";
            this.list_bootstrap.Size = new System.Drawing.Size(870, 212);
            this.list_bootstrap.TabIndex = 14;
            this.list_bootstrap.DoubleClick += new System.EventHandler(this.list_bootstrap_DoubleClick);
            // 
            // btn_listBootstrap
            // 
            this.btn_listBootstrap.Location = new System.Drawing.Point(5, 12);
            this.btn_listBootstrap.Name = "btn_listBootstrap";
            this.btn_listBootstrap.Size = new System.Drawing.Size(239, 32);
            this.btn_listBootstrap.TabIndex = 13;
            this.btn_listBootstrap.Text = "List bootstap";
            this.btn_listBootstrap.UseVisualStyleBackColor = true;
            this.btn_listBootstrap.Click += new System.EventHandler(this.btn_listBootstrap_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(807, 24);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_upload_directory_hash
            // 
            this.txt_upload_directory_hash.Location = new System.Drawing.Point(22, 120);
            this.txt_upload_directory_hash.Name = "txt_upload_directory_hash";
            this.txt_upload_directory_hash.ReadOnly = true;
            this.txt_upload_directory_hash.Size = new System.Drawing.Size(514, 22);
            this.txt_upload_directory_hash.TabIndex = 6;
            this.txt_upload_directory_hash.Text = "Upload hash";
            // 
            // btn_upload_directory
            // 
            this.btn_upload_directory.Location = new System.Drawing.Point(554, 116);
            this.btn_upload_directory.Name = "btn_upload_directory";
            this.btn_upload_directory.Size = new System.Drawing.Size(165, 36);
            this.btn_upload_directory.TabIndex = 5;
            this.btn_upload_directory.Text = "Upload directory";
            this.btn_upload_directory.UseVisualStyleBackColor = true;
            this.btn_upload_directory.Click += new System.EventHandler(this.btn_upload_directory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 718);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grid_Log);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Log)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox chck_pin_file;
        private System.Windows.Forms.TextBox txt_upload_directory_hash;
        private System.Windows.Forms.Button btn_upload_directory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

