namespace Media_Player_V2
{
    partial class FRM_MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MAIN));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.hẹnGiờTắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backcolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languagesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_ListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveThisListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.button_Report = new System.Windows.Forms.Button();
            this.button_XoaHet = new System.Windows.Forms.Button();
            this.button_ADD = new System.Windows.Forms.Button();
            this.groupBox_Control = new System.Windows.Forms.GroupBox();
            this.userControl_TrinhDieuKhien1 = new Media_Player_V2.UserControl_TrinhDieuKhien();
            this.label1_TimeNow = new System.Windows.Forms.Label();
            this.trackBar_Vol = new System.Windows.Forms.TrackBar();
            this.metroTrackBar_TimeBar = new MetroFramework.Controls.MetroTrackBar();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip_ListView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Vol)).BeginInit();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.AccessibleDescription = "";
            this.openToolStripMenuItem.AccessibleName = "";
            this.openToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.toolStripMenuItem2,
            this.findToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.hẹnGiờTắtToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fontToolStripMenuItem.Image")));
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripMenuItem.Image")));
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vietnameseToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("languageToolStripMenuItem.Image")));
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // vietnameseToolStripMenuItem
            // 
            this.vietnameseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vietnameseToolStripMenuItem.Image")));
            this.vietnameseToolStripMenuItem.Name = "vietnameseToolStripMenuItem";
            this.vietnameseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.vietnameseToolStripMenuItem.Text = "Vietnamese";
            this.vietnameseToolStripMenuItem.Click += new System.EventHandler(this.vietnameseToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("englishToolStripMenuItem.Image")));
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 6);
            // 
            // findToolStripMenuItem1
            // 
            this.findToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripMenuItem1.Image")));
            this.findToolStripMenuItem1.Name = "findToolStripMenuItem1";
            this.findToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.findToolStripMenuItem1.Text = "&Find";
            this.findToolStripMenuItem1.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(130, 6);
            // 
            // hẹnGiờTắtToolStripMenuItem
            // 
            this.hẹnGiờTắtToolStripMenuItem.Image = global::Media_Player_V2.Properties.Resources.shutdown;
            this.hẹnGiờTắtToolStripMenuItem.Name = "hẹnGiờTắtToolStripMenuItem";
            this.hẹnGiờTắtToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.hẹnGiờTắtToolStripMenuItem.Text = "Hẹn giờ tắt";
            this.hẹnGiờTắtToolStripMenuItem.Click += new System.EventHandler(this.hẹnGiờTắtToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.menuStrip1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("fontToolStripMenuItem1.Image")));
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.fontToolStripMenuItem1.Text = "Font";
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // backcolorToolStripMenuItem
            // 
            this.backcolorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backcolorToolStripMenuItem.Image")));
            this.backcolorToolStripMenuItem.Name = "backcolorToolStripMenuItem";
            this.backcolorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.backcolorToolStripMenuItem.Text = "Back-color";
            this.backcolorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // languagesToolStripMenuItem1
            // 
            this.languagesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.englishToolStripMenuItem1});
            this.languagesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("languagesToolStripMenuItem1.Image")));
            this.languagesToolStripMenuItem1.Name = "languagesToolStripMenuItem1";
            this.languagesToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.languagesToolStripMenuItem1.Text = "Languages";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem1.Text = "VietNamese";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.vietnameseToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem1
            // 
            this.englishToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("englishToolStripMenuItem1.Image")));
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            this.englishToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.englishToolStripMenuItem1.Text = "English";
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripMenuItem.Image")));
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // contextMenuStrip_ListView
            // 
            this.contextMenuStrip_ListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem1,
            this.backcolorToolStripMenuItem,
            this.languagesToolStripMenuItem1,
            this.toolStripSeparator1,
            this.findToolStripMenuItem,
            this.toolStripMenuItem3,
            this.saveThisListToolStripMenuItem});
            this.contextMenuStrip_ListView.Name = "contextMenuStrip_ListView";
            this.contextMenuStrip_ListView.Size = new System.Drawing.Size(179, 126);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(175, 6);
            // 
            // saveThisListToolStripMenuItem
            // 
            this.saveThisListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveThisListToolStripMenuItem.Image")));
            this.saveThisListToolStripMenuItem.Name = "saveThisListToolStripMenuItem";
            this.saveThisListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveThisListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveThisListToolStripMenuItem.Text = "Save this list";
            this.saveThisListToolStripMenuItem.Click += new System.EventHandler(this.saveThisListToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ContextMenuStrip = this.contextMenuStrip_ListView;
            this.tableLayoutPanel1.Controls.Add(this.axVLCPlugin21, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Control, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.47826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.52174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 391);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.AllowDrop = true;
            this.axVLCPlugin21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(4, 4);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(482, 245);
            this.axVLCPlugin21.TabIndex = 28;
            this.axVLCPlugin21.MediaPlayerOpening += new System.EventHandler(this.axVLCPlugin21_MediaPlayerOpening);
            this.axVLCPlugin21.MediaPlayerPlaying += new System.EventHandler(this.axVLCPlugin21_MediaPlayerPlaying);
            this.axVLCPlugin21.MediaPlayerPaused += new System.EventHandler(this.axVLCPlugin21_MediaPlayerPaused);
            this.axVLCPlugin21.MediaPlayerEndReached += new System.EventHandler(this.axVLCPlugin21_MediaPlayerEndReached);
            this.axVLCPlugin21.MediaPlayerStopped += new System.EventHandler(this.axVLCPlugin21_MediaPlayerStopped);
            this.axVLCPlugin21.MediaPlayerTimeChanged += new AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEventHandler(this.axVLCPlugin21_MediaPlayerTimeChanged);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_State,
            this.columnHeader_Name,
            this.columnHeader_Size,
            this.columnHeader_Path});
            this.listView1.ContextMenuStrip = this.contextMenuStrip_ListView;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(493, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(483, 245);
            this.listView1.TabIndex = 31;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // columnHeader_State
            // 
            this.columnHeader_State.Text = "State";
            this.columnHeader_State.Width = 84;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 265;
            // 
            // columnHeader_Size
            // 
            this.columnHeader_Size.Text = "Size";
            this.columnHeader_Size.Width = 67;
            // 
            // columnHeader_Path
            // 
            this.columnHeader_Path.Text = "Path";
            this.columnHeader_Path.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Exit);
            this.groupBox1.Controls.Add(this.button_Info);
            this.groupBox1.Controls.Add(this.button_Report);
            this.groupBox1.Controls.Add(this.button_XoaHet);
            this.groupBox1.Controls.Add(this.button_ADD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(493, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 109);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(393, 36);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 28;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button_Info
            // 
            this.button_Info.Location = new System.Drawing.Point(292, 36);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(75, 23);
            this.button_Info.TabIndex = 28;
            this.button_Info.Text = "Info";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Report
            // 
            this.button_Report.Location = new System.Drawing.Point(202, 37);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(75, 23);
            this.button_Report.TabIndex = 28;
            this.button_Report.Text = "Report";
            this.button_Report.UseVisualStyleBackColor = true;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // button_XoaHet
            // 
            this.button_XoaHet.Location = new System.Drawing.Point(110, 36);
            this.button_XoaHet.Name = "button_XoaHet";
            this.button_XoaHet.Size = new System.Drawing.Size(75, 23);
            this.button_XoaHet.TabIndex = 28;
            this.button_XoaHet.Text = "Clear list";
            this.button_XoaHet.UseVisualStyleBackColor = true;
            this.button_XoaHet.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(15, 36);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(75, 23);
            this.button_ADD.TabIndex = 28;
            this.button_ADD.Text = "Add";
            this.button_ADD.UseVisualStyleBackColor = true;
            this.button_ADD.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // groupBox_Control
            // 
            this.groupBox_Control.Controls.Add(this.userControl_TrinhDieuKhien1);
            this.groupBox_Control.Controls.Add(this.label1_TimeNow);
            this.groupBox_Control.Controls.Add(this.trackBar_Vol);
            this.groupBox_Control.Controls.Add(this.metroTrackBar_TimeBar);
            this.groupBox_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Control.Location = new System.Drawing.Point(4, 256);
            this.groupBox_Control.Name = "groupBox_Control";
            this.groupBox_Control.Size = new System.Drawing.Size(482, 109);
            this.groupBox_Control.TabIndex = 29;
            this.groupBox_Control.TabStop = false;
            // 
            // userControl_TrinhDieuKhien1
            // 
            this.userControl_TrinhDieuKhien1.Location = new System.Drawing.Point(15, 56);
            this.userControl_TrinhDieuKhien1.Name = "userControl_TrinhDieuKhien1";
            this.userControl_TrinhDieuKhien1.Size = new System.Drawing.Size(413, 51);
            this.userControl_TrinhDieuKhien1.TabIndex = 50;
            this.userControl_TrinhDieuKhien1.Load += new System.EventHandler(this.userControl_TrinhDieuKhien1_Load_1);
            this.userControl_TrinhDieuKhien1.Click += new System.EventHandler(this.userControl_TrinhDieuKhien1_Click);
            // 
            // label1_TimeNow
            // 
            this.label1_TimeNow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1_TimeNow.AutoSize = true;
            this.label1_TimeNow.Location = new System.Drawing.Point(146, 40);
            this.label1_TimeNow.Name = "label1_TimeNow";
            this.label1_TimeNow.Size = new System.Drawing.Size(22, 13);
            this.label1_TimeNow.TabIndex = 49;
            this.label1_TimeNow.Text = "0:0";
            // 
            // trackBar_Vol
            // 
            this.trackBar_Vol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar_Vol.Location = new System.Drawing.Point(427, 14);
            this.trackBar_Vol.Name = "trackBar_Vol";
            this.trackBar_Vol.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Vol.Size = new System.Drawing.Size(45, 83);
            this.trackBar_Vol.TabIndex = 48;
            this.trackBar_Vol.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Vol.Scroll += new System.EventHandler(this.trackBar_Vol_Scroll);
            // 
            // metroTrackBar_TimeBar
            // 
            this.metroTrackBar_TimeBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTrackBar_TimeBar.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar_TimeBar.Location = new System.Drawing.Point(15, 14);
            this.metroTrackBar_TimeBar.Name = "metroTrackBar_TimeBar";
            this.metroTrackBar_TimeBar.Size = new System.Drawing.Size(388, 18);
            this.metroTrackBar_TimeBar.TabIndex = 47;
            this.metroTrackBar_TimeBar.Text = "metroTrackBar1";
            this.metroTrackBar_TimeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar_Vol_Scroll_1);
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1020, 469);
            this.Name = "FRM_MAIN";
            this.Text = "VTV Media Player 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip_ListView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Control.ResumeLayout(false);
            this.groupBox_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Vol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backcolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_State;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Size;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.GroupBox groupBox_Control;
        private System.Windows.Forms.Label label1_TimeNow;
        private System.Windows.Forms.TrackBar trackBar_Vol;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar_TimeBar;
        private System.Windows.Forms.ColumnHeader columnHeader_Path;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem saveThisListToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.Button button_Report;
        private System.Windows.Forms.Button button_XoaHet;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem hẹnGiờTắtToolStripMenuItem;
        private UserControl_TrinhDieuKhien userControl_TrinhDieuKhien1;
    }
}

