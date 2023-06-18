namespace ZTCNAVI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("导入的文件");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("质检报告");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.naviPanel = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.inputFilePage = new System.Windows.Forms.TabPage();
            this.inputFileGrid = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityCheckPage = new System.Windows.Forms.TabPage();
            this.qualityCheckGrid = new System.Windows.Forms.DataGridView();
            this.QCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPSIntegrity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDSIntegrity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CycleSlipRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L1OrB1MPRMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L2OrB2MPRMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.integrityPage = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.integrityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.integrityGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integrity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integrity2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integrity3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.All = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theoretical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slipPage = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.slipGridView = new System.Windows.Forms.DataGridView();
            this.slipGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validObsNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multipathPage = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.filterBtn = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.CheckedListBox();
            this.multipathChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.multipathGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logBtn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.propertyLb = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid = new System.Windows.Forms.DataGridView();
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyBox = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.导入toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.导出StripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.全部检核toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检核选中文件MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.上一个toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.下一个toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.向左翻页toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.向右翻页toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出质检报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入的文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.质检报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据完整度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.周跳探测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多路径效应ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.导航toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输出栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启用B1B3双频观测值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.inputFilePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputFileGrid)).BeginInit();
            this.qualityCheckPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualityCheckGrid)).BeginInit();
            this.integrityPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integrityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrityGrid)).BeginInit();
            this.slipPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slipGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipGrid)).BeginInit();
            this.multipathPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multipathChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multipathGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(12, 84);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1158, 585);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.naviPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 585);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导航";
            // 
            // naviPanel
            // 
            this.naviPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.naviPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviPanel.HideSelection = false;
            this.naviPanel.ImageIndex = 0;
            this.naviPanel.ImageList = this.imgList;
            this.naviPanel.Location = new System.Drawing.Point(3, 23);
            this.naviPanel.Name = "naviPanel";
            treeNode1.ImageKey = "导入.png";
            treeNode1.Name = "InputFileNode";
            treeNode1.SelectedImageKey = "导入.png";
            treeNode1.Text = "导入的文件";
            treeNode2.ImageKey = "检核.png";
            treeNode2.Name = "QualityCheckReportNode";
            treeNode2.SelectedImageKey = "检核.png";
            treeNode2.Text = "质检报告";
            this.naviPanel.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.naviPanel.SelectedImageIndex = 0;
            this.naviPanel.Size = new System.Drawing.Size(187, 559);
            this.naviPanel.TabIndex = 0;
            this.naviPanel.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.naviPanel_NodeMouseClick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "导入.png");
            this.imgList.Images.SetKeyName(1, "检核.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(961, 585);
            this.splitContainer2.SplitterDistance = 801;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer4.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer4.Size = new System.Drawing.Size(801, 585);
            this.splitContainer4.SplitterDistance = 451;
            this.splitContainer4.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.inputFilePage);
            this.tabControl.Controls.Add(this.qualityCheckPage);
            this.tabControl.Controls.Add(this.integrityPage);
            this.tabControl.Controls.Add(this.slipPage);
            this.tabControl.Controls.Add(this.multipathPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 451);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // inputFilePage
            // 
            this.inputFilePage.BackColor = System.Drawing.Color.Transparent;
            this.inputFilePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFilePage.Controls.Add(this.inputFileGrid);
            this.inputFilePage.Location = new System.Drawing.Point(4, 29);
            this.inputFilePage.Name = "inputFilePage";
            this.inputFilePage.Padding = new System.Windows.Forms.Padding(3);
            this.inputFilePage.Size = new System.Drawing.Size(793, 418);
            this.inputFilePage.TabIndex = 0;
            this.inputFilePage.Text = "导入的文件";
            // 
            // inputFileGrid
            // 
            this.inputFileGrid.AllowUserToAddRows = false;
            this.inputFileGrid.AllowUserToDeleteRows = false;
            this.inputFileGrid.AllowUserToResizeRows = false;
            this.inputFileGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.inputFileGrid.BackgroundColor = System.Drawing.Color.White;
            this.inputFileGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.inputFileGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inputFileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputFileGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.StationName,
            this.StartTime,
            this.EndTime,
            this.Duration,
            this.FilePath});
            this.inputFileGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputFileGrid.EnableHeadersVisualStyles = false;
            this.inputFileGrid.GridColor = System.Drawing.Color.Silver;
            this.inputFileGrid.Location = new System.Drawing.Point(3, 3);
            this.inputFileGrid.Name = "inputFileGrid";
            this.inputFileGrid.ReadOnly = true;
            this.inputFileGrid.RowHeadersVisible = false;
            this.inputFileGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            this.inputFileGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.inputFileGrid.RowTemplate.Height = 27;
            this.inputFileGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inputFileGrid.Size = new System.Drawing.Size(785, 410);
            this.inputFileGrid.TabIndex = 0;
            this.inputFileGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputFileGrid_CellClick);
            this.inputFileGrid.SelectionChanged += new System.EventHandler(this.inputFileGrid_SelectionChanged);
            // 
            // FileName
            // 
            this.FileName.HeaderText = "文件名称";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FileName.Width = 74;
            // 
            // StationName
            // 
            this.StationName.HeaderText = "测站名";
            this.StationName.MinimumWidth = 6;
            this.StationName.Name = "StationName";
            this.StationName.ReadOnly = true;
            this.StationName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StationName.Width = 59;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "开始时间";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StartTime.Width = 74;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "结束时间";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EndTime.Width = 74;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "时间段";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Duration.Width = 59;
            // 
            // FilePath
            // 
            this.FilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilePath.HeaderText = "文件路径";
            this.FilePath.MinimumWidth = 6;
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // qualityCheckPage
            // 
            this.qualityCheckPage.BackColor = System.Drawing.Color.Transparent;
            this.qualityCheckPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qualityCheckPage.Controls.Add(this.qualityCheckGrid);
            this.qualityCheckPage.Location = new System.Drawing.Point(4, 29);
            this.qualityCheckPage.Name = "qualityCheckPage";
            this.qualityCheckPage.Padding = new System.Windows.Forms.Padding(3);
            this.qualityCheckPage.Size = new System.Drawing.Size(793, 418);
            this.qualityCheckPage.TabIndex = 4;
            this.qualityCheckPage.Text = "质检报告";
            // 
            // qualityCheckGrid
            // 
            this.qualityCheckGrid.AllowUserToAddRows = false;
            this.qualityCheckGrid.AllowUserToDeleteRows = false;
            this.qualityCheckGrid.AllowUserToResizeRows = false;
            this.qualityCheckGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.qualityCheckGrid.BackgroundColor = System.Drawing.Color.White;
            this.qualityCheckGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.qualityCheckGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.qualityCheckGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qualityCheckGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QCName,
            this.dataGridViewTextBoxColumn4,
            this.Time,
            this.GPSIntegrity,
            this.BDSIntegrity,
            this.CycleSlipRatio,
            this.L1OrB1MPRMS,
            this.L2OrB2MPRMS});
            this.qualityCheckGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qualityCheckGrid.EnableHeadersVisualStyles = false;
            this.qualityCheckGrid.GridColor = System.Drawing.Color.Silver;
            this.qualityCheckGrid.Location = new System.Drawing.Point(3, 3);
            this.qualityCheckGrid.Name = "qualityCheckGrid";
            this.qualityCheckGrid.ReadOnly = true;
            this.qualityCheckGrid.RowHeadersVisible = false;
            this.qualityCheckGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            this.qualityCheckGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.qualityCheckGrid.RowTemplate.Height = 27;
            this.qualityCheckGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.qualityCheckGrid.Size = new System.Drawing.Size(785, 410);
            this.qualityCheckGrid.TabIndex = 3;
            this.qualityCheckGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qualityCheckGrid_CellClick);
            this.qualityCheckGrid.SelectionChanged += new System.EventHandler(this.qualityCheckGrid_SelectionChanged);
            // 
            // QCName
            // 
            this.QCName.HeaderText = "报告名称";
            this.QCName.MinimumWidth = 6;
            this.QCName.Name = "QCName";
            this.QCName.ReadOnly = true;
            this.QCName.Width = 97;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "检核文件名称";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 104;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.HeaderText = "检核时间";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GPSIntegrity
            // 
            this.GPSIntegrity.HeaderText = "GPS数据完整率";
            this.GPSIntegrity.MinimumWidth = 6;
            this.GPSIntegrity.Name = "GPSIntegrity";
            this.GPSIntegrity.ReadOnly = true;
            this.GPSIntegrity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GPSIntegrity.Width = 118;
            // 
            // BDSIntegrity
            // 
            this.BDSIntegrity.HeaderText = "BDS数据完整率";
            this.BDSIntegrity.MinimumWidth = 6;
            this.BDSIntegrity.Name = "BDSIntegrity";
            this.BDSIntegrity.ReadOnly = true;
            this.BDSIntegrity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BDSIntegrity.Width = 118;
            // 
            // CycleSlipRatio
            // 
            this.CycleSlipRatio.HeaderText = "无周跳比";
            this.CycleSlipRatio.MinimumWidth = 6;
            this.CycleSlipRatio.Name = "CycleSlipRatio";
            this.CycleSlipRatio.ReadOnly = true;
            this.CycleSlipRatio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CycleSlipRatio.Width = 74;
            // 
            // L1OrB1MPRMS
            // 
            this.L1OrB1MPRMS.HeaderText = "F1 MPRMS";
            this.L1OrB1MPRMS.MinimumWidth = 6;
            this.L1OrB1MPRMS.Name = "L1OrB1MPRMS";
            this.L1OrB1MPRMS.ReadOnly = true;
            this.L1OrB1MPRMS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.L1OrB1MPRMS.Width = 93;
            // 
            // L2OrB2MPRMS
            // 
            this.L2OrB2MPRMS.HeaderText = "F2 MPRMS";
            this.L2OrB2MPRMS.MinimumWidth = 6;
            this.L2OrB2MPRMS.Name = "L2OrB2MPRMS";
            this.L2OrB2MPRMS.ReadOnly = true;
            this.L2OrB2MPRMS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.L2OrB2MPRMS.Width = 93;
            // 
            // integrityPage
            // 
            this.integrityPage.BackColor = System.Drawing.Color.Transparent;
            this.integrityPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integrityPage.Controls.Add(this.splitContainer5);
            this.integrityPage.Location = new System.Drawing.Point(4, 29);
            this.integrityPage.Name = "integrityPage";
            this.integrityPage.Padding = new System.Windows.Forms.Padding(3);
            this.integrityPage.Size = new System.Drawing.Size(793, 418);
            this.integrityPage.TabIndex = 1;
            this.integrityPage.Text = "数据完整度";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer5.Panel1.Controls.Add(this.integrityChart);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.integrityGrid);
            this.splitContainer5.Size = new System.Drawing.Size(785, 410);
            this.splitContainer5.SplitterDistance = 250;
            this.splitContainer5.TabIndex = 1;
            // 
            // integrityChart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.integrityChart.ChartAreas.Add(chartArea1);
            this.integrityChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.integrityChart.Legends.Add(legend1);
            this.integrityChart.Location = new System.Drawing.Point(0, 0);
            this.integrityChart.Name = "integrityChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.Name = "All";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "L1/B1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series3.Legend = "Legend1";
            series3.Name = "L2/B2";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Teal;
            series4.Legend = "Legend1";
            series4.Name = "B3";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.integrityChart.Series.Add(series1);
            this.integrityChart.Series.Add(series2);
            this.integrityChart.Series.Add(series3);
            this.integrityChart.Series.Add(series4);
            this.integrityChart.Size = new System.Drawing.Size(785, 250);
            this.integrityChart.TabIndex = 0;
            this.integrityChart.Text = "chart1";
            // 
            // integrityGrid
            // 
            this.integrityGrid.AllowUserToAddRows = false;
            this.integrityGrid.AllowUserToDeleteRows = false;
            this.integrityGrid.AllowUserToResizeRows = false;
            this.integrityGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.integrityGrid.BackgroundColor = System.Drawing.Color.White;
            this.integrityGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.integrityGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.integrityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.integrityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Integrity1,
            this.Integrity2,
            this.Integrity3,
            this.All,
            this.Theoretical});
            this.integrityGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.integrityGrid.EnableHeadersVisualStyles = false;
            this.integrityGrid.Location = new System.Drawing.Point(0, 0);
            this.integrityGrid.Name = "integrityGrid";
            this.integrityGrid.ReadOnly = true;
            this.integrityGrid.RowHeadersVisible = false;
            this.integrityGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            this.integrityGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.integrityGrid.RowTemplate.Height = 27;
            this.integrityGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.integrityGrid.Size = new System.Drawing.Size(785, 156);
            this.integrityGrid.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "卫星号";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Integrity1
            // 
            this.Integrity1.HeaderText = "L1/B1实际观测数";
            this.Integrity1.MinimumWidth = 6;
            this.Integrity1.Name = "Integrity1";
            this.Integrity1.ReadOnly = true;
            // 
            // Integrity2
            // 
            this.Integrity2.HeaderText = "L2/B2实际观测数";
            this.Integrity2.MinimumWidth = 6;
            this.Integrity2.Name = "Integrity2";
            this.Integrity2.ReadOnly = true;
            // 
            // Integrity3
            // 
            this.Integrity3.HeaderText = "B3实际观测数";
            this.Integrity3.MinimumWidth = 6;
            this.Integrity3.Name = "Integrity3";
            this.Integrity3.ReadOnly = true;
            // 
            // All
            // 
            this.All.HeaderText = "All实际观测数";
            this.All.MinimumWidth = 6;
            this.All.Name = "All";
            this.All.ReadOnly = true;
            // 
            // Theoretical
            // 
            this.Theoretical.HeaderText = "理论观测数";
            this.Theoretical.MinimumWidth = 6;
            this.Theoretical.Name = "Theoretical";
            this.Theoretical.ReadOnly = true;
            // 
            // slipPage
            // 
            this.slipPage.BackColor = System.Drawing.Color.Transparent;
            this.slipPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slipPage.Controls.Add(this.splitContainer6);
            this.slipPage.Location = new System.Drawing.Point(4, 29);
            this.slipPage.Name = "slipPage";
            this.slipPage.Padding = new System.Windows.Forms.Padding(3);
            this.slipPage.Size = new System.Drawing.Size(793, 418);
            this.slipPage.TabIndex = 2;
            this.slipPage.Text = "周跳探测";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.slipGridView);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.slipGrid);
            this.splitContainer6.Size = new System.Drawing.Size(785, 410);
            this.splitContainer6.SplitterDistance = 250;
            this.splitContainer6.TabIndex = 0;
            // 
            // slipGridView
            // 
            this.slipGridView.AllowUserToAddRows = false;
            this.slipGridView.AllowUserToDeleteRows = false;
            this.slipGridView.AllowUserToResizeRows = false;
            this.slipGridView.BackgroundColor = System.Drawing.Color.White;
            this.slipGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.slipGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slipGridView.Location = new System.Drawing.Point(0, 0);
            this.slipGridView.Name = "slipGridView";
            this.slipGridView.ReadOnly = true;
            this.slipGridView.RowHeadersVisible = false;
            this.slipGridView.RowHeadersWidth = 51;
            this.slipGridView.RowTemplate.Height = 27;
            this.slipGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.slipGridView.Size = new System.Drawing.Size(785, 250);
            this.slipGridView.TabIndex = 2;
            this.slipGridView.SelectionChanged += new System.EventHandler(this.slipGridView_SelectionChanged);
            // 
            // slipGrid
            // 
            this.slipGrid.AllowUserToAddRows = false;
            this.slipGrid.AllowUserToDeleteRows = false;
            this.slipGrid.AllowUserToResizeRows = false;
            this.slipGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.slipGrid.BackgroundColor = System.Drawing.Color.White;
            this.slipGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.slipGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.slipGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.slipGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.validObsNum,
            this.Slip,
            this.NCSR});
            this.slipGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slipGrid.EnableHeadersVisualStyles = false;
            this.slipGrid.Location = new System.Drawing.Point(0, 0);
            this.slipGrid.Name = "slipGrid";
            this.slipGrid.ReadOnly = true;
            this.slipGrid.RowHeadersVisible = false;
            this.slipGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            this.slipGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.slipGrid.RowTemplate.Height = 27;
            this.slipGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.slipGrid.Size = new System.Drawing.Size(785, 156);
            this.slipGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "卫星号";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // validObsNum
            // 
            this.validObsNum.HeaderText = "有效双频观测数";
            this.validObsNum.MinimumWidth = 6;
            this.validObsNum.Name = "validObsNum";
            this.validObsNum.ReadOnly = true;
            // 
            // Slip
            // 
            this.Slip.HeaderText = "周跳数";
            this.Slip.MinimumWidth = 6;
            this.Slip.Name = "Slip";
            this.Slip.ReadOnly = true;
            // 
            // NCSR
            // 
            this.NCSR.HeaderText = "无周跳比";
            this.NCSR.MinimumWidth = 6;
            this.NCSR.Name = "NCSR";
            this.NCSR.ReadOnly = true;
            // 
            // multipathPage
            // 
            this.multipathPage.BackColor = System.Drawing.Color.Transparent;
            this.multipathPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multipathPage.Controls.Add(this.splitContainer7);
            this.multipathPage.Location = new System.Drawing.Point(4, 29);
            this.multipathPage.Name = "multipathPage";
            this.multipathPage.Padding = new System.Windows.Forms.Padding(3);
            this.multipathPage.Size = new System.Drawing.Size(793, 418);
            this.multipathPage.TabIndex = 3;
            this.multipathPage.Text = "多路径效应";
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.filterBtn);
            this.splitContainer7.Panel1.Controls.Add(this.filter);
            this.splitContainer7.Panel1.Controls.Add(this.multipathChart);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.multipathGrid);
            this.splitContainer7.Size = new System.Drawing.Size(785, 410);
            this.splitContainer7.SplitterDistance = 250;
            this.splitContainer7.TabIndex = 0;
            // 
            // filterBtn
            // 
            this.filterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBtn.Location = new System.Drawing.Point(666, 3);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(116, 36);
            this.filterBtn.TabIndex = 3;
            this.filterBtn.Text = "反选";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // filter
            // 
            this.filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filter.CheckOnClick = true;
            this.filter.FormattingEnabled = true;
            this.filter.Location = new System.Drawing.Point(663, 45);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(119, 202);
            this.filter.TabIndex = 2;
            this.filter.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filter_ItemCheck);
            // 
            // multipathChart
            // 
            this.multipathChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            chartArea2.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea2.AxisX.ScrollBar.Size = 20D;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            chartArea2.AxisY.ScrollBar.IsPositionedInside = false;
            chartArea2.AxisY.ScrollBar.Size = 20D;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.LineColor = System.Drawing.Color.HotPink;
            chartArea2.CursorX.SelectionColor = System.Drawing.Color.Gray;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.CursorY.LineColor = System.Drawing.Color.HotPink;
            chartArea2.CursorY.SelectionColor = System.Drawing.Color.Gray;
            chartArea2.Name = "ChartArea1";
            this.multipathChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.multipathChart.Legends.Add(legend2);
            this.multipathChart.Location = new System.Drawing.Point(0, 0);
            this.multipathChart.Name = "multipathChart";
            this.multipathChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.multipathChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))))};
            this.multipathChart.Size = new System.Drawing.Size(660, 250);
            this.multipathChart.TabIndex = 0;
            this.multipathChart.Text = "chart1";
            // 
            // multipathGrid
            // 
            this.multipathGrid.AllowUserToAddRows = false;
            this.multipathGrid.AllowUserToDeleteRows = false;
            this.multipathGrid.AllowUserToResizeRows = false;
            this.multipathGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.multipathGrid.BackgroundColor = System.Drawing.Color.White;
            this.multipathGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.multipathGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.multipathGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.multipathGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.multipathGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multipathGrid.EnableHeadersVisualStyles = false;
            this.multipathGrid.Location = new System.Drawing.Point(0, 0);
            this.multipathGrid.Name = "multipathGrid";
            this.multipathGrid.ReadOnly = true;
            this.multipathGrid.RowHeadersVisible = false;
            this.multipathGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            this.multipathGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.multipathGrid.RowTemplate.Height = 27;
            this.multipathGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.multipathGrid.Size = new System.Drawing.Size(785, 156);
            this.multipathGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "卫星号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "MP1 RMS ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "MP2 RMS";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.logBtn);
            this.groupBox3.Controls.Add(this.logBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(801, 130);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出";
            // 
            // logBtn
            // 
            this.logBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.logBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logBtn.Location = new System.Drawing.Point(754, 23);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(44, 104);
            this.logBtn.TabIndex = 1;
            this.logBtn.Text = "清空";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.BackColor = System.Drawing.Color.White;
            this.logBox.ForeColor = System.Drawing.Color.Black;
            this.logBox.Location = new System.Drawing.Point(3, 23);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(745, 104);
            this.logBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.propertyLb);
            this.groupBox2.Controls.Add(this.splitContainer3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 585);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "属性";
            // 
            // propertyLb
            // 
            this.propertyLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.propertyLb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.propertyLb.ForeColor = System.Drawing.Color.White;
            this.propertyLb.Location = new System.Drawing.Point(3, 23);
            this.propertyLb.Name = "propertyLb";
            this.propertyLb.Size = new System.Drawing.Size(150, 27);
            this.propertyLb.TabIndex = 1;
            this.propertyLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Location = new System.Drawing.Point(3, 53);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.propertyGrid);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.propertyBox);
            this.splitContainer3.Size = new System.Drawing.Size(151, 532);
            this.splitContainer3.SplitterDistance = 405;
            this.splitContainer3.TabIndex = 1;
            // 
            // propertyGrid
            // 
            this.propertyGrid.AllowUserToAddRows = false;
            this.propertyGrid.AllowUserToDeleteRows = false;
            this.propertyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.propertyGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.propertyGrid.BackgroundColor = System.Drawing.Color.White;
            this.propertyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyGrid.ColumnHeadersVisible = false;
            this.propertyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Property,
            this.Value});
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.MultiSelect = false;
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.ReadOnly = true;
            this.propertyGrid.RowHeadersVisible = false;
            this.propertyGrid.RowHeadersWidth = 51;
            this.propertyGrid.RowTemplate.Height = 27;
            this.propertyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.propertyGrid.ShowCellErrors = false;
            this.propertyGrid.ShowEditingIcon = false;
            this.propertyGrid.ShowRowErrors = false;
            this.propertyGrid.Size = new System.Drawing.Size(149, 403);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.SelectionChanged += new System.EventHandler(this.propertyGrid_SelectionChanged);
            // 
            // Property
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Teal;
            this.Property.DefaultCellStyle = dataGridViewCellStyle11;
            this.Property.HeaderText = "属性";
            this.Property.MinimumWidth = 6;
            this.Property.Name = "Property";
            this.Property.ReadOnly = true;
            // 
            // Value
            // 
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            this.Value.DefaultCellStyle = dataGridViewCellStyle12;
            this.Value.HeaderText = "值";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // propertyBox
            // 
            this.propertyBox.BackColor = System.Drawing.Color.White;
            this.propertyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyBox.Location = new System.Drawing.Point(0, 0);
            this.propertyBox.Multiline = true;
            this.propertyBox.Name = "propertyBox";
            this.propertyBox.ReadOnly = true;
            this.propertyBox.Size = new System.Drawing.Size(149, 121);
            this.propertyBox.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStrip.BackgroundImage = global::ZTCNAVI.Properties.Resources.ToolStripBG;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入toolStripButton,
            this.导出StripButton,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.删除toolStripButton,
            this.toolStripSeparator2,
            this.上一个toolStripButton,
            this.下一个toolStripButton,
            this.toolStripSeparator3,
            this.向左翻页toolStripButton,
            this.向右翻页toolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 45);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1182, 36);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // 导入toolStripButton
            // 
            this.导入toolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.导入toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("导入toolStripButton.Image")));
            this.导入toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.导入toolStripButton.Name = "导入toolStripButton";
            this.导入toolStripButton.Size = new System.Drawing.Size(63, 33);
            this.导入toolStripButton.Text = "导入";
            this.导入toolStripButton.Click += new System.EventHandler(this.导入ToolStripMenuItem_Click);
            // 
            // 导出StripButton
            // 
            this.导出StripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.导出StripButton.Image = ((System.Drawing.Image)(resources.GetObject("导出StripButton.Image")));
            this.导出StripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.导出StripButton.Name = "导出StripButton";
            this.导出StripButton.Size = new System.Drawing.Size(63, 33);
            this.导出StripButton.Text = "导出";
            this.导出StripButton.Click += new System.EventHandler(this.导出StripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部检核toolStripMenuItem,
            this.检核选中文件MenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(73, 33);
            this.toolStripDropDownButton1.Text = "检核";
            // 
            // 全部检核toolStripMenuItem
            // 
            this.全部检核toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("全部检核toolStripMenuItem.Image")));
            this.全部检核toolStripMenuItem.Name = "全部检核toolStripMenuItem";
            this.全部检核toolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.全部检核toolStripMenuItem.Text = "全部检核";
            this.全部检核toolStripMenuItem.Click += new System.EventHandler(this.全部检核toolStripMenuItem_Click);
            // 
            // 检核选中文件MenuItem
            // 
            this.检核选中文件MenuItem.Image = ((System.Drawing.Image)(resources.GetObject("检核选中文件MenuItem.Image")));
            this.检核选中文件MenuItem.Name = "检核选中文件MenuItem";
            this.检核选中文件MenuItem.Size = new System.Drawing.Size(182, 26);
            this.检核选中文件MenuItem.Text = "检核选中文件";
            this.检核选中文件MenuItem.Click += new System.EventHandler(this.检核选中文件MenuItem_Click);
            // 
            // 删除toolStripButton
            // 
            this.删除toolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.删除toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("删除toolStripButton.Image")));
            this.删除toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.删除toolStripButton.Name = "删除toolStripButton";
            this.删除toolStripButton.Size = new System.Drawing.Size(63, 33);
            this.删除toolStripButton.Text = "删除";
            this.删除toolStripButton.Click += new System.EventHandler(this.删除toolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // 上一个toolStripButton
            // 
            this.上一个toolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.上一个toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("上一个toolStripButton.Image")));
            this.上一个toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.上一个toolStripButton.Name = "上一个toolStripButton";
            this.上一个toolStripButton.Size = new System.Drawing.Size(108, 33);
            this.上一个toolStripButton.Text = "上一个文件";
            this.上一个toolStripButton.Click += new System.EventHandler(this.上一个toolStripButton_Click);
            // 
            // 下一个toolStripButton
            // 
            this.下一个toolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.下一个toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("下一个toolStripButton.Image")));
            this.下一个toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.下一个toolStripButton.Name = "下一个toolStripButton";
            this.下一个toolStripButton.Size = new System.Drawing.Size(108, 33);
            this.下一个toolStripButton.Text = "下一个文件";
            this.下一个toolStripButton.Click += new System.EventHandler(this.下一个toolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // 向左翻页toolStripButton
            // 
            this.向左翻页toolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.向左翻页toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("向左翻页toolStripButton.Image")));
            this.向左翻页toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.向左翻页toolStripButton.Name = "向左翻页toolStripButton";
            this.向左翻页toolStripButton.Size = new System.Drawing.Size(93, 33);
            this.向左翻页toolStripButton.Text = "向左翻页";
            this.向左翻页toolStripButton.Click += new System.EventHandler(this.向左翻页toolStripButton_Click);
            // 
            // 向右翻页toolStripButton
            // 
            this.向右翻页toolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.向右翻页toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("向右翻页toolStripButton.Image")));
            this.向右翻页toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.向右翻页toolStripButton.Name = "向右翻页toolStripButton";
            this.向右翻页toolStripButton.Size = new System.Drawing.Size(93, 33);
            this.向右翻页toolStripButton.Text = "向右翻页";
            this.向右翻页toolStripButton.Click += new System.EventHandler(this.向右翻页toolStripButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(57)))), ((int)(((byte)(197)))), ((int)(((byte)(187)))));
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.选项ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(45, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(400, 42);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.导出质检报告ToolStripMenuItem});
            this.文件FToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.文件FToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("文件FToolStripMenuItem.Image")));
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.文件FToolStripMenuItem.Text = "文件";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.导入ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导入ToolStripMenuItem.Image")));
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.导入ToolStripMenuItem.Text = "导入RINEX观测文件";
            this.导入ToolStripMenuItem.Click += new System.EventHandler(this.导入ToolStripMenuItem_Click);
            // 
            // 导出质检报告ToolStripMenuItem
            // 
            this.导出质检报告ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.导出质检报告ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导出质检报告ToolStripMenuItem.Image")));
            this.导出质检报告ToolStripMenuItem.Name = "导出质检报告ToolStripMenuItem";
            this.导出质检报告ToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.导出质检报告ToolStripMenuItem.Text = "导出质检报告";
            this.导出质检报告ToolStripMenuItem.Click += new System.EventHandler(this.导出StripButton_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入的文件ToolStripMenuItem,
            this.质检报告ToolStripMenuItem,
            this.数据完整度ToolStripMenuItem,
            this.周跳探测ToolStripMenuItem,
            this.多路径效应ToolStripMenuItem,
            this.toolStripSeparator4,
            this.导航toolStripMenuItem,
            this.属性栏ToolStripMenuItem,
            this.输出栏ToolStripMenuItem});
            this.视图ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.视图ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("视图ToolStripMenuItem.Image")));
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 导入的文件ToolStripMenuItem
            // 
            this.导入的文件ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导入的文件ToolStripMenuItem.Image")));
            this.导入的文件ToolStripMenuItem.Name = "导入的文件ToolStripMenuItem";
            this.导入的文件ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.导入的文件ToolStripMenuItem.Text = "导入的文件";
            this.导入的文件ToolStripMenuItem.Click += new System.EventHandler(this.导入的文件ToolStripMenuItem_Click);
            // 
            // 质检报告ToolStripMenuItem
            // 
            this.质检报告ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("质检报告ToolStripMenuItem.Image")));
            this.质检报告ToolStripMenuItem.Name = "质检报告ToolStripMenuItem";
            this.质检报告ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.质检报告ToolStripMenuItem.Text = "质检报告";
            this.质检报告ToolStripMenuItem.Click += new System.EventHandler(this.质检报告ToolStripMenuItem_Click);
            // 
            // 数据完整度ToolStripMenuItem
            // 
            this.数据完整度ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("数据完整度ToolStripMenuItem.Image")));
            this.数据完整度ToolStripMenuItem.Name = "数据完整度ToolStripMenuItem";
            this.数据完整度ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.数据完整度ToolStripMenuItem.Text = "数据完整度";
            this.数据完整度ToolStripMenuItem.Click += new System.EventHandler(this.数据完整度ToolStripMenuItem_Click);
            // 
            // 周跳探测ToolStripMenuItem
            // 
            this.周跳探测ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("周跳探测ToolStripMenuItem.Image")));
            this.周跳探测ToolStripMenuItem.Name = "周跳探测ToolStripMenuItem";
            this.周跳探测ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.周跳探测ToolStripMenuItem.Text = "周跳探测";
            this.周跳探测ToolStripMenuItem.Click += new System.EventHandler(this.周跳探测ToolStripMenuItem_Click);
            // 
            // 多路径效应ToolStripMenuItem
            // 
            this.多路径效应ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("多路径效应ToolStripMenuItem.Image")));
            this.多路径效应ToolStripMenuItem.Name = "多路径效应ToolStripMenuItem";
            this.多路径效应ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.多路径效应ToolStripMenuItem.Text = "多路径效应";
            this.多路径效应ToolStripMenuItem.Click += new System.EventHandler(this.多路径效应ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(164, 6);
            // 
            // 导航toolStripMenuItem
            // 
            this.导航toolStripMenuItem.Checked = true;
            this.导航toolStripMenuItem.CheckOnClick = true;
            this.导航toolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.导航toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导航toolStripMenuItem.Image")));
            this.导航toolStripMenuItem.Name = "导航toolStripMenuItem";
            this.导航toolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.导航toolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.导航toolStripMenuItem.Text = "导航栏";
            this.导航toolStripMenuItem.Click += new System.EventHandler(this.导航toolStripMenuItem_Click);
            // 
            // 属性栏ToolStripMenuItem
            // 
            this.属性栏ToolStripMenuItem.Checked = true;
            this.属性栏ToolStripMenuItem.CheckOnClick = true;
            this.属性栏ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.属性栏ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("属性栏ToolStripMenuItem.Image")));
            this.属性栏ToolStripMenuItem.Name = "属性栏ToolStripMenuItem";
            this.属性栏ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.属性栏ToolStripMenuItem.Text = "属性栏";
            this.属性栏ToolStripMenuItem.Click += new System.EventHandler(this.属性栏ToolStripMenuItem_Click);
            // 
            // 输出栏ToolStripMenuItem
            // 
            this.输出栏ToolStripMenuItem.Checked = true;
            this.输出栏ToolStripMenuItem.CheckOnClick = true;
            this.输出栏ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.输出栏ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("输出栏ToolStripMenuItem.Image")));
            this.输出栏ToolStripMenuItem.Name = "输出栏ToolStripMenuItem";
            this.输出栏ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.输出栏ToolStripMenuItem.Text = "输出栏";
            this.输出栏ToolStripMenuItem.Click += new System.EventHandler(this.输出栏ToolStripMenuItem_Click);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启用B1B3双频观测值ToolStripMenuItem});
            this.选项ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.选项ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("选项ToolStripMenuItem.Image")));
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 启用B1B3双频观测值ToolStripMenuItem
            // 
            this.启用B1B3双频观测值ToolStripMenuItem.CheckOnClick = true;
            this.启用B1B3双频观测值ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("启用B1B3双频观测值ToolStripMenuItem.Image")));
            this.启用B1B3双频观测值ToolStripMenuItem.Name = "启用B1B3双频观测值ToolStripMenuItem";
            this.启用B1B3双频观测值ToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.启用B1B3双频观测值ToolStripMenuItem.Text = "启用B1+B3双频观测值";
            this.启用B1B3双频观测值ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.启用B1B3双频观测值ToolStripMenuItem_CheckedChanged);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.帮助ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("帮助ToolStripMenuItem.Image")));
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.关于ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关于ToolStripMenuItem.Image")));
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 42);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(1082, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 42);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(42, 42);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 742);
            this.Name = "MainForm";
            this.Text = "ZTCNAVI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.inputFilePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputFileGrid)).EndInit();
            this.qualityCheckPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qualityCheckGrid)).EndInit();
            this.integrityPage.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integrityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrityGrid)).EndInit();
            this.slipPage.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slipGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slipGrid)).EndInit();
            this.multipathPage.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.multipathChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multipathGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView naviPanel;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inputFilePage;
        private System.Windows.Forms.TabPage integrityPage;
        private System.Windows.Forms.DataGridView inputFileGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataVisualization.Charting.Chart integrityChart;
        private System.Windows.Forms.DataGridView integrityGrid;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton 导入toolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 全部检核toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检核选中文件MenuItem;
        private System.Windows.Forms.DataGridView propertyGrid;
        private System.Windows.Forms.TabPage slipPage;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.DataGridView slipGridView;
        private System.Windows.Forms.TabPage multipathPage;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.DataVisualization.Charting.Chart multipathChart;
        private System.Windows.Forms.DataGridView multipathGrid;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TabPage qualityCheckPage;
        private System.Windows.Forms.DataGridView qualityCheckGrid;
        private System.Windows.Forms.Label propertyLb;
        private System.Windows.Forms.TextBox propertyBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridView slipGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn validObsNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slip;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integrity1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integrity2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integrity3;
        private System.Windows.Forms.DataGridViewTextBoxColumn All;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theoretical;
        private System.Windows.Forms.ToolStripButton 删除toolStripButton;
        private System.Windows.Forms.ToolStripButton 上一个toolStripButton;
        private System.Windows.Forms.ToolStripButton 下一个toolStripButton;
        private System.Windows.Forms.ToolStripButton 向左翻页toolStripButton;
        private System.Windows.Forms.ToolStripButton 向右翻页toolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 导入的文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 质检报告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据完整度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 周跳探测ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多路径效应ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 导出质检报告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启用B1B3双频观测值ToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn QCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPSIntegrity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDSIntegrity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CycleSlipRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn L1OrB1MPRMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn L2OrB2MPRMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton 导出StripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 导航toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输出栏ToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox filter;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

