namespace eBookRelease
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tlsMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuFileAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuFileAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuToolSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuToolStat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuToolClearList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuToolExportList = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuToolSetExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuHelpDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMmuHelpSoft = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuHelpAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.tlsBtnAddFile = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnAddFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnBack = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnClearList = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnStat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsdropBtnViewType = new System.Windows.Forms.ToolStripDropDownButton();
            this.tlsMnuViewIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.splitlr = new System.Windows.Forms.SplitContainer();
            this.tctlLeft = new System.Windows.Forms.TabControl();
            this.tpgManagement = new System.Windows.Forms.TabPage();
            this.tvwMain = new System.Windows.Forms.TreeView();
            this.ilstIcon = new System.Windows.Forms.ImageList(this.components);
            this.tpgSearch = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpSearchPath = new System.Windows.Forms.GroupBox();
            this.cmbxSearchPath = new eBookRelease.ComboBoxEx();
            this.grpSearchOptionalItem = new System.Windows.Forms.GroupBox();
            this.chkSearchDate = new System.Windows.Forms.CheckBox();
            this.chkSearchPrice = new System.Windows.Forms.CheckBox();
            this.grpSearchPressDate = new System.Windows.Forms.GroupBox();
            this.dtpSearchDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDateTo = new System.Windows.Forms.Label();
            this.dtpSearchDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDateFrom = new System.Windows.Forms.Label();
            this.grpSearchPrice = new System.Windows.Forms.GroupBox();
            this.txtSearchPriceTo = new System.Windows.Forms.TextBox();
            this.lblSearchPriceTo = new System.Windows.Forms.Label();
            this.txtSearchPriceFrom = new System.Windows.Forms.TextBox();
            this.lblSearchPriceFrom = new System.Windows.Forms.Label();
            this.grpFileType = new System.Windows.Forms.GroupBox();
            this.txtSearchFileType = new System.Windows.Forms.TextBox();
            this.chkSearchFileType = new System.Windows.Forms.CheckBox();
            this.grpSearchMustItem = new System.Windows.Forms.GroupBox();
            this.grpSearchContent = new System.Windows.Forms.GroupBox();
            this.chklSearchContent = new System.Windows.Forms.CheckedListBox();
            this.grpKeyWord = new System.Windows.Forms.GroupBox();
            this.txtSearchKeyWord = new System.Windows.Forms.TextBox();
            this.picSearchPrg = new System.Windows.Forms.PictureBox();
            this.tpgStat = new System.Windows.Forms.TabPage();
            this.grpStatPrice = new System.Windows.Forms.GroupBox();
            this.txtStatPriceTo = new System.Windows.Forms.TextBox();
            this.lblStatPriceTo = new System.Windows.Forms.Label();
            this.txtStatPriceFrom = new System.Windows.Forms.TextBox();
            this.lblStatPriceFrom = new System.Windows.Forms.Label();
            this.grpStatPressDate = new System.Windows.Forms.GroupBox();
            this.dtpStatDateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStatDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStat = new System.Windows.Forms.Button();
            this.grpStatType = new System.Windows.Forms.GroupBox();
            this.radFileType = new System.Windows.Forms.RadioButton();
            this.radPrice = new System.Windows.Forms.RadioButton();
            this.radPressDate = new System.Windows.Forms.RadioButton();
            this.grpStatFileType = new System.Windows.Forms.GroupBox();
            this.txtStatFileType = new System.Windows.Forms.TextBox();
            this.picStatPrg = new System.Windows.Forms.PictureBox();
            this.splittb = new System.Windows.Forms.SplitContainer();
            this.lvwMain = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.size = new System.Windows.Forms.ColumnHeader();
            this.type = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.cntMenuLvwMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlsMnuLvwOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuLvwBack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuLvwRenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuLvwDelItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuLvwClearItems = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuLvwMdfInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlListView = new System.Windows.Forms.Panel();
            this.lnkModifyBookInfo = new System.Windows.Forms.LinkLabel();
            this.lnkClearItems = new System.Windows.Forms.LinkLabel();
            this.lblSearchCount = new System.Windows.Forms.Label();
            this.cntMnuBookPnl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlsMnuBookHidePnl = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.pnlBookInfo = new System.Windows.Forms.Panel();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.picSaveOK = new System.Windows.Forms.PictureBox();
            this.lblSaveSuccess = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpPressDate = new System.Windows.Forms.DateTimePicker();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.msktPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPress = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblPressDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cntMenuRootNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlsMnuRootCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuRootAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuRootNewNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuRootRenNode = new System.Windows.Forms.ToolStripMenuItem();
            this.cntMenuParentNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlsMnuParentCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuParentAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuParentAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuParentNewNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuParentDelNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMenuParentRenNode = new System.Windows.Forms.ToolStripMenuItem();
            this.cntMenuLeafNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlsMnuLeafOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuLeafOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuLeafDelNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuLeafRenNode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsMnuLeafMfyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdlgAddFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.odlgAddFile = new System.Windows.Forms.OpenFileDialog();
            this.errPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.tltInfo = new System.Windows.Forms.ToolTip(this.components);
            this.sdlgSaveList = new System.Windows.Forms.SaveFileDialog();
            this.ntfyMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cntMenuNtfyMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlsMnuNtfyShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuNtfyAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMnuNtfyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.splitlr.Panel1.SuspendLayout();
            this.splitlr.Panel2.SuspendLayout();
            this.splitlr.SuspendLayout();
            this.tctlLeft.SuspendLayout();
            this.tpgManagement.SuspendLayout();
            this.tpgSearch.SuspendLayout();
            this.grpSearchPath.SuspendLayout();
            this.grpSearchOptionalItem.SuspendLayout();
            this.grpSearchPressDate.SuspendLayout();
            this.grpSearchPrice.SuspendLayout();
            this.grpFileType.SuspendLayout();
            this.grpSearchMustItem.SuspendLayout();
            this.grpSearchContent.SuspendLayout();
            this.grpKeyWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchPrg)).BeginInit();
            this.tpgStat.SuspendLayout();
            this.grpStatPrice.SuspendLayout();
            this.grpStatPressDate.SuspendLayout();
            this.grpStatType.SuspendLayout();
            this.grpStatFileType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatPrg)).BeginInit();
            this.splittb.Panel1.SuspendLayout();
            this.splittb.Panel2.SuspendLayout();
            this.splittb.SuspendLayout();
            this.cntMenuLvwMain.SuspendLayout();
            this.pnlListView.SuspendLayout();
            this.cntMnuBookPnl.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            this.pnlBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveOK)).BeginInit();
            this.cntMenuRootNode.SuspendLayout();
            this.cntMenuParentNode.SuspendLayout();
            this.cntMenuLeafNode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).BeginInit();
            this.cntMenuNtfyMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMenuFile,
            this.tlsMenuTool,
            this.tlsMenuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(864, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // tlsMenuFile
            // 
            this.tlsMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMnuFileAddFile,
            this.tlsMnuFileAddFolder,
            this.toolStripSeparator9,
            this.tlsMnuFileExit});
            this.tlsMenuFile.Name = "tlsMenuFile";
            this.tlsMenuFile.Size = new System.Drawing.Size(41, 20);
            this.tlsMenuFile.Text = "文件";
            // 
            // tlsMnuFileAddFile
            // 
            this.tlsMnuFileAddFile.Image = global::eBookRelease.Properties.Resources.addfile;
            this.tlsMnuFileAddFile.Name = "tlsMnuFileAddFile";
            this.tlsMnuFileAddFile.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuFileAddFile.Text = "添加文件";
            this.tlsMnuFileAddFile.Click += new System.EventHandler(this.tlsMnuFileAddFile_Click);
            // 
            // tlsMnuFileAddFolder
            // 
            this.tlsMnuFileAddFolder.Image = global::eBookRelease.Properties.Resources.addfolder;
            this.tlsMnuFileAddFolder.Name = "tlsMnuFileAddFolder";
            this.tlsMnuFileAddFolder.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuFileAddFolder.Text = "添加文件夹";
            this.tlsMnuFileAddFolder.Click += new System.EventHandler(this.tlsMnuFileAddFolder_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(127, 6);
            // 
            // tlsMnuFileExit
            // 
            this.tlsMnuFileExit.Image = global::eBookRelease.Properties.Resources.exit;
            this.tlsMnuFileExit.Name = "tlsMnuFileExit";
            this.tlsMnuFileExit.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuFileExit.Text = "退出";
            this.tlsMnuFileExit.Click += new System.EventHandler(this.tlsMnuFileExit_Click);
            // 
            // tlsMenuTool
            // 
            this.tlsMenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMnuToolSearch,
            this.tlsMnuToolStat,
            this.toolStripSeparator10,
            this.tlsMnuToolClearList,
            this.toolStripSeparator11,
            this.tlsMnuToolExportList,
            this.tlsMnuToolSetExport});
            this.tlsMenuTool.Name = "tlsMenuTool";
            this.tlsMenuTool.Size = new System.Drawing.Size(41, 20);
            this.tlsMenuTool.Text = "工具";
            // 
            // tlsMnuToolSearch
            // 
            this.tlsMnuToolSearch.Image = global::eBookRelease.Properties.Resources.search;
            this.tlsMnuToolSearch.Name = "tlsMnuToolSearch";
            this.tlsMnuToolSearch.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuToolSearch.Text = "查找";
            this.tlsMnuToolSearch.Click += new System.EventHandler(this.tlsMnuToolSearch_Click);
            // 
            // tlsMnuToolStat
            // 
            this.tlsMnuToolStat.Image = global::eBookRelease.Properties.Resources.stat;
            this.tlsMnuToolStat.Name = "tlsMnuToolStat";
            this.tlsMnuToolStat.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuToolStat.Text = "统计";
            this.tlsMnuToolStat.Click += new System.EventHandler(this.tlsMnuToolStat_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(145, 6);
            // 
            // tlsMnuToolClearList
            // 
            this.tlsMnuToolClearList.Image = global::eBookRelease.Properties.Resources.clear;
            this.tlsMnuToolClearList.Name = "tlsMnuToolClearList";
            this.tlsMnuToolClearList.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuToolClearList.Text = "清空列表";
            this.tlsMnuToolClearList.Click += new System.EventHandler(this.tlsMnuToolClearList_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(145, 6);
            // 
            // tlsMnuToolExportList
            // 
            this.tlsMnuToolExportList.Name = "tlsMnuToolExportList";
            this.tlsMnuToolExportList.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuToolExportList.Text = "输出eBook列表";
            this.tlsMnuToolExportList.ToolTipText = "默认只输出书名\r\n您可以设置要输出的内容";
            this.tlsMnuToolExportList.Click += new System.EventHandler(this.tlsMnuToolExportList_Click);
            // 
            // tlsMnuToolSetExport
            // 
            this.tlsMnuToolSetExport.Image = global::eBookRelease.Properties.Resources.set;
            this.tlsMnuToolSetExport.Name = "tlsMnuToolSetExport";
            this.tlsMnuToolSetExport.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuToolSetExport.Text = "设置输出信息";
            this.tlsMnuToolSetExport.Click += new System.EventHandler(this.tlsMnuToolSetExport_Click);
            // 
            // tlsMenuHelp
            // 
            this.tlsMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMnuHelpDocument,
            this.tlsMmuHelpSoft,
            this.tlsMnuHelpAuthor});
            this.tlsMenuHelp.Name = "tlsMenuHelp";
            this.tlsMenuHelp.Size = new System.Drawing.Size(41, 20);
            this.tlsMenuHelp.Text = "帮助";
            // 
            // tlsMnuHelpDocument
            // 
            this.tlsMnuHelpDocument.Image = global::eBookRelease.Properties.Resources.help;
            this.tlsMnuHelpDocument.Name = "tlsMnuHelpDocument";
            this.tlsMnuHelpDocument.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuHelpDocument.Text = "使用说明";
            this.tlsMnuHelpDocument.Click += new System.EventHandler(this.tlsMnuHelpDocument_Click);
            // 
            // tlsMmuHelpSoft
            // 
            this.tlsMmuHelpSoft.Name = "tlsMmuHelpSoft";
            this.tlsMmuHelpSoft.Size = new System.Drawing.Size(130, 22);
            this.tlsMmuHelpSoft.Text = "此软件介绍";
            this.tlsMmuHelpSoft.Click += new System.EventHandler(this.tlsMmuHelpSoft_Click);
            // 
            // tlsMnuHelpAuthor
            // 
            this.tlsMnuHelpAuthor.Image = global::eBookRelease.Properties.Resources.me;
            this.tlsMnuHelpAuthor.Name = "tlsMnuHelpAuthor";
            this.tlsMnuHelpAuthor.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuHelpAuthor.Text = "关于作者";
            this.tlsMnuHelpAuthor.Click += new System.EventHandler(this.tlsMnuHelpAuthor_Click);
            // 
            // toolMain
            // 
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnAddFile,
            this.tlsBtnAddFolder,
            this.toolStripSeparator12,
            this.tlsBtnBack,
            this.tlsBtnClearList,
            this.tlsBtnSearch,
            this.tlsBtnStat,
            this.toolStripSeparator13,
            this.tlsdropBtnViewType});
            this.toolMain.Location = new System.Drawing.Point(0, 24);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(864, 25);
            this.toolMain.TabIndex = 1;
            this.toolMain.Text = "toolStrip1";
            // 
            // tlsBtnAddFile
            // 
            this.tlsBtnAddFile.Image = global::eBookRelease.Properties.Resources.addfile;
            this.tlsBtnAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnAddFile.Name = "tlsBtnAddFile";
            this.tlsBtnAddFile.Size = new System.Drawing.Size(73, 22);
            this.tlsBtnAddFile.Text = "添加文件";
            this.tlsBtnAddFile.Click += new System.EventHandler(this.tlsBtnAddFile_Click);
            // 
            // tlsBtnAddFolder
            // 
            this.tlsBtnAddFolder.Image = global::eBookRelease.Properties.Resources.addfolder;
            this.tlsBtnAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnAddFolder.Name = "tlsBtnAddFolder";
            this.tlsBtnAddFolder.Size = new System.Drawing.Size(85, 22);
            this.tlsBtnAddFolder.Text = "添加文件夹";
            this.tlsBtnAddFolder.Click += new System.EventHandler(this.tlsBtnAddFolder_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsBtnBack
            // 
            this.tlsBtnBack.Image = global::eBookRelease.Properties.Resources.P38;
            this.tlsBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnBack.Name = "tlsBtnBack";
            this.tlsBtnBack.Size = new System.Drawing.Size(49, 22);
            this.tlsBtnBack.Text = "向上";
            this.tlsBtnBack.Click += new System.EventHandler(this.tlsBtnBack_Click);
            // 
            // tlsBtnClearList
            // 
            this.tlsBtnClearList.Image = global::eBookRelease.Properties.Resources.clear;
            this.tlsBtnClearList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnClearList.Name = "tlsBtnClearList";
            this.tlsBtnClearList.Size = new System.Drawing.Size(73, 22);
            this.tlsBtnClearList.Text = "清空列表";
            this.tlsBtnClearList.Click += new System.EventHandler(this.tlsBtnClearList_Click);
            // 
            // tlsBtnSearch
            // 
            this.tlsBtnSearch.Image = global::eBookRelease.Properties.Resources.search;
            this.tlsBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnSearch.Name = "tlsBtnSearch";
            this.tlsBtnSearch.Size = new System.Drawing.Size(49, 22);
            this.tlsBtnSearch.Text = "查找";
            this.tlsBtnSearch.Click += new System.EventHandler(this.tlsBtnSearch_Click);
            // 
            // tlsBtnStat
            // 
            this.tlsBtnStat.Image = global::eBookRelease.Properties.Resources.stat;
            this.tlsBtnStat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnStat.Name = "tlsBtnStat";
            this.tlsBtnStat.Size = new System.Drawing.Size(49, 22);
            this.tlsBtnStat.Text = "统计";
            this.tlsBtnStat.Click += new System.EventHandler(this.tlsBtnStat_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsdropBtnViewType
            // 
            this.tlsdropBtnViewType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMnuViewIcon,
            this.tlsMnuViewList,
            this.tlsMnuViewDetails});
            this.tlsdropBtnViewType.Image = global::eBookRelease.Properties.Resources.viewtype;
            this.tlsdropBtnViewType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsdropBtnViewType.Name = "tlsdropBtnViewType";
            this.tlsdropBtnViewType.Size = new System.Drawing.Size(82, 22);
            this.tlsdropBtnViewType.Text = "列表类型";
            // 
            // tlsMnuViewIcon
            // 
            this.tlsMnuViewIcon.Image = global::eBookRelease.Properties.Resources.icon;
            this.tlsMnuViewIcon.Name = "tlsMnuViewIcon";
            this.tlsMnuViewIcon.Size = new System.Drawing.Size(118, 22);
            this.tlsMnuViewIcon.Text = "缩略图";
            this.tlsMnuViewIcon.Click += new System.EventHandler(this.tlsMnuViewIcon_Click);
            // 
            // tlsMnuViewList
            // 
            this.tlsMnuViewList.Image = global::eBookRelease.Properties.Resources.list;
            this.tlsMnuViewList.Name = "tlsMnuViewList";
            this.tlsMnuViewList.Size = new System.Drawing.Size(118, 22);
            this.tlsMnuViewList.Text = "列表";
            this.tlsMnuViewList.Click += new System.EventHandler(this.tlsMnuViewList_Click);
            // 
            // tlsMnuViewDetails
            // 
            this.tlsMnuViewDetails.Image = global::eBookRelease.Properties.Resources.details;
            this.tlsMnuViewDetails.Name = "tlsMnuViewDetails";
            this.tlsMnuViewDetails.Size = new System.Drawing.Size(118, 22);
            this.tlsMnuViewDetails.Text = "详细列表";
            this.tlsMnuViewDetails.Click += new System.EventHandler(this.tlsMnuViewDetails_Click);
            // 
            // splitlr
            // 
            this.splitlr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitlr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitlr.Location = new System.Drawing.Point(0, 49);
            this.splitlr.Name = "splitlr";
            // 
            // splitlr.Panel1
            // 
            this.splitlr.Panel1.Controls.Add(this.tctlLeft);
            // 
            // splitlr.Panel2
            // 
            this.splitlr.Panel2.Controls.Add(this.splittb);
            this.splitlr.Size = new System.Drawing.Size(864, 675);
            this.splitlr.SplitterDistance = 242;
            this.splitlr.TabIndex = 3;
            // 
            // tctlLeft
            // 
            this.tctlLeft.Controls.Add(this.tpgManagement);
            this.tctlLeft.Controls.Add(this.tpgSearch);
            this.tctlLeft.Controls.Add(this.tpgStat);
            this.tctlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctlLeft.Location = new System.Drawing.Point(0, 0);
            this.tctlLeft.Name = "tctlLeft";
            this.tctlLeft.SelectedIndex = 0;
            this.tctlLeft.Size = new System.Drawing.Size(240, 673);
            this.tctlLeft.TabIndex = 0;
            this.tctlLeft.Selected += new System.Windows.Forms.TabControlEventHandler(this.tctlLeft_Selected);
            // 
            // tpgManagement
            // 
            this.tpgManagement.Controls.Add(this.tvwMain);
            this.tpgManagement.Location = new System.Drawing.Point(4, 21);
            this.tpgManagement.Name = "tpgManagement";
            this.tpgManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tpgManagement.Size = new System.Drawing.Size(232, 648);
            this.tpgManagement.TabIndex = 0;
            this.tpgManagement.Text = "管理";
            this.tpgManagement.UseVisualStyleBackColor = true;
            // 
            // tvwMain
            // 
            this.tvwMain.AllowDrop = true;
            this.tvwMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwMain.ImageIndex = 12;
            this.tvwMain.ImageList = this.ilstIcon;
            this.tvwMain.Location = new System.Drawing.Point(3, 3);
            this.tvwMain.Name = "tvwMain";
            this.tvwMain.SelectedImageIndex = 26;
            this.tvwMain.Size = new System.Drawing.Size(226, 642);
            this.tvwMain.TabIndex = 0;
            this.tvwMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvwMain_DragDrop);
            this.tvwMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvwMain_DragEnter);
            this.tvwMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwMain_NodeMouseClick);
            this.tvwMain.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvwMain_ItemDrag);
            this.tvwMain.DragOver += new System.Windows.Forms.DragEventHandler(this.tvwMain_DragOver);
            // 
            // ilstIcon
            // 
            this.ilstIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstIcon.ImageStream")));
            this.ilstIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstIcon.Images.SetKeyName(0, "avi.png");
            this.ilstIcon.Images.SetKeyName(1, "bmp.png");
            this.ilstIcon.Images.SetKeyName(2, "c.png");
            this.ilstIcon.Images.SetKeyName(3, "cpp.png");
            this.ilstIcon.Images.SetKeyName(4, "doc.png");
            this.ilstIcon.Images.SetKeyName(5, "folder.png");
            this.ilstIcon.Images.SetKeyName(6, "h.png");
            this.ilstIcon.Images.SetKeyName(7, "html.png");
            this.ilstIcon.Images.SetKeyName(8, "ini.png");
            this.ilstIcon.Images.SetKeyName(9, "iso.png");
            this.ilstIcon.Images.SetKeyName(10, "java.png");
            this.ilstIcon.Images.SetKeyName(11, "jepg.png");
            this.ilstIcon.Images.SetKeyName(12, "library.png");
            this.ilstIcon.Images.SetKeyName(13, "mp3.png");
            this.ilstIcon.Images.SetKeyName(14, "mpeg.png");
            this.ilstIcon.Images.SetKeyName(15, "new.png");
            this.ilstIcon.Images.SetKeyName(16, "pdf.png");
            this.ilstIcon.Images.SetKeyName(17, "png.png");
            this.ilstIcon.Images.SetKeyName(18, "ppt.png");
            this.ilstIcon.Images.SetKeyName(19, "rar.png");
            this.ilstIcon.Images.SetKeyName(20, "rmvb.png");
            this.ilstIcon.Images.SetKeyName(21, "swf.png");
            this.ilstIcon.Images.SetKeyName(22, "wav.png");
            this.ilstIcon.Images.SetKeyName(23, "wmv.png");
            this.ilstIcon.Images.SetKeyName(24, "xls.png");
            this.ilstIcon.Images.SetKeyName(25, "zip.png");
            this.ilstIcon.Images.SetKeyName(26, "select.png");
            // 
            // tpgSearch
            // 
            this.tpgSearch.AutoScroll = true;
            this.tpgSearch.Controls.Add(this.btnSearch);
            this.tpgSearch.Controls.Add(this.grpSearchPath);
            this.tpgSearch.Controls.Add(this.grpSearchOptionalItem);
            this.tpgSearch.Controls.Add(this.grpSearchMustItem);
            this.tpgSearch.Controls.Add(this.picSearchPrg);
            this.tpgSearch.Location = new System.Drawing.Point(4, 21);
            this.tpgSearch.Name = "tpgSearch";
            this.tpgSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSearch.Size = new System.Drawing.Size(232, 648);
            this.tpgSearch.TabIndex = 1;
            this.tpgSearch.Text = "查找";
            this.tpgSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(63, 580);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpSearchPath
            // 
            this.grpSearchPath.Controls.Add(this.cmbxSearchPath);
            this.grpSearchPath.Location = new System.Drawing.Point(7, 498);
            this.grpSearchPath.Name = "grpSearchPath";
            this.grpSearchPath.Size = new System.Drawing.Size(200, 46);
            this.grpSearchPath.TabIndex = 2;
            this.grpSearchPath.TabStop = false;
            this.grpSearchPath.Text = "查找路径";
            // 
            // cmbxSearchPath
            // 
            this.cmbxSearchPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbxSearchPath.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbxSearchPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchPath.FormattingEnabled = true;
            this.cmbxSearchPath.ImageList = this.ilstIcon;
            this.cmbxSearchPath.Location = new System.Drawing.Point(3, 17);
            this.cmbxSearchPath.Name = "cmbxSearchPath";
            this.cmbxSearchPath.Size = new System.Drawing.Size(194, 22);
            this.cmbxSearchPath.TabIndex = 0;
            // 
            // grpSearchOptionalItem
            // 
            this.grpSearchOptionalItem.Controls.Add(this.chkSearchDate);
            this.grpSearchOptionalItem.Controls.Add(this.chkSearchPrice);
            this.grpSearchOptionalItem.Controls.Add(this.grpSearchPressDate);
            this.grpSearchOptionalItem.Controls.Add(this.grpSearchPrice);
            this.grpSearchOptionalItem.Controls.Add(this.grpFileType);
            this.grpSearchOptionalItem.Controls.Add(this.chkSearchFileType);
            this.grpSearchOptionalItem.Location = new System.Drawing.Point(7, 200);
            this.grpSearchOptionalItem.Name = "grpSearchOptionalItem";
            this.grpSearchOptionalItem.Size = new System.Drawing.Size(200, 280);
            this.grpSearchOptionalItem.TabIndex = 1;
            this.grpSearchOptionalItem.TabStop = false;
            this.grpSearchOptionalItem.Text = "选添查找选项";
            // 
            // chkSearchDate
            // 
            this.chkSearchDate.AutoSize = true;
            this.chkSearchDate.Location = new System.Drawing.Point(9, 159);
            this.chkSearchDate.Name = "chkSearchDate";
            this.chkSearchDate.Size = new System.Drawing.Size(96, 16);
            this.chkSearchDate.TabIndex = 5;
            this.chkSearchDate.Text = "查找出版日期";
            this.chkSearchDate.UseVisualStyleBackColor = true;
            this.chkSearchDate.CheckedChanged += new System.EventHandler(this.chkSearchDate_CheckedChanged);
            // 
            // chkSearchPrice
            // 
            this.chkSearchPrice.AutoSize = true;
            this.chkSearchPrice.Location = new System.Drawing.Point(9, 90);
            this.chkSearchPrice.Name = "chkSearchPrice";
            this.chkSearchPrice.Size = new System.Drawing.Size(72, 16);
            this.chkSearchPrice.TabIndex = 4;
            this.chkSearchPrice.Text = "查找价钱";
            this.chkSearchPrice.UseVisualStyleBackColor = true;
            this.chkSearchPrice.CheckedChanged += new System.EventHandler(this.chkSearchPrice_CheckedChanged);
            // 
            // grpSearchPressDate
            // 
            this.grpSearchPressDate.Controls.Add(this.dtpSearchDateTo);
            this.grpSearchPressDate.Controls.Add(this.lblSearchDateTo);
            this.grpSearchPressDate.Controls.Add(this.dtpSearchDateFrom);
            this.grpSearchPressDate.Controls.Add(this.lblSearchDateFrom);
            this.grpSearchPressDate.Enabled = false;
            this.grpSearchPressDate.Location = new System.Drawing.Point(5, 175);
            this.grpSearchPressDate.Name = "grpSearchPressDate";
            this.grpSearchPressDate.Size = new System.Drawing.Size(190, 101);
            this.grpSearchPressDate.TabIndex = 2;
            this.grpSearchPressDate.TabStop = false;
            this.grpSearchPressDate.Text = "出版日期";
            // 
            // dtpSearchDateTo
            // 
            this.dtpSearchDateTo.Location = new System.Drawing.Point(4, 71);
            this.dtpSearchDateTo.Name = "dtpSearchDateTo";
            this.dtpSearchDateTo.Size = new System.Drawing.Size(184, 21);
            this.dtpSearchDateTo.TabIndex = 3;
            // 
            // lblSearchDateTo
            // 
            this.lblSearchDateTo.AutoSize = true;
            this.lblSearchDateTo.Location = new System.Drawing.Point(9, 56);
            this.lblSearchDateTo.Name = "lblSearchDateTo";
            this.lblSearchDateTo.Size = new System.Drawing.Size(17, 12);
            this.lblSearchDateTo.TabIndex = 2;
            this.lblSearchDateTo.Text = "到";
            // 
            // dtpSearchDateFrom
            // 
            this.dtpSearchDateFrom.Location = new System.Drawing.Point(3, 32);
            this.dtpSearchDateFrom.Name = "dtpSearchDateFrom";
            this.dtpSearchDateFrom.Size = new System.Drawing.Size(184, 21);
            this.dtpSearchDateFrom.TabIndex = 1;
            // 
            // lblSearchDateFrom
            // 
            this.lblSearchDateFrom.AutoSize = true;
            this.lblSearchDateFrom.Location = new System.Drawing.Point(9, 17);
            this.lblSearchDateFrom.Name = "lblSearchDateFrom";
            this.lblSearchDateFrom.Size = new System.Drawing.Size(17, 12);
            this.lblSearchDateFrom.TabIndex = 0;
            this.lblSearchDateFrom.Text = "从";
            // 
            // grpSearchPrice
            // 
            this.grpSearchPrice.Controls.Add(this.txtSearchPriceTo);
            this.grpSearchPrice.Controls.Add(this.lblSearchPriceTo);
            this.grpSearchPrice.Controls.Add(this.txtSearchPriceFrom);
            this.grpSearchPrice.Controls.Add(this.lblSearchPriceFrom);
            this.grpSearchPrice.Enabled = false;
            this.grpSearchPrice.Location = new System.Drawing.Point(4, 107);
            this.grpSearchPrice.Name = "grpSearchPrice";
            this.grpSearchPrice.Size = new System.Drawing.Size(189, 46);
            this.grpSearchPrice.TabIndex = 1;
            this.grpSearchPrice.TabStop = false;
            this.grpSearchPrice.Text = "价钱";
            // 
            // txtSearchPriceTo
            // 
            this.txtSearchPriceTo.Location = new System.Drawing.Point(121, 15);
            this.txtSearchPriceTo.MaxLength = 10;
            this.txtSearchPriceTo.Name = "txtSearchPriceTo";
            this.txtSearchPriceTo.Size = new System.Drawing.Size(62, 21);
            this.txtSearchPriceTo.TabIndex = 3;
            // 
            // lblSearchPriceTo
            // 
            this.lblSearchPriceTo.AutoSize = true;
            this.lblSearchPriceTo.Location = new System.Drawing.Point(98, 20);
            this.lblSearchPriceTo.Name = "lblSearchPriceTo";
            this.lblSearchPriceTo.Size = new System.Drawing.Size(17, 12);
            this.lblSearchPriceTo.TabIndex = 2;
            this.lblSearchPriceTo.Text = "到";
            // 
            // txtSearchPriceFrom
            // 
            this.txtSearchPriceFrom.Location = new System.Drawing.Point(32, 15);
            this.txtSearchPriceFrom.MaxLength = 10;
            this.txtSearchPriceFrom.Name = "txtSearchPriceFrom";
            this.txtSearchPriceFrom.Size = new System.Drawing.Size(60, 21);
            this.txtSearchPriceFrom.TabIndex = 1;
            // 
            // lblSearchPriceFrom
            // 
            this.lblSearchPriceFrom.AutoSize = true;
            this.lblSearchPriceFrom.Location = new System.Drawing.Point(9, 20);
            this.lblSearchPriceFrom.Name = "lblSearchPriceFrom";
            this.lblSearchPriceFrom.Size = new System.Drawing.Size(17, 12);
            this.lblSearchPriceFrom.TabIndex = 0;
            this.lblSearchPriceFrom.Text = "从";
            // 
            // grpFileType
            // 
            this.grpFileType.Controls.Add(this.txtSearchFileType);
            this.grpFileType.Enabled = false;
            this.grpFileType.Location = new System.Drawing.Point(6, 38);
            this.grpFileType.Name = "grpFileType";
            this.grpFileType.Size = new System.Drawing.Size(189, 46);
            this.grpFileType.TabIndex = 0;
            this.grpFileType.TabStop = false;
            this.grpFileType.Text = "文件类型";
            this.tltInfo.SetToolTip(this.grpFileType, "请按照以下格式输入：\r\n*.pdf *.chm ...");
            // 
            // txtSearchFileType
            // 
            this.txtSearchFileType.AutoCompleteCustomSource.AddRange(new string[] {
            "*.pdf",
            "*.chm",
            "*.pdg",
            "*.doc",
            "*.rar",
            "*.zip",
            "*.exe",
            "*.cs",
            "*.java"});
            this.txtSearchFileType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchFileType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchFileType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchFileType.Location = new System.Drawing.Point(3, 17);
            this.txtSearchFileType.MaxLength = 100;
            this.txtSearchFileType.Name = "txtSearchFileType";
            this.txtSearchFileType.Size = new System.Drawing.Size(183, 21);
            this.txtSearchFileType.TabIndex = 0;
            this.tltInfo.SetToolTip(this.txtSearchFileType, "请按照以下格式输入：\r\n*.pdf *.chm ...");
            // 
            // chkSearchFileType
            // 
            this.chkSearchFileType.AutoSize = true;
            this.chkSearchFileType.Location = new System.Drawing.Point(8, 21);
            this.chkSearchFileType.Name = "chkSearchFileType";
            this.chkSearchFileType.Size = new System.Drawing.Size(96, 16);
            this.chkSearchFileType.TabIndex = 3;
            this.chkSearchFileType.Text = "查找文件类型";
            this.tltInfo.SetToolTip(this.chkSearchFileType, "请按照以下格式输入：\r\n*.pdf *.chm ...");
            this.chkSearchFileType.UseVisualStyleBackColor = true;
            this.chkSearchFileType.CheckedChanged += new System.EventHandler(this.chkSearchFileType_CheckedChanged);
            // 
            // grpSearchMustItem
            // 
            this.grpSearchMustItem.Controls.Add(this.grpSearchContent);
            this.grpSearchMustItem.Controls.Add(this.grpKeyWord);
            this.grpSearchMustItem.Location = new System.Drawing.Point(7, 6);
            this.grpSearchMustItem.Name = "grpSearchMustItem";
            this.grpSearchMustItem.Size = new System.Drawing.Size(200, 188);
            this.grpSearchMustItem.TabIndex = 0;
            this.grpSearchMustItem.TabStop = false;
            this.grpSearchMustItem.Text = "必填查找选项";
            // 
            // grpSearchContent
            // 
            this.grpSearchContent.Controls.Add(this.chklSearchContent);
            this.grpSearchContent.Location = new System.Drawing.Point(6, 72);
            this.grpSearchContent.Name = "grpSearchContent";
            this.grpSearchContent.Size = new System.Drawing.Size(183, 109);
            this.grpSearchContent.TabIndex = 1;
            this.grpSearchContent.TabStop = false;
            this.grpSearchContent.Text = "查找信息范围";
            // 
            // chklSearchContent
            // 
            this.chklSearchContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklSearchContent.FormattingEnabled = true;
            this.chklSearchContent.Items.AddRange(new object[] {
            "书名",
            "ISBN",
            "作者",
            "出版社",
            "描述"});
            this.chklSearchContent.Location = new System.Drawing.Point(3, 17);
            this.chklSearchContent.Name = "chklSearchContent";
            this.chklSearchContent.Size = new System.Drawing.Size(177, 84);
            this.chklSearchContent.TabIndex = 0;
            // 
            // grpKeyWord
            // 
            this.grpKeyWord.Controls.Add(this.txtSearchKeyWord);
            this.grpKeyWord.Location = new System.Drawing.Point(5, 20);
            this.grpKeyWord.Name = "grpKeyWord";
            this.grpKeyWord.Size = new System.Drawing.Size(189, 46);
            this.grpKeyWord.TabIndex = 0;
            this.grpKeyWord.TabStop = false;
            this.grpKeyWord.Text = "查找关键字";
            // 
            // txtSearchKeyWord
            // 
            this.txtSearchKeyWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchKeyWord.Location = new System.Drawing.Point(3, 17);
            this.txtSearchKeyWord.MaxLength = 100;
            this.txtSearchKeyWord.Name = "txtSearchKeyWord";
            this.txtSearchKeyWord.Size = new System.Drawing.Size(183, 21);
            this.txtSearchKeyWord.TabIndex = 0;
            this.txtSearchKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchKeyWord_KeyPress);
            // 
            // picSearchPrg
            // 
            this.picSearchPrg.Image = global::eBookRelease.Properties.Resources.progress;
            this.picSearchPrg.Location = new System.Drawing.Point(37, 550);
            this.picSearchPrg.Name = "picSearchPrg";
            this.picSearchPrg.Size = new System.Drawing.Size(129, 21);
            this.picSearchPrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchPrg.TabIndex = 3;
            this.picSearchPrg.TabStop = false;
            this.picSearchPrg.Visible = false;
            // 
            // tpgStat
            // 
            this.tpgStat.Controls.Add(this.grpStatPrice);
            this.tpgStat.Controls.Add(this.grpStatPressDate);
            this.tpgStat.Controls.Add(this.btnStat);
            this.tpgStat.Controls.Add(this.grpStatType);
            this.tpgStat.Controls.Add(this.grpStatFileType);
            this.tpgStat.Controls.Add(this.picStatPrg);
            this.tpgStat.Location = new System.Drawing.Point(4, 21);
            this.tpgStat.Name = "tpgStat";
            this.tpgStat.Size = new System.Drawing.Size(232, 648);
            this.tpgStat.TabIndex = 2;
            this.tpgStat.Text = "统计";
            this.tpgStat.UseVisualStyleBackColor = true;
            // 
            // grpStatPrice
            // 
            this.grpStatPrice.Controls.Add(this.txtStatPriceTo);
            this.grpStatPrice.Controls.Add(this.lblStatPriceTo);
            this.grpStatPrice.Controls.Add(this.txtStatPriceFrom);
            this.grpStatPrice.Controls.Add(this.lblStatPriceFrom);
            this.grpStatPrice.Location = new System.Drawing.Point(7, 115);
            this.grpStatPrice.Name = "grpStatPrice";
            this.grpStatPrice.Size = new System.Drawing.Size(200, 54);
            this.grpStatPrice.TabIndex = 1;
            this.grpStatPrice.TabStop = false;
            this.grpStatPrice.Text = "价钱";
            this.grpStatPrice.Visible = false;
            // 
            // txtStatPriceTo
            // 
            this.txtStatPriceTo.Location = new System.Drawing.Point(120, 20);
            this.txtStatPriceTo.MaxLength = 10;
            this.txtStatPriceTo.Name = "txtStatPriceTo";
            this.txtStatPriceTo.Size = new System.Drawing.Size(62, 21);
            this.txtStatPriceTo.TabIndex = 7;
            // 
            // lblStatPriceTo
            // 
            this.lblStatPriceTo.AutoSize = true;
            this.lblStatPriceTo.Location = new System.Drawing.Point(97, 25);
            this.lblStatPriceTo.Name = "lblStatPriceTo";
            this.lblStatPriceTo.Size = new System.Drawing.Size(17, 12);
            this.lblStatPriceTo.TabIndex = 6;
            this.lblStatPriceTo.Text = "到";
            // 
            // txtStatPriceFrom
            // 
            this.txtStatPriceFrom.Location = new System.Drawing.Point(31, 20);
            this.txtStatPriceFrom.MaxLength = 10;
            this.txtStatPriceFrom.Name = "txtStatPriceFrom";
            this.txtStatPriceFrom.Size = new System.Drawing.Size(60, 21);
            this.txtStatPriceFrom.TabIndex = 5;
            // 
            // lblStatPriceFrom
            // 
            this.lblStatPriceFrom.AutoSize = true;
            this.lblStatPriceFrom.Location = new System.Drawing.Point(8, 25);
            this.lblStatPriceFrom.Name = "lblStatPriceFrom";
            this.lblStatPriceFrom.Size = new System.Drawing.Size(17, 12);
            this.lblStatPriceFrom.TabIndex = 4;
            this.lblStatPriceFrom.Text = "从";
            // 
            // grpStatPressDate
            // 
            this.grpStatPressDate.Controls.Add(this.dtpStatDateTo);
            this.grpStatPressDate.Controls.Add(this.label1);
            this.grpStatPressDate.Controls.Add(this.dtpStatDateFrom);
            this.grpStatPressDate.Controls.Add(this.label2);
            this.grpStatPressDate.Location = new System.Drawing.Point(7, 115);
            this.grpStatPressDate.Name = "grpStatPressDate";
            this.grpStatPressDate.Size = new System.Drawing.Size(200, 111);
            this.grpStatPressDate.TabIndex = 2;
            this.grpStatPressDate.TabStop = false;
            this.grpStatPressDate.Text = "出版日期";
            this.grpStatPressDate.Visible = false;
            // 
            // dtpStatDateTo
            // 
            this.dtpStatDateTo.Location = new System.Drawing.Point(7, 77);
            this.dtpStatDateTo.Name = "dtpStatDateTo";
            this.dtpStatDateTo.Size = new System.Drawing.Size(184, 21);
            this.dtpStatDateTo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "到";
            // 
            // dtpStatDateFrom
            // 
            this.dtpStatDateFrom.Location = new System.Drawing.Point(6, 38);
            this.dtpStatDateFrom.Name = "dtpStatDateFrom";
            this.dtpStatDateFrom.Size = new System.Drawing.Size(184, 21);
            this.dtpStatDateFrom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "从";
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(57, 282);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(75, 23);
            this.btnStat.TabIndex = 4;
            this.btnStat.Text = "统计";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // grpStatType
            // 
            this.grpStatType.Controls.Add(this.radFileType);
            this.grpStatType.Controls.Add(this.radPrice);
            this.grpStatType.Controls.Add(this.radPressDate);
            this.grpStatType.Location = new System.Drawing.Point(7, 6);
            this.grpStatType.Name = "grpStatType";
            this.grpStatType.Size = new System.Drawing.Size(200, 89);
            this.grpStatType.TabIndex = 0;
            this.grpStatType.TabStop = false;
            this.grpStatType.Text = "统计类型";
            // 
            // radFileType
            // 
            this.radFileType.AutoSize = true;
            this.radFileType.Checked = true;
            this.radFileType.Location = new System.Drawing.Point(6, 20);
            this.radFileType.Name = "radFileType";
            this.radFileType.Size = new System.Drawing.Size(83, 16);
            this.radFileType.TabIndex = 2;
            this.radFileType.TabStop = true;
            this.radFileType.Text = "按文件类型";
            this.radFileType.UseVisualStyleBackColor = true;
            this.radFileType.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radPrice
            // 
            this.radPrice.AutoSize = true;
            this.radPrice.Location = new System.Drawing.Point(6, 64);
            this.radPrice.Name = "radPrice";
            this.radPrice.Size = new System.Drawing.Size(59, 16);
            this.radPrice.TabIndex = 1;
            this.radPrice.Text = "按价钱";
            this.radPrice.UseVisualStyleBackColor = true;
            this.radPrice.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radPressDate
            // 
            this.radPressDate.AutoSize = true;
            this.radPressDate.Location = new System.Drawing.Point(6, 42);
            this.radPressDate.Name = "radPressDate";
            this.radPressDate.Size = new System.Drawing.Size(83, 16);
            this.radPressDate.TabIndex = 0;
            this.radPressDate.Text = "按出版日期";
            this.radPressDate.UseVisualStyleBackColor = true;
            this.radPressDate.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // grpStatFileType
            // 
            this.grpStatFileType.Controls.Add(this.txtStatFileType);
            this.grpStatFileType.Location = new System.Drawing.Point(8, 115);
            this.grpStatFileType.Name = "grpStatFileType";
            this.grpStatFileType.Size = new System.Drawing.Size(200, 46);
            this.grpStatFileType.TabIndex = 3;
            this.grpStatFileType.TabStop = false;
            this.grpStatFileType.Text = "文件类型";
            this.tltInfo.SetToolTip(this.grpStatFileType, "请按照以下格式输入：\r\n*.pdf *.chm ...");
            // 
            // txtStatFileType
            // 
            this.txtStatFileType.AutoCompleteCustomSource.AddRange(new string[] {
            "*.pdf",
            "*.chm",
            "*.pdg",
            "*.doc",
            "*.rar",
            "*.zip",
            "*.exe",
            "*.cs",
            "*.java"});
            this.txtStatFileType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStatFileType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStatFileType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatFileType.Location = new System.Drawing.Point(3, 17);
            this.txtStatFileType.MaxLength = 100;
            this.txtStatFileType.Name = "txtStatFileType";
            this.txtStatFileType.Size = new System.Drawing.Size(194, 21);
            this.txtStatFileType.TabIndex = 0;
            this.tltInfo.SetToolTip(this.txtStatFileType, "请按照以下格式输入：\r\n*.pdf *.chm ...");
            // 
            // picStatPrg
            // 
            this.picStatPrg.Image = global::eBookRelease.Properties.Resources.progress;
            this.picStatPrg.Location = new System.Drawing.Point(38, 245);
            this.picStatPrg.Name = "picStatPrg";
            this.picStatPrg.Size = new System.Drawing.Size(129, 21);
            this.picStatPrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStatPrg.TabIndex = 5;
            this.picStatPrg.TabStop = false;
            this.picStatPrg.Visible = false;
            // 
            // splittb
            // 
            this.splittb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splittb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splittb.Location = new System.Drawing.Point(0, 0);
            this.splittb.Name = "splittb";
            this.splittb.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splittb.Panel1
            // 
            this.splittb.Panel1.Controls.Add(this.lvwMain);
            this.splittb.Panel1.Controls.Add(this.pnlListView);
            // 
            // splittb.Panel2
            // 
            this.splittb.Panel2.ContextMenuStrip = this.cntMnuBookPnl;
            this.splittb.Panel2.Controls.Add(this.grpBookInfo);
            this.splittb.Size = new System.Drawing.Size(618, 675);
            this.splittb.SplitterDistance = 360;
            this.splittb.TabIndex = 0;
            // 
            // lvwMain
            // 
            this.lvwMain.AllowColumnReorder = true;
            this.lvwMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.size,
            this.type,
            this.date});
            this.lvwMain.ContextMenuStrip = this.cntMenuLvwMain;
            this.lvwMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMain.FullRowSelect = true;
            this.lvwMain.GridLines = true;
            this.lvwMain.LargeImageList = this.ilstIcon;
            this.lvwMain.Location = new System.Drawing.Point(0, 23);
            this.lvwMain.Name = "lvwMain";
            this.lvwMain.Size = new System.Drawing.Size(616, 335);
            this.lvwMain.SmallImageList = this.ilstIcon;
            this.lvwMain.TabIndex = 1;
            this.lvwMain.UseCompatibleStateImageBehavior = false;
            this.lvwMain.View = System.Windows.Forms.View.Details;
            this.lvwMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwMain_MouseDoubleClick);
            this.lvwMain.SelectedIndexChanged += new System.EventHandler(this.lvwMain_SelectedIndexChanged);
            this.lvwMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwMain_ColumnClick);
            this.lvwMain.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvwMain_ItemDrag);
            // 
            // name
            // 
            this.name.Text = "名称";
            this.name.Width = 200;
            // 
            // size
            // 
            this.size.Text = "大小(字节)";
            this.size.Width = 80;
            // 
            // type
            // 
            this.type.Text = "类型";
            // 
            // date
            // 
            this.date.Text = "最后访问日期";
            this.date.Width = 120;
            // 
            // cntMenuLvwMain
            // 
            this.cntMenuLvwMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMnuLvwOpen,
            this.tlsMnuLvwBack,
            this.toolStripSeparator7,
            this.tlsMnuLvwRenItem,
            this.tlsMnuLvwDelItem,
            this.tlsMnuLvwClearItems,
            this.toolStripSeparator8,
            this.tlsMnuLvwMdfInfo});
            this.cntMenuLvwMain.Name = "cntMenuLvwMain";
            this.cntMenuLvwMain.Size = new System.Drawing.Size(149, 148);
            // 
            // tlsMnuLvwOpen
            // 
            this.tlsMnuLvwOpen.Name = "tlsMnuLvwOpen";
            this.tlsMnuLvwOpen.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLvwOpen.Text = "打开";
            this.tlsMnuLvwOpen.Click += new System.EventHandler(this.tlsMnuLvwOpen_Click);
            // 
            // tlsMnuLvwBack
            // 
            this.tlsMnuLvwBack.Name = "tlsMnuLvwBack";
            this.tlsMnuLvwBack.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLvwBack.Text = "向上";
            this.tlsMnuLvwBack.Click += new System.EventHandler(this.tlsMnuLvwBack_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(145, 6);
            // 
            // tlsMnuLvwRenItem
            // 
            this.tlsMnuLvwRenItem.Name = "tlsMnuLvwRenItem";
            this.tlsMnuLvwRenItem.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLvwRenItem.Text = "重命名此项";
            this.tlsMnuLvwRenItem.Click += new System.EventHandler(this.tlsMnuLvwRenItem_Click);
            // 
            // tlsMnuLvwDelItem
            // 
            this.tlsMnuLvwDelItem.Name = "tlsMnuLvwDelItem";
            this.tlsMnuLvwDelItem.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLvwDelItem.Text = "删除此项";
            this.tlsMnuLvwDelItem.Click += new System.EventHandler(this.tlsMnuLvwDelItem_Click);
            // 
            // tlsMnuLvwClearItems
            // 
            this.tlsMnuLvwClearItems.Name = "tlsMnuLvwClearItems";
            this.tlsMnuLvwClearItems.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLvwClearItems.Text = "清空列表";
            this.tlsMnuLvwClearItems.Click += new System.EventHandler(this.tlsMnuLvwClearItems_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(145, 6);
            // 
            // tlsMnuLvwMdfInfo
            // 
            this.tlsMnuLvwMdfInfo.Name = "tlsMnuLvwMdfInfo";
            this.tlsMnuLvwMdfInfo.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLvwMdfInfo.Text = "修改eBook信息";
            this.tlsMnuLvwMdfInfo.Click += new System.EventHandler(this.tlsMnuLvwMdfInfo_Click);
            // 
            // pnlListView
            // 
            this.pnlListView.BackgroundImage = global::eBookRelease.Properties.Resources.bg;
            this.pnlListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlListView.Controls.Add(this.lnkModifyBookInfo);
            this.pnlListView.Controls.Add(this.lnkClearItems);
            this.pnlListView.Controls.Add(this.lblSearchCount);
            this.pnlListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListView.Location = new System.Drawing.Point(0, 0);
            this.pnlListView.Name = "pnlListView";
            this.pnlListView.Size = new System.Drawing.Size(616, 23);
            this.pnlListView.TabIndex = 0;
            // 
            // lnkModifyBookInfo
            // 
            this.lnkModifyBookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkModifyBookInfo.AutoSize = true;
            this.lnkModifyBookInfo.BackColor = System.Drawing.Color.Transparent;
            this.lnkModifyBookInfo.Location = new System.Drawing.Point(468, 5);
            this.lnkModifyBookInfo.Name = "lnkModifyBookInfo";
            this.lnkModifyBookInfo.Size = new System.Drawing.Size(83, 12);
            this.lnkModifyBookInfo.TabIndex = 2;
            this.lnkModifyBookInfo.TabStop = true;
            this.lnkModifyBookInfo.Text = "修改eBook信息";
            this.lnkModifyBookInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkModifyBookInfo_LinkClicked);
            // 
            // lnkClearItems
            // 
            this.lnkClearItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClearItems.AutoSize = true;
            this.lnkClearItems.BackColor = System.Drawing.Color.Transparent;
            this.lnkClearItems.Location = new System.Drawing.Point(557, 5);
            this.lnkClearItems.Name = "lnkClearItems";
            this.lnkClearItems.Size = new System.Drawing.Size(53, 12);
            this.lnkClearItems.TabIndex = 1;
            this.lnkClearItems.TabStop = true;
            this.lnkClearItems.Text = "清空列表";
            this.lnkClearItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearItems_LinkClicked);
            // 
            // lblSearchCount
            // 
            this.lblSearchCount.AutoSize = true;
            this.lblSearchCount.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSearchCount.Location = new System.Drawing.Point(4, 6);
            this.lblSearchCount.Name = "lblSearchCount";
            this.lblSearchCount.Size = new System.Drawing.Size(0, 12);
            this.lblSearchCount.TabIndex = 0;
            // 
            // cntMnuBookPnl
            // 
            this.cntMnuBookPnl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMnuBookHidePnl});
            this.cntMnuBookPnl.Name = "cntMnuBookPnl";
            this.cntMnuBookPnl.Size = new System.Drawing.Size(95, 26);
            // 
            // tlsMnuBookHidePnl
            // 
            this.tlsMnuBookHidePnl.Name = "tlsMnuBookHidePnl";
            this.tlsMnuBookHidePnl.Size = new System.Drawing.Size(94, 22);
            this.tlsMnuBookHidePnl.Text = "隐藏";
            this.tlsMnuBookHidePnl.Click += new System.EventHandler(this.tlsMnuBookHidePnl_Click);
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.BackgroundImage = global::eBookRelease.Properties.Resources.bg;
            this.grpBookInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpBookInfo.Controls.Add(this.pnlBookInfo);
            this.grpBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBookInfo.Location = new System.Drawing.Point(0, 0);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(616, 309);
            this.grpBookInfo.TabIndex = 0;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "eBook信息";
            // 
            // pnlBookInfo
            // 
            this.pnlBookInfo.AutoScroll = true;
            this.pnlBookInfo.BackgroundImage = global::eBookRelease.Properties.Resources.bg;
            this.pnlBookInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBookInfo.Controls.Add(this.txtBookName);
            this.pnlBookInfo.Controls.Add(this.lblBookName);
            this.pnlBookInfo.Controls.Add(this.picSaveOK);
            this.pnlBookInfo.Controls.Add(this.lblSaveSuccess);
            this.pnlBookInfo.Controls.Add(this.btnSave);
            this.pnlBookInfo.Controls.Add(this.txtDescription);
            this.pnlBookInfo.Controls.Add(this.dtpPressDate);
            this.pnlBookInfo.Controls.Add(this.lblISBN);
            this.pnlBookInfo.Controls.Add(this.txtPress);
            this.pnlBookInfo.Controls.Add(this.lblAuthor);
            this.pnlBookInfo.Controls.Add(this.msktPrice);
            this.pnlBookInfo.Controls.Add(this.lblPrice);
            this.pnlBookInfo.Controls.Add(this.txtAuthor);
            this.pnlBookInfo.Controls.Add(this.lblPress);
            this.pnlBookInfo.Controls.Add(this.txtISBN);
            this.pnlBookInfo.Controls.Add(this.lblPressDate);
            this.pnlBookInfo.Controls.Add(this.lblDescription);
            this.pnlBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookInfo.Location = new System.Drawing.Point(3, 17);
            this.pnlBookInfo.Name = "pnlBookInfo";
            this.pnlBookInfo.Size = new System.Drawing.Size(610, 289);
            this.pnlBookInfo.TabIndex = 12;
            // 
            // txtBookName
            // 
            this.txtBookName.Enabled = false;
            this.txtBookName.Location = new System.Drawing.Point(258, 5);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(270, 21);
            this.txtBookName.TabIndex = 16;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(178, 8);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(29, 12);
            this.lblBookName.TabIndex = 15;
            this.lblBookName.Text = "书名";
            // 
            // picSaveOK
            // 
            this.picSaveOK.BackColor = System.Drawing.Color.Transparent;
            this.picSaveOK.Image = global::eBookRelease.Properties.Resources.saveok;
            this.picSaveOK.Location = new System.Drawing.Point(368, 232);
            this.picSaveOK.Name = "picSaveOK";
            this.picSaveOK.Size = new System.Drawing.Size(33, 32);
            this.picSaveOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaveOK.TabIndex = 14;
            this.picSaveOK.TabStop = false;
            this.picSaveOK.Visible = false;
            // 
            // lblSaveSuccess
            // 
            this.lblSaveSuccess.AutoSize = true;
            this.lblSaveSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveSuccess.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSaveSuccess.Location = new System.Drawing.Point(407, 240);
            this.lblSaveSuccess.Name = "lblSaveSuccess";
            this.lblSaveSuccess.Size = new System.Drawing.Size(110, 16);
            this.lblSaveSuccess.TabIndex = 13;
            this.lblSaveSuccess.Text = "保存信息成功";
            this.lblSaveSuccess.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(258, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(258, 168);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(270, 58);
            this.txtDescription.TabIndex = 11;
            // 
            // dtpPressDate
            // 
            this.dtpPressDate.Location = new System.Drawing.Point(258, 141);
            this.dtpPressDate.Name = "dtpPressDate";
            this.dtpPressDate.Size = new System.Drawing.Size(270, 21);
            this.dtpPressDate.TabIndex = 10;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(178, 35);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(29, 12);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // txtPress
            // 
            this.txtPress.AutoCompleteCustomSource.AddRange(new string[] {
            "北京理工大学出版社",
            "清华大学出版社",
            "北京大学出版社",
            "电子工业出版社",
            "人民邮电出版社",
            "机械工业出版社",
            "科学出版社"});
            this.txtPress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPress.Location = new System.Drawing.Point(258, 114);
            this.txtPress.MaxLength = 100;
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(270, 21);
            this.txtPress.TabIndex = 9;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(178, 63);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(29, 12);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "作者";
            // 
            // msktPrice
            // 
            this.msktPrice.Location = new System.Drawing.Point(258, 87);
            this.msktPrice.Name = "msktPrice";
            this.msktPrice.Size = new System.Drawing.Size(270, 21);
            this.msktPrice.TabIndex = 8;
            this.tltInfo.SetToolTip(this.msktPrice, "请输入整数或小数");
            this.msktPrice.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBox_TypeValidationCompleted);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(178, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "价钱";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(258, 59);
            this.txtAuthor.MaxLength = 100;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(270, 21);
            this.txtAuthor.TabIndex = 7;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(178, 117);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(41, 12);
            this.lblPress.TabIndex = 3;
            this.lblPress.Text = "出版社";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(258, 32);
            this.txtISBN.MaxLength = 100;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(270, 21);
            this.txtISBN.TabIndex = 6;
            // 
            // lblPressDate
            // 
            this.lblPressDate.AutoSize = true;
            this.lblPressDate.Location = new System.Drawing.Point(178, 144);
            this.lblPressDate.Name = "lblPressDate";
            this.lblPressDate.Size = new System.Drawing.Size(53, 12);
            this.lblPressDate.TabIndex = 4;
            this.lblPressDate.Text = "出版日期";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(178, 192);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(29, 12);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "描述";
            // 
            // cntMenuRootNode
            // 
            this.cntMenuRootNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMnuRootCollapse,
            this.toolStripSeparator1,
            this.tlsMnuRootAddFolder,
            this.toolStripSeparator2,
            this.tlsMnuRootNewNode,
            this.tlsMnuRootRenNode});
            this.cntMenuRootNode.Name = "contextMenuStrip1";
            this.cntMenuRootNode.Size = new System.Drawing.Size(131, 104);
            // 
            // tlsMnuRootCollapse
            // 
            this.tlsMnuRootCollapse.Name = "tlsMnuRootCollapse";
            this.tlsMnuRootCollapse.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuRootCollapse.Text = "折叠";
            this.tlsMnuRootCollapse.Click += new System.EventHandler(this.tlsMnuRootCollapse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // tlsMnuRootAddFolder
            // 
            this.tlsMnuRootAddFolder.Name = "tlsMnuRootAddFolder";
            this.tlsMnuRootAddFolder.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuRootAddFolder.Text = "添加文件夹";
            this.tlsMnuRootAddFolder.Click += new System.EventHandler(this.tlsMnuRootAddFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // tlsMnuRootNewNode
            // 
            this.tlsMnuRootNewNode.Name = "tlsMnuRootNewNode";
            this.tlsMnuRootNewNode.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuRootNewNode.Text = "新建节点";
            this.tlsMnuRootNewNode.Click += new System.EventHandler(this.tlsMnuRootNewNode_Click);
            // 
            // tlsMnuRootRenNode
            // 
            this.tlsMnuRootRenNode.Name = "tlsMnuRootRenNode";
            this.tlsMnuRootRenNode.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuRootRenNode.Text = "重命名节点";
            this.tlsMnuRootRenNode.Click += new System.EventHandler(this.tlsMnuRootRenNode_Click);
            // 
            // cntMenuParentNode
            // 
            this.cntMenuParentNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMnuParentCollapse,
            this.toolStripSeparator3,
            this.tlsMnuParentAddFile,
            this.tlsMnuParentAddFolder,
            this.toolStripSeparator4,
            this.tlsMnuParentNewNode,
            this.tlsMnuParentDelNode,
            this.tlsMenuParentRenNode});
            this.cntMenuParentNode.Name = "cntMenuParentNode";
            this.cntMenuParentNode.Size = new System.Drawing.Size(131, 148);
            // 
            // tlsMnuParentCollapse
            // 
            this.tlsMnuParentCollapse.Name = "tlsMnuParentCollapse";
            this.tlsMnuParentCollapse.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuParentCollapse.Text = "折叠";
            this.tlsMnuParentCollapse.Click += new System.EventHandler(this.tlsMnuParentCollapse_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(127, 6);
            // 
            // tlsMnuParentAddFile
            // 
            this.tlsMnuParentAddFile.Name = "tlsMnuParentAddFile";
            this.tlsMnuParentAddFile.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuParentAddFile.Text = "添加文件";
            this.tlsMnuParentAddFile.Click += new System.EventHandler(this.tlsMnuParentAddFile_Click);
            // 
            // tlsMnuParentAddFolder
            // 
            this.tlsMnuParentAddFolder.Name = "tlsMnuParentAddFolder";
            this.tlsMnuParentAddFolder.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuParentAddFolder.Text = "添加文件夹";
            this.tlsMnuParentAddFolder.Click += new System.EventHandler(this.tlsMnuParentAddFolder_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(127, 6);
            // 
            // tlsMnuParentNewNode
            // 
            this.tlsMnuParentNewNode.Name = "tlsMnuParentNewNode";
            this.tlsMnuParentNewNode.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuParentNewNode.Text = "新建节点";
            this.tlsMnuParentNewNode.Click += new System.EventHandler(this.tlsMnuParentNewNode_Click);
            // 
            // tlsMnuParentDelNode
            // 
            this.tlsMnuParentDelNode.Name = "tlsMnuParentDelNode";
            this.tlsMnuParentDelNode.Size = new System.Drawing.Size(130, 22);
            this.tlsMnuParentDelNode.Text = "删除节点";
            this.tlsMnuParentDelNode.Click += new System.EventHandler(this.tlsMnuParentDelNode_Click);
            // 
            // tlsMenuParentRenNode
            // 
            this.tlsMenuParentRenNode.Name = "tlsMenuParentRenNode";
            this.tlsMenuParentRenNode.Size = new System.Drawing.Size(130, 22);
            this.tlsMenuParentRenNode.Text = "重命名节点";
            this.tlsMenuParentRenNode.Click += new System.EventHandler(this.tlsMenuParentRenNode_Click);
            // 
            // cntMenuLeafNode
            // 
            this.cntMenuLeafNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMnuLeafOpenFile,
            this.tlsMnuLeafOpenFolder,
            this.toolStripSeparator5,
            this.tlsMnuLeafDelNode,
            this.tlsMnuLeafRenNode,
            this.toolStripSeparator6,
            this.tlsMnuLeafMfyInfo});
            this.cntMenuLeafNode.Name = "cntMenuLeafNode";
            this.cntMenuLeafNode.Size = new System.Drawing.Size(149, 126);
            // 
            // tlsMnuLeafOpenFile
            // 
            this.tlsMnuLeafOpenFile.Name = "tlsMnuLeafOpenFile";
            this.tlsMnuLeafOpenFile.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLeafOpenFile.Text = "打开文件";
            this.tlsMnuLeafOpenFile.Click += new System.EventHandler(this.tlsMnuLeafOpenFile_Click);
            // 
            // tlsMnuLeafOpenFolder
            // 
            this.tlsMnuLeafOpenFolder.Name = "tlsMnuLeafOpenFolder";
            this.tlsMnuLeafOpenFolder.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLeafOpenFolder.Text = "打开文件目录";
            this.tlsMnuLeafOpenFolder.Click += new System.EventHandler(this.tlsMnuLeafOpenFolder_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(145, 6);
            // 
            // tlsMnuLeafDelNode
            // 
            this.tlsMnuLeafDelNode.Name = "tlsMnuLeafDelNode";
            this.tlsMnuLeafDelNode.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLeafDelNode.Text = "删除节点";
            this.tlsMnuLeafDelNode.Click += new System.EventHandler(this.tlsMnuLeafDelNode_Click);
            // 
            // tlsMnuLeafRenNode
            // 
            this.tlsMnuLeafRenNode.Name = "tlsMnuLeafRenNode";
            this.tlsMnuLeafRenNode.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLeafRenNode.Text = "重命名节点";
            this.tlsMnuLeafRenNode.Click += new System.EventHandler(this.tlsMnuLeafRenNode_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(145, 6);
            // 
            // tlsMnuLeafMfyInfo
            // 
            this.tlsMnuLeafMfyInfo.Name = "tlsMnuLeafMfyInfo";
            this.tlsMnuLeafMfyInfo.Size = new System.Drawing.Size(148, 22);
            this.tlsMnuLeafMfyInfo.Text = "修改eBook信息";
            this.tlsMnuLeafMfyInfo.Click += new System.EventHandler(this.tlsMnuLeafMfyInfo_Click);
            // 
            // fbdlgAddFolder
            // 
            this.fbdlgAddFolder.Description = "请选择要添加的文件夹";
            // 
            // odlgAddFile
            // 
            this.odlgAddFile.FilterIndex = 0;
            this.odlgAddFile.Multiselect = true;
            // 
            // errPrice
            // 
            this.errPrice.ContainerControl = this;
            // 
            // tltInfo
            // 
            this.tltInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltInfo.ToolTipTitle = "信息提示";
            // 
            // sdlgSaveList
            // 
            this.sdlgSaveList.DefaultExt = "txt";
            this.sdlgSaveList.Filter = "txt(*.txt)|*.txt|all files(*.*)|*.*";
            this.sdlgSaveList.Title = "保存eBook列表";
            // 
            // ntfyMain
            // 
            this.ntfyMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfyMain.BalloonTipText = "嘿，我在这里~";
            this.ntfyMain.BalloonTipTitle = "信息提示";
            this.ntfyMain.ContextMenuStrip = this.cntMenuNtfyMain;
            this.ntfyMain.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyMain.Icon")));
            this.ntfyMain.Text = "eBook信息管理软件V1.0";
            this.ntfyMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ntfyMain_MouseClick);
            // 
            // cntMenuNtfyMain
            // 
            this.cntMenuNtfyMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMnuNtfyShow,
            this.tlsMnuNtfyAuthor,
            this.tlsMnuNtfyExit});
            this.cntMenuNtfyMain.Name = "cntMenuNtfyMain";
            this.cntMenuNtfyMain.Size = new System.Drawing.Size(119, 70);
            // 
            // tlsMnuNtfyShow
            // 
            this.tlsMnuNtfyShow.Name = "tlsMnuNtfyShow";
            this.tlsMnuNtfyShow.Size = new System.Drawing.Size(118, 22);
            this.tlsMnuNtfyShow.Text = "显示";
            this.tlsMnuNtfyShow.Click += new System.EventHandler(this.tlsMnuNtfyShow_Click);
            // 
            // tlsMnuNtfyAuthor
            // 
            this.tlsMnuNtfyAuthor.Image = global::eBookRelease.Properties.Resources.me;
            this.tlsMnuNtfyAuthor.Name = "tlsMnuNtfyAuthor";
            this.tlsMnuNtfyAuthor.Size = new System.Drawing.Size(118, 22);
            this.tlsMnuNtfyAuthor.Text = "关于作者";
            this.tlsMnuNtfyAuthor.Click += new System.EventHandler(this.tlsMnuNtfyAuthor_Click);
            // 
            // tlsMnuNtfyExit
            // 
            this.tlsMnuNtfyExit.Name = "tlsMnuNtfyExit";
            this.tlsMnuNtfyExit.Size = new System.Drawing.Size(118, 22);
            this.tlsMnuNtfyExit.Text = "退出";
            this.tlsMnuNtfyExit.Click += new System.EventHandler(this.tlsMnuNtfyExit_Click);
            // 
            // statusMain
            // 
            this.statusMain.BackgroundImage = global::eBookRelease.Properties.Resources.bg;
            this.statusMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusMain.ImageScalingSize = new System.Drawing.Size(50, 16);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusTip});
            this.statusMain.Location = new System.Drawing.Point(0, 724);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(864, 22);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "statusStrip1";
            // 
            // lblStatusTip
            // 
            this.lblStatusTip.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusTip.Font = new System.Drawing.Font("SimSun", 9F);
            this.lblStatusTip.Name = "lblStatusTip";
            this.lblStatusTip.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 746);
            this.Controls.Add(this.splitlr);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "eBook信息管理软件V1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.splitlr.Panel1.ResumeLayout(false);
            this.splitlr.Panel2.ResumeLayout(false);
            this.splitlr.ResumeLayout(false);
            this.tctlLeft.ResumeLayout(false);
            this.tpgManagement.ResumeLayout(false);
            this.tpgSearch.ResumeLayout(false);
            this.grpSearchPath.ResumeLayout(false);
            this.grpSearchOptionalItem.ResumeLayout(false);
            this.grpSearchOptionalItem.PerformLayout();
            this.grpSearchPressDate.ResumeLayout(false);
            this.grpSearchPressDate.PerformLayout();
            this.grpSearchPrice.ResumeLayout(false);
            this.grpSearchPrice.PerformLayout();
            this.grpFileType.ResumeLayout(false);
            this.grpFileType.PerformLayout();
            this.grpSearchMustItem.ResumeLayout(false);
            this.grpSearchContent.ResumeLayout(false);
            this.grpKeyWord.ResumeLayout(false);
            this.grpKeyWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchPrg)).EndInit();
            this.tpgStat.ResumeLayout(false);
            this.grpStatPrice.ResumeLayout(false);
            this.grpStatPrice.PerformLayout();
            this.grpStatPressDate.ResumeLayout(false);
            this.grpStatPressDate.PerformLayout();
            this.grpStatType.ResumeLayout(false);
            this.grpStatType.PerformLayout();
            this.grpStatFileType.ResumeLayout(false);
            this.grpStatFileType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatPrg)).EndInit();
            this.splittb.Panel1.ResumeLayout(false);
            this.splittb.Panel2.ResumeLayout(false);
            this.splittb.ResumeLayout(false);
            this.cntMenuLvwMain.ResumeLayout(false);
            this.pnlListView.ResumeLayout(false);
            this.pnlListView.PerformLayout();
            this.cntMnuBookPnl.ResumeLayout(false);
            this.grpBookInfo.ResumeLayout(false);
            this.pnlBookInfo.ResumeLayout(false);
            this.pnlBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveOK)).EndInit();
            this.cntMenuRootNode.ResumeLayout(false);
            this.cntMenuParentNode.ResumeLayout(false);
            this.cntMenuLeafNode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).EndInit();
            this.cntMenuNtfyMain.ResumeLayout(false);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.SplitContainer splitlr;
        private System.Windows.Forms.TabControl tctlLeft;
        private System.Windows.Forms.TabPage tpgManagement;
        private System.Windows.Forms.TreeView tvwMain;
        private System.Windows.Forms.TabPage tpgSearch;
        private System.Windows.Forms.SplitContainer splittb;
        private System.Windows.Forms.TabPage tpgStat;
        private System.Windows.Forms.Panel pnlListView;
        private System.Windows.Forms.ListView lvwMain;
        private System.Windows.Forms.ToolStripMenuItem tlsMenuFile;
        private System.Windows.Forms.ToolStripMenuItem tlsMenuTool;
        private System.Windows.Forms.ToolStripMenuItem tlsMenuHelp;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTip;
        private System.Windows.Forms.ImageList ilstIcon;
        private System.Windows.Forms.ContextMenuStrip cntMenuRootNode;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuRootCollapse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuRootAddFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuRootNewNode;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuRootRenNode;
        private System.Windows.Forms.ContextMenuStrip cntMenuParentNode;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuParentCollapse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuParentAddFolder;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuParentAddFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuParentNewNode;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuParentDelNode;
        private System.Windows.Forms.ToolStripMenuItem tlsMenuParentRenNode;
        private System.Windows.Forms.ContextMenuStrip cntMenuLeafNode;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLeafOpenFile;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLeafOpenFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLeafDelNode;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLeafRenNode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLeafMfyInfo;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ContextMenuStrip cntMenuLvwMain;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLvwOpen;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLvwBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLvwRenItem;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLvwDelItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLvwMdfInfo;
        private System.Windows.Forms.FolderBrowserDialog fbdlgAddFolder;
        private System.Windows.Forms.OpenFileDialog odlgAddFile;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.Panel pnlBookInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpPressDate;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.MaskedTextBox msktPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblPressDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSaveSuccess;
        private System.Windows.Forms.ErrorProvider errPrice;
        private System.Windows.Forms.ToolTip tltInfo;
        private System.Windows.Forms.PictureBox picSaveOK;
        private System.Windows.Forms.ContextMenuStrip cntMnuBookPnl;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuBookHidePnl;
        private System.Windows.Forms.GroupBox grpSearchMustItem;
        private System.Windows.Forms.GroupBox grpKeyWord;
        private System.Windows.Forms.TextBox txtSearchKeyWord;
        private System.Windows.Forms.GroupBox grpSearchContent;
        private System.Windows.Forms.CheckedListBox chklSearchContent;
        private System.Windows.Forms.GroupBox grpSearchOptionalItem;
        private System.Windows.Forms.GroupBox grpFileType;
        private System.Windows.Forms.TextBox txtSearchFileType;
        private System.Windows.Forms.GroupBox grpSearchPrice;
        private System.Windows.Forms.TextBox txtSearchPriceTo;
        private System.Windows.Forms.Label lblSearchPriceTo;
        private System.Windows.Forms.TextBox txtSearchPriceFrom;
        private System.Windows.Forms.Label lblSearchPriceFrom;
        private System.Windows.Forms.GroupBox grpSearchPressDate;
        private System.Windows.Forms.DateTimePicker dtpSearchDateTo;
        private System.Windows.Forms.Label lblSearchDateTo;
        private System.Windows.Forms.DateTimePicker dtpSearchDateFrom;
        private System.Windows.Forms.Label lblSearchDateFrom;
        private System.Windows.Forms.GroupBox grpSearchPath;
        private ComboBoxEx cmbxSearchPath;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picSearchPrg;
        private System.Windows.Forms.CheckBox chkSearchFileType;
        private System.Windows.Forms.CheckBox chkSearchPrice;
        private System.Windows.Forms.CheckBox chkSearchDate;
        private System.Windows.Forms.LinkLabel lnkClearItems;
        private System.Windows.Forms.Label lblSearchCount;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuLvwClearItems;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.GroupBox grpStatType;
        private System.Windows.Forms.RadioButton radPrice;
        private System.Windows.Forms.RadioButton radPressDate;
        private System.Windows.Forms.RadioButton radFileType;
        private System.Windows.Forms.GroupBox grpStatPrice;
        private System.Windows.Forms.GroupBox grpStatPressDate;
        private System.Windows.Forms.TextBox txtStatPriceTo;
        private System.Windows.Forms.Label lblStatPriceTo;
        private System.Windows.Forms.TextBox txtStatPriceFrom;
        private System.Windows.Forms.Label lblStatPriceFrom;
        private System.Windows.Forms.DateTimePicker dtpStatDateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStatDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpStatFileType;
        private System.Windows.Forms.TextBox txtStatFileType;
        private System.Windows.Forms.PictureBox picStatPrg;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuToolExportList;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuToolSetExport;
        private System.Windows.Forms.SaveFileDialog sdlgSaveList;
        private System.Windows.Forms.NotifyIcon ntfyMain;
        private System.Windows.Forms.ContextMenuStrip cntMenuNtfyMain;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuNtfyShow;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuNtfyAuthor;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuNtfyExit;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuFileAddFile;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuFileAddFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuToolClearList;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuToolSearch;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuToolStat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuHelpDocument;
        private System.Windows.Forms.ToolStripMenuItem tlsMmuHelpSoft;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuHelpAuthor;
        private System.Windows.Forms.LinkLabel lnkModifyBookInfo;
        private System.Windows.Forms.ToolStripButton tlsBtnAddFile;
        private System.Windows.Forms.ToolStripButton tlsBtnAddFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tlsBtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton tlsBtnBack;
        private System.Windows.Forms.ToolStripButton tlsBtnClearList;
        private System.Windows.Forms.ToolStripButton tlsBtnStat;
        private System.Windows.Forms.ToolStripDropDownButton tlsdropBtnViewType;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuViewIcon;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuViewList;
        private System.Windows.Forms.ToolStripMenuItem tlsMnuViewDetails;
    }
}

