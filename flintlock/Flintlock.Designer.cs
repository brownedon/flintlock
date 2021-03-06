﻿namespace flintlock
{
    partial class Flintlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flintlock));
            this.connectionLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PebbleList = new System.Windows.Forms.ComboBox();
            this.connectButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Connect = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.WatchfacePic = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.LastKnownPebblePort = new System.Windows.Forms.Label();
            this.MinToTray = new System.Windows.Forms.CheckBox();
            this.Autoconnect = new System.Windows.Forms.CheckBox();
            this.ShowInTray = new System.Windows.Forms.CheckBox();
            this.MediaControlchk = new System.Windows.Forms.CheckBox();
            this.tagLastKnownPebble = new System.Windows.Forms.Label();
            this.ReloadSettings = new System.Windows.Forms.Button();
            this.LastKnownPebbleID = new System.Windows.Forms.Label();
            this.PPTControlchk = new System.Windows.Forms.CheckBox();
            this.Defaults = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.FirmwarePage = new System.Windows.Forms.TabPage();
            this.fwLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RecovFWBox = new System.Windows.Forms.GroupBox();
            this.FWRecovMetadataVersion = new System.Windows.Forms.Label();
            this.tagFWRecovMetadataVersion = new System.Windows.Forms.Label();
            this.FWRecovHWPlatform = new System.Windows.Forms.Label();
            this.tagFWRecovHWPlatform = new System.Windows.Forms.Label();
            this.FWRecovTimestamp = new System.Windows.Forms.Label();
            this.tagFWRecovTimestamp = new System.Windows.Forms.Label();
            this.FWRecovVersion = new System.Windows.Forms.Label();
            this.tagFWRecovVersion = new System.Windows.Forms.Label();
            this.MainFWBox = new System.Windows.Forms.GroupBox();
            this.FWMainMetadataVersion = new System.Windows.Forms.Label();
            this.tagFWMainMetadataVersion = new System.Windows.Forms.Label();
            this.FWMainHWPlatform = new System.Windows.Forms.Label();
            this.tagFWMainHWPlatform = new System.Windows.Forms.Label();
            this.FWMainTimestamp = new System.Windows.Forms.Label();
            this.tagFWMainTimestamp = new System.Windows.Forms.Label();
            this.FWMainVersion = new System.Windows.Forms.Label();
            this.tagFWMainVersion = new System.Windows.Forms.Label();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FOSS = new System.Windows.Forms.Label();
            this.Deps = new System.Windows.Forms.Label();
            this.FOSSLink = new System.Windows.Forms.LinkLabel();
            this.DepsLinks = new System.Windows.Forms.LinkLabel();
            this.Author = new System.Windows.Forms.Label();
            this.AuthorLink = new System.Windows.Forms.LinkLabel();
            this.notificationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pebbleNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.outerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.connectionLayoutPanel.SuspendLayout();
            this.connectButtonsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatchfacePic)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.FirmwarePage.SuspendLayout();
            this.fwLayoutPanel.SuspendLayout();
            this.RecovFWBox.SuspendLayout();
            this.MainFWBox.SuspendLayout();
            this.aboutPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.notificationMenu.SuspendLayout();
            this.outerLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionLayoutPanel
            // 
            this.connectionLayoutPanel.AutoSize = true;
            this.connectionLayoutPanel.ColumnCount = 1;
            this.connectionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectionLayoutPanel.Controls.Add(this.PebbleList, 0, 0);
            this.connectionLayoutPanel.Controls.Add(this.connectButtonsLayoutPanel, 0, 1);
            this.connectionLayoutPanel.Controls.Add(this.WatchfacePic, 0, 2);
            this.connectionLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.connectionLayoutPanel.Name = "connectionLayoutPanel";
            this.connectionLayoutPanel.RowCount = 3;
            this.connectionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.connectionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.connectionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.connectionLayoutPanel.Size = new System.Drawing.Size(210, 256);
            this.connectionLayoutPanel.TabIndex = 0;
            // 
            // PebbleList
            // 
            this.PebbleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PebbleList.Enabled = false;
            this.PebbleList.FormattingEnabled = true;
            this.PebbleList.Location = new System.Drawing.Point(3, 3);
            this.PebbleList.Name = "PebbleList";
            this.PebbleList.Size = new System.Drawing.Size(204, 24);
            this.PebbleList.TabIndex = 0;
            // 
            // connectButtonsLayoutPanel
            // 
            this.connectButtonsLayoutPanel.ColumnCount = 2;
            this.connectButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectButtonsLayoutPanel.Controls.Add(this.Connect, 0, 0);
            this.connectButtonsLayoutPanel.Controls.Add(this.Scan, 1, 0);
            this.connectButtonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectButtonsLayoutPanel.Location = new System.Drawing.Point(3, 33);
            this.connectButtonsLayoutPanel.Name = "connectButtonsLayoutPanel";
            this.connectButtonsLayoutPanel.RowCount = 1;
            this.connectButtonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectButtonsLayoutPanel.Size = new System.Drawing.Size(204, 34);
            this.connectButtonsLayoutPanel.TabIndex = 1;
            // 
            // Connect
            // 
            this.Connect.AutoSize = true;
            this.Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Connect.Enabled = false;
            this.Connect.Location = new System.Drawing.Point(3, 3);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(96, 28);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "&Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Scan
            // 
            this.Scan.AutoSize = true;
            this.Scan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scan.Location = new System.Drawing.Point(105, 3);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(96, 28);
            this.Scan.TabIndex = 1;
            this.Scan.Text = "&Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // WatchfacePic
            // 
            this.WatchfacePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WatchfacePic.Image = global::flintlock.Properties.Resources.watchface_off;
            this.WatchfacePic.Location = new System.Drawing.Point(14, 73);
            this.WatchfacePic.Name = "WatchfacePic";
            this.WatchfacePic.Size = new System.Drawing.Size(182, 180);
            this.WatchfacePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WatchfacePic.TabIndex = 2;
            this.WatchfacePic.TabStop = false;
            this.WatchfacePic.Click += new System.EventHandler(this.WatchfacePic_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.SettingsPage);
            this.tabControl.Controls.Add(this.FirmwarePage);
            this.tabControl.Controls.Add(this.aboutPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(219, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(422, 261);
            this.tabControl.TabIndex = 2;
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.LastKnownPebblePort);
            this.SettingsPage.Controls.Add(this.MinToTray);
            this.SettingsPage.Controls.Add(this.Autoconnect);
            this.SettingsPage.Controls.Add(this.ShowInTray);
            this.SettingsPage.Controls.Add(this.MediaControlchk);
            this.SettingsPage.Controls.Add(this.tagLastKnownPebble);
            this.SettingsPage.Controls.Add(this.ReloadSettings);
            this.SettingsPage.Controls.Add(this.LastKnownPebbleID);
            this.SettingsPage.Controls.Add(this.PPTControlchk);
            this.SettingsPage.Controls.Add(this.Defaults);
            this.SettingsPage.Controls.Add(this.Apply);
            this.SettingsPage.Location = new System.Drawing.Point(4, 25);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(414, 232);
            this.SettingsPage.TabIndex = 0;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // LastKnownPebblePort
            // 
            this.LastKnownPebblePort.AutoSize = true;
            this.LastKnownPebblePort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::flintlock.Properties.Settings.Default, "LastKnownPebblePort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LastKnownPebblePort.Location = new System.Drawing.Point(210, 151);
            this.LastKnownPebblePort.Name = "LastKnownPebblePort";
            this.LastKnownPebblePort.Size = new System.Drawing.Size(47, 17);
            this.LastKnownPebblePort.TabIndex = 10;
            this.LastKnownPebblePort.Text = global::flintlock.Properties.Settings.Default.LastKnownPebblePort;
            // 
            // MinToTray
            // 
            this.MinToTray.AutoSize = true;
            this.MinToTray.Checked = global::flintlock.Properties.Settings.Default.MinimizeToTray;
            this.MinToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MinToTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "MinimizeToTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MinToTray.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::flintlock.Properties.Settings.Default, "ShowInTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MinToTray.Enabled = global::flintlock.Properties.Settings.Default.ShowInTray;
            this.MinToTray.Location = new System.Drawing.Point(29, 100);
            this.MinToTray.Name = "MinToTray";
            this.MinToTray.Size = new System.Drawing.Size(128, 21);
            this.MinToTray.TabIndex = 9;
            this.MinToTray.Text = "Minimize to tray";
            this.MinToTray.UseVisualStyleBackColor = true;
            // 
            // Autoconnect
            // 
            this.Autoconnect.AutoSize = true;
            this.Autoconnect.Checked = global::flintlock.Properties.Settings.Default.Autoconnect;
            this.Autoconnect.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "Autoconnect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Autoconnect.Location = new System.Drawing.Point(6, 127);
            this.Autoconnect.Name = "Autoconnect";
            this.Autoconnect.Size = new System.Drawing.Size(243, 21);
            this.Autoconnect.TabIndex = 5;
            this.Autoconnect.Text = "Autoconnect to last known Pebble";
            this.Autoconnect.UseVisualStyleBackColor = true;
            // 
            // ShowInTray
            // 
            this.ShowInTray.AutoSize = true;
            this.ShowInTray.Checked = global::flintlock.Properties.Settings.Default.ShowInTray;
            this.ShowInTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowInTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "ShowInTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ShowInTray.Location = new System.Drawing.Point(6, 73);
            this.ShowInTray.Name = "ShowInTray";
            this.ShowInTray.Size = new System.Drawing.Size(122, 21);
            this.ShowInTray.TabIndex = 8;
            this.ShowInTray.Text = "Show tray icon";
            this.ShowInTray.UseVisualStyleBackColor = true;
            this.ShowInTray.CheckedChanged += new System.EventHandler(this.ShowInTray_CheckedChanged);
            // 
            // MediaControlchk
            // 
            this.MediaControlchk.AutoSize = true;
            this.MediaControlchk.Checked = global::flintlock.Properties.Settings.Default.MediaControl;
            this.MediaControlchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MediaControlchk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "MediaControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MediaControlchk.Location = new System.Drawing.Point(6, 6);
            this.MediaControlchk.Name = "MediaControlchk";
            this.MediaControlchk.Size = new System.Drawing.Size(177, 21);
            this.MediaControlchk.TabIndex = 1;
            this.MediaControlchk.Text = "Control media playback";
            this.MediaControlchk.UseVisualStyleBackColor = true;
            // 
            // tagLastKnownPebble
            // 
            this.tagLastKnownPebble.AutoSize = true;
            this.tagLastKnownPebble.Location = new System.Drawing.Point(26, 151);
            this.tagLastKnownPebble.Name = "tagLastKnownPebble";
            this.tagLastKnownPebble.Size = new System.Drawing.Size(131, 17);
            this.tagLastKnownPebble.TabIndex = 7;
            this.tagLastKnownPebble.Text = "Last known Pebble:";
            // 
            // ReloadSettings
            // 
            this.ReloadSettings.AutoSize = true;
            this.ReloadSettings.Location = new System.Drawing.Point(87, 199);
            this.ReloadSettings.Name = "ReloadSettings";
            this.ReloadSettings.Size = new System.Drawing.Size(75, 27);
            this.ReloadSettings.TabIndex = 3;
            this.ReloadSettings.Text = "&Reset";
            this.ReloadSettings.UseVisualStyleBackColor = true;
            this.ReloadSettings.Click += new System.EventHandler(this.ReloadSettings_Click);
            // 
            // LastKnownPebbleID
            // 
            this.LastKnownPebbleID.AutoSize = true;
            this.LastKnownPebbleID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::flintlock.Properties.Settings.Default, "LastKnownPebble", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LastKnownPebbleID.Location = new System.Drawing.Point(163, 151);
            this.LastKnownPebbleID.Name = "LastKnownPebbleID";
            this.LastKnownPebbleID.Size = new System.Drawing.Size(40, 17);
            this.LastKnownPebbleID.TabIndex = 6;
            this.LastKnownPebbleID.Text = global::flintlock.Properties.Settings.Default.LastKnownPebble;
            // 
            // PPTControlchk
            // 
            this.PPTControlchk.AutoSize = true;
            this.PPTControlchk.Checked = global::flintlock.Properties.Settings.Default.PPTControl;
            this.PPTControlchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PPTControlchk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "PPTControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PPTControlchk.Location = new System.Drawing.Point(6, 33);
            this.PPTControlchk.Name = "PPTControlchk";
            this.PPTControlchk.Size = new System.Drawing.Size(411, 21);
            this.PPTControlchk.TabIndex = 0;
            this.PPTControlchk.Text = "Control PowerPoint (blocks media control when PPT is open)";
            this.PPTControlchk.UseVisualStyleBackColor = true;
            // 
            // Defaults
            // 
            this.Defaults.AutoSize = true;
            this.Defaults.Location = new System.Drawing.Point(333, 199);
            this.Defaults.Name = "Defaults";
            this.Defaults.Size = new System.Drawing.Size(75, 27);
            this.Defaults.TabIndex = 4;
            this.Defaults.Text = "&Defaults";
            this.Defaults.UseVisualStyleBackColor = true;
            this.Defaults.Click += new System.EventHandler(this.Defaults_Click);
            // 
            // Apply
            // 
            this.Apply.AutoSize = true;
            this.Apply.Location = new System.Drawing.Point(6, 199);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 27);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "&Save";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Save_Click);
            // 
            // FirmwarePage
            // 
            this.FirmwarePage.Controls.Add(this.fwLayoutPanel);
            this.FirmwarePage.Location = new System.Drawing.Point(4, 25);
            this.FirmwarePage.Name = "FirmwarePage";
            this.FirmwarePage.Padding = new System.Windows.Forms.Padding(3);
            this.FirmwarePage.Size = new System.Drawing.Size(414, 232);
            this.FirmwarePage.TabIndex = 1;
            this.FirmwarePage.Text = "Firmware";
            this.FirmwarePage.UseVisualStyleBackColor = true;
            // 
            // fwLayoutPanel
            // 
            this.fwLayoutPanel.ColumnCount = 2;
            this.fwLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fwLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fwLayoutPanel.Controls.Add(this.RecovFWBox, 1, 0);
            this.fwLayoutPanel.Controls.Add(this.MainFWBox, 0, 0);
            this.fwLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fwLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.fwLayoutPanel.Name = "fwLayoutPanel";
            this.fwLayoutPanel.RowCount = 1;
            this.fwLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fwLayoutPanel.Size = new System.Drawing.Size(408, 226);
            this.fwLayoutPanel.TabIndex = 2;
            // 
            // RecovFWBox
            // 
            this.RecovFWBox.Controls.Add(this.FWRecovMetadataVersion);
            this.RecovFWBox.Controls.Add(this.tagFWRecovMetadataVersion);
            this.RecovFWBox.Controls.Add(this.FWRecovHWPlatform);
            this.RecovFWBox.Controls.Add(this.tagFWRecovHWPlatform);
            this.RecovFWBox.Controls.Add(this.FWRecovTimestamp);
            this.RecovFWBox.Controls.Add(this.tagFWRecovTimestamp);
            this.RecovFWBox.Controls.Add(this.FWRecovVersion);
            this.RecovFWBox.Controls.Add(this.tagFWRecovVersion);
            this.RecovFWBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecovFWBox.Location = new System.Drawing.Point(207, 3);
            this.RecovFWBox.Name = "RecovFWBox";
            this.RecovFWBox.Size = new System.Drawing.Size(198, 220);
            this.RecovFWBox.TabIndex = 0;
            this.RecovFWBox.TabStop = false;
            this.RecovFWBox.Text = "Recovery";
            // 
            // FWRecovMetadataVersion
            // 
            this.FWRecovMetadataVersion.AutoSize = true;
            this.FWRecovMetadataVersion.Location = new System.Drawing.Point(20, 188);
            this.FWRecovMetadataVersion.Name = "FWRecovMetadataVersion";
            this.FWRecovMetadataVersion.Size = new System.Drawing.Size(0, 17);
            this.FWRecovMetadataVersion.TabIndex = 15;
            // 
            // tagFWRecovMetadataVersion
            // 
            this.tagFWRecovMetadataVersion.AutoSize = true;
            this.tagFWRecovMetadataVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWRecovMetadataVersion.Location = new System.Drawing.Point(6, 171);
            this.tagFWRecovMetadataVersion.Name = "tagFWRecovMetadataVersion";
            this.tagFWRecovMetadataVersion.Size = new System.Drawing.Size(133, 17);
            this.tagFWRecovMetadataVersion.TabIndex = 14;
            this.tagFWRecovMetadataVersion.Text = "Metadata version";
            // 
            // FWRecovHWPlatform
            // 
            this.FWRecovHWPlatform.AutoSize = true;
            this.FWRecovHWPlatform.Location = new System.Drawing.Point(20, 137);
            this.FWRecovHWPlatform.Name = "FWRecovHWPlatform";
            this.FWRecovHWPlatform.Size = new System.Drawing.Size(0, 17);
            this.FWRecovHWPlatform.TabIndex = 13;
            // 
            // tagFWRecovHWPlatform
            // 
            this.tagFWRecovHWPlatform.AutoSize = true;
            this.tagFWRecovHWPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWRecovHWPlatform.Location = new System.Drawing.Point(6, 120);
            this.tagFWRecovHWPlatform.Name = "tagFWRecovHWPlatform";
            this.tagFWRecovHWPlatform.Size = new System.Drawing.Size(141, 17);
            this.tagFWRecovHWPlatform.TabIndex = 12;
            this.tagFWRecovHWPlatform.Text = "Hardware platform";
            // 
            // FWRecovTimestamp
            // 
            this.FWRecovTimestamp.AutoSize = true;
            this.FWRecovTimestamp.Location = new System.Drawing.Point(20, 86);
            this.FWRecovTimestamp.Name = "FWRecovTimestamp";
            this.FWRecovTimestamp.Size = new System.Drawing.Size(0, 17);
            this.FWRecovTimestamp.TabIndex = 11;
            // 
            // tagFWRecovTimestamp
            // 
            this.tagFWRecovTimestamp.AutoSize = true;
            this.tagFWRecovTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWRecovTimestamp.Location = new System.Drawing.Point(6, 69);
            this.tagFWRecovTimestamp.Name = "tagFWRecovTimestamp";
            this.tagFWRecovTimestamp.Size = new System.Drawing.Size(86, 17);
            this.tagFWRecovTimestamp.TabIndex = 10;
            this.tagFWRecovTimestamp.Text = "Timestamp";
            // 
            // FWRecovVersion
            // 
            this.FWRecovVersion.AutoSize = true;
            this.FWRecovVersion.Location = new System.Drawing.Point(20, 35);
            this.FWRecovVersion.Name = "FWRecovVersion";
            this.FWRecovVersion.Size = new System.Drawing.Size(0, 17);
            this.FWRecovVersion.TabIndex = 9;
            // 
            // tagFWRecovVersion
            // 
            this.tagFWRecovVersion.AutoSize = true;
            this.tagFWRecovVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWRecovVersion.Location = new System.Drawing.Point(6, 18);
            this.tagFWRecovVersion.Name = "tagFWRecovVersion";
            this.tagFWRecovVersion.Size = new System.Drawing.Size(63, 17);
            this.tagFWRecovVersion.TabIndex = 8;
            this.tagFWRecovVersion.Text = "Version";
            // 
            // MainFWBox
            // 
            this.MainFWBox.Controls.Add(this.FWMainMetadataVersion);
            this.MainFWBox.Controls.Add(this.tagFWMainMetadataVersion);
            this.MainFWBox.Controls.Add(this.FWMainHWPlatform);
            this.MainFWBox.Controls.Add(this.tagFWMainHWPlatform);
            this.MainFWBox.Controls.Add(this.FWMainTimestamp);
            this.MainFWBox.Controls.Add(this.tagFWMainTimestamp);
            this.MainFWBox.Controls.Add(this.FWMainVersion);
            this.MainFWBox.Controls.Add(this.tagFWMainVersion);
            this.MainFWBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFWBox.Location = new System.Drawing.Point(3, 3);
            this.MainFWBox.Name = "MainFWBox";
            this.MainFWBox.Size = new System.Drawing.Size(198, 220);
            this.MainFWBox.TabIndex = 0;
            this.MainFWBox.TabStop = false;
            this.MainFWBox.Text = "Main";
            // 
            // FWMainMetadataVersion
            // 
            this.FWMainMetadataVersion.AutoSize = true;
            this.FWMainMetadataVersion.Location = new System.Drawing.Point(20, 188);
            this.FWMainMetadataVersion.Name = "FWMainMetadataVersion";
            this.FWMainMetadataVersion.Size = new System.Drawing.Size(0, 17);
            this.FWMainMetadataVersion.TabIndex = 7;
            // 
            // tagFWMainMetadataVersion
            // 
            this.tagFWMainMetadataVersion.AutoSize = true;
            this.tagFWMainMetadataVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWMainMetadataVersion.Location = new System.Drawing.Point(6, 171);
            this.tagFWMainMetadataVersion.Name = "tagFWMainMetadataVersion";
            this.tagFWMainMetadataVersion.Size = new System.Drawing.Size(133, 17);
            this.tagFWMainMetadataVersion.TabIndex = 6;
            this.tagFWMainMetadataVersion.Text = "Metadata version";
            // 
            // FWMainHWPlatform
            // 
            this.FWMainHWPlatform.AutoSize = true;
            this.FWMainHWPlatform.Location = new System.Drawing.Point(20, 137);
            this.FWMainHWPlatform.Name = "FWMainHWPlatform";
            this.FWMainHWPlatform.Size = new System.Drawing.Size(0, 17);
            this.FWMainHWPlatform.TabIndex = 5;
            // 
            // tagFWMainHWPlatform
            // 
            this.tagFWMainHWPlatform.AutoSize = true;
            this.tagFWMainHWPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWMainHWPlatform.Location = new System.Drawing.Point(6, 120);
            this.tagFWMainHWPlatform.Name = "tagFWMainHWPlatform";
            this.tagFWMainHWPlatform.Size = new System.Drawing.Size(141, 17);
            this.tagFWMainHWPlatform.TabIndex = 4;
            this.tagFWMainHWPlatform.Text = "Hardware platform";
            // 
            // FWMainTimestamp
            // 
            this.FWMainTimestamp.AutoSize = true;
            this.FWMainTimestamp.Location = new System.Drawing.Point(20, 86);
            this.FWMainTimestamp.Name = "FWMainTimestamp";
            this.FWMainTimestamp.Size = new System.Drawing.Size(0, 17);
            this.FWMainTimestamp.TabIndex = 3;
            // 
            // tagFWMainTimestamp
            // 
            this.tagFWMainTimestamp.AutoSize = true;
            this.tagFWMainTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWMainTimestamp.Location = new System.Drawing.Point(6, 69);
            this.tagFWMainTimestamp.Name = "tagFWMainTimestamp";
            this.tagFWMainTimestamp.Size = new System.Drawing.Size(86, 17);
            this.tagFWMainTimestamp.TabIndex = 2;
            this.tagFWMainTimestamp.Text = "Timestamp";
            // 
            // FWMainVersion
            // 
            this.FWMainVersion.AutoSize = true;
            this.FWMainVersion.Location = new System.Drawing.Point(20, 35);
            this.FWMainVersion.Name = "FWMainVersion";
            this.FWMainVersion.Size = new System.Drawing.Size(0, 17);
            this.FWMainVersion.TabIndex = 1;
            // 
            // tagFWMainVersion
            // 
            this.tagFWMainVersion.AutoSize = true;
            this.tagFWMainVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWMainVersion.Location = new System.Drawing.Point(6, 18);
            this.tagFWMainVersion.Name = "tagFWMainVersion";
            this.tagFWMainVersion.Size = new System.Drawing.Size(63, 17);
            this.tagFWMainVersion.TabIndex = 0;
            this.tagFWMainVersion.Text = "Version";
            // 
            // aboutPage
            // 
            this.aboutPage.Controls.Add(this.tableLayoutPanel1);
            this.aboutPage.Location = new System.Drawing.Point(4, 25);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutPage.Size = new System.Drawing.Size(414, 232);
            this.aboutPage.TabIndex = 2;
            this.aboutPage.Text = "About";
            this.aboutPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.FOSS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Deps, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FOSSLink, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DepsLinks, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Author, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AuthorLink, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 219);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FOSS
            // 
            this.FOSS.AutoSize = true;
            this.FOSS.Location = new System.Drawing.Point(3, 0);
            this.FOSS.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.FOSS.Name = "FOSS";
            this.FOSS.Size = new System.Drawing.Size(311, 68);
            this.FOSS.TabIndex = 2;
            this.FOSS.Text = "Flintlock is an open-source project. You\'re free to read, modify, compile and red" +
    "istribute the source code as you see fit - or you can just use it.";
            // 
            // Deps
            // 
            this.Deps.AutoSize = true;
            this.Deps.Location = new System.Drawing.Point(3, 73);
            this.Deps.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Deps.Name = "Deps";
            this.Deps.Size = new System.Drawing.Size(307, 85);
            this.Deps.TabIndex = 0;
            this.Deps.Text = resources.GetString("Deps.Text");
            // 
            // FOSSLink
            // 
            this.FOSSLink.AutoSize = true;
            this.FOSSLink.Location = new System.Drawing.Point(322, 0);
            this.FOSSLink.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.FOSSLink.Name = "FOSSLink";
            this.FOSSLink.Size = new System.Drawing.Size(83, 34);
            this.FOSSLink.TabIndex = 4;
            this.FOSSLink.TabStop = true;
            this.FOSSLink.Text = "Flintlock on \r\nGitHub";
            this.FOSSLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.links_LinkClicked);
            // 
            // DepsLinks
            // 
            this.DepsLinks.AutoSize = true;
            this.DepsLinks.Location = new System.Drawing.Point(322, 73);
            this.DepsLinks.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.DepsLinks.Name = "DepsLinks";
            this.DepsLinks.Size = new System.Drawing.Size(80, 51);
            this.DepsLinks.TabIndex = 1;
            this.DepsLinks.TabStop = true;
            this.DepsLinks.Text = "Flint\r\n32feet.NET\r\nlibpebble";
            this.DepsLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.links_LinkClicked);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(3, 163);
            this.Author.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(306, 51);
            this.Author.TabIndex = 5;
            this.Author.Text = "The author of Flintlock and Flint is Dominic van Berkel, a student and hobbyist w" +
    "ith a taste for tinkering.";
            // 
            // AuthorLink
            // 
            this.AuthorLink.AutoSize = true;
            this.AuthorLink.Location = new System.Drawing.Point(322, 163);
            this.AuthorLink.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.AuthorLink.Name = "AuthorLink";
            this.AuthorLink.Size = new System.Drawing.Size(73, 17);
            this.AuthorLink.TabIndex = 6;
            this.AuthorLink.TabStop = true;
            this.AuthorLink.Text = "Datasheet";
            this.AuthorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.links_LinkClicked);
            // 
            // notificationMenu
            // 
            this.notificationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pebbleNameToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notificationMenu.Name = "notificationMenu";
            this.notificationMenu.Size = new System.Drawing.Size(227, 100);
            // 
            // pebbleNameToolStripMenuItem
            // 
            this.pebbleNameToolStripMenuItem.Enabled = false;
            this.pebbleNameToolStripMenuItem.Name = "pebbleNameToolStripMenuItem";
            this.pebbleNameToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.pebbleNameToolStripMenuItem.Text = "Pebble 0000 on COM0";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notificationMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Disconnected";
            this.notifyIcon.Visible = global::flintlock.Properties.Settings.Default.ShowInTray;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // outerLayoutPanel
            // 
            this.outerLayoutPanel.AutoSize = true;
            this.outerLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outerLayoutPanel.ColumnCount = 2;
            this.outerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.outerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.70807F));
            this.outerLayoutPanel.Controls.Add(this.tabControl, 1, 0);
            this.outerLayoutPanel.Controls.Add(this.connectionLayoutPanel, 0, 0);
            this.outerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.outerLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.outerLayoutPanel.Name = "outerLayoutPanel";
            this.outerLayoutPanel.RowCount = 1;
            this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.outerLayoutPanel.Size = new System.Drawing.Size(644, 267);
            this.outerLayoutPanel.TabIndex = 1;
            // 
            // Flintlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 267);
            this.Controls.Add(this.outerLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Flintlock";
            this.Text = "Flintlock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Flintlock_FormClosed);
            this.Shown += new System.EventHandler(this.Flintlock_Shown);
            this.Resize += new System.EventHandler(this.Flintlock_Resize);
            this.connectionLayoutPanel.ResumeLayout(false);
            this.connectButtonsLayoutPanel.ResumeLayout(false);
            this.connectButtonsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatchfacePic)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.FirmwarePage.ResumeLayout(false);
            this.fwLayoutPanel.ResumeLayout(false);
            this.RecovFWBox.ResumeLayout(false);
            this.RecovFWBox.PerformLayout();
            this.MainFWBox.ResumeLayout(false);
            this.MainFWBox.PerformLayout();
            this.aboutPage.ResumeLayout(false);
            this.aboutPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.notificationMenu.ResumeLayout(false);
            this.outerLayoutPanel.ResumeLayout(false);
            this.outerLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel connectionLayoutPanel;
        private System.Windows.Forms.ComboBox PebbleList;
        private System.Windows.Forms.TableLayoutPanel connectButtonsLayoutPanel;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.PictureBox WatchfacePic;
        private System.Windows.Forms.CheckBox MediaControlchk;
        private System.Windows.Forms.CheckBox PPTControlchk;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button ReloadSettings;
        private System.Windows.Forms.CheckBox Autoconnect;
        private System.Windows.Forms.Button Defaults;
        private System.Windows.Forms.Label tagLastKnownPebble;
        private System.Windows.Forms.Label LastKnownPebbleID;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notificationMenu;
        private System.Windows.Forms.ToolStripMenuItem pebbleNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox MinToTray;
        private System.Windows.Forms.CheckBox ShowInTray;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.TabPage FirmwarePage;
        private System.Windows.Forms.GroupBox MainFWBox;
        private System.Windows.Forms.GroupBox RecovFWBox;
        private System.Windows.Forms.Label FWMainMetadataVersion;
        private System.Windows.Forms.Label tagFWMainMetadataVersion;
        private System.Windows.Forms.Label FWMainHWPlatform;
        private System.Windows.Forms.Label tagFWMainHWPlatform;
        private System.Windows.Forms.Label FWMainTimestamp;
        private System.Windows.Forms.Label tagFWMainTimestamp;
        private System.Windows.Forms.Label FWMainVersion;
        private System.Windows.Forms.Label tagFWMainVersion;
        private System.Windows.Forms.Label FWRecovMetadataVersion;
        private System.Windows.Forms.Label tagFWRecovMetadataVersion;
        private System.Windows.Forms.Label FWRecovHWPlatform;
        private System.Windows.Forms.Label tagFWRecovHWPlatform;
        private System.Windows.Forms.Label FWRecovTimestamp;
        private System.Windows.Forms.Label tagFWRecovTimestamp;
        private System.Windows.Forms.Label FWRecovVersion;
        private System.Windows.Forms.Label tagFWRecovVersion;
        private System.Windows.Forms.Label LastKnownPebblePort;
        private System.Windows.Forms.TableLayoutPanel outerLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel fwLayoutPanel;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.Label Deps;
        private System.Windows.Forms.LinkLabel DepsLinks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label FOSS;
        private System.Windows.Forms.LinkLabel FOSSLink;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.LinkLabel AuthorLink;


    }
}

