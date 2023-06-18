using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZTCNAVI
{
    public partial class MainForm : Form
    {
        private bool _needToShow = true;
        private List<RinexFileQualityCheck> _selectedRinexFileQualityChecks = new List<RinexFileQualityCheck>();
        private List<RinexFile> _selectedRinexFiles = new List<RinexFile>();
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }

        private enum LogType
        {
            INFO,
            WARN,
            ERROR
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void AddLog(LogType logType, string log)
        {
            logBox.Text = $"[{logType}]:{log}" + Environment.NewLine + logBox.Text;
        }

        private void AddProperty(string name, string value)
        {
            propertyGrid.Rows.Add(name, value);
        }

        private void ClearIntegrityPage()
        {
            integrityGrid.Rows.Clear();
            foreach (Series series in integrityChart.Series)
            {
                series.Points.Clear();
            }
        }

        private void ClearMultipathPage()
        {
            multipathGrid.Rows.Clear();
            multipathChart.Series.Clear();
            filter.Items.Clear();
        }

        private void ClearProperties()
        {
            propertyLb.Text = "";
            propertyBox.Clear();
            propertyGrid.Rows.Clear();
        }

        private void ClearSlipPage()
        {
            slipGridView.Rows.Clear();
            slipGridView.Columns.Clear();
            slipGrid.Rows.Clear();
        }

        private void Delete(RinexFile rF)
        {
            Invoke(new Action(() =>
            {
                for (int i = inputFileGrid.Rows.Count - 1; i > -1; i--)
                {
                    if (inputFileGrid.Rows[i].Cells[0].Value.ToString() == rF.FileName)
                    {
                        inputFileGrid.Rows.RemoveAt(i);
                        naviPanel.Nodes[0].Nodes.RemoveAt(i);
                        break;
                    }
                }
            }));
            Data.Delete(rF);
        }

        private void Delete(RinexFileQualityCheck qc)
        {
            Invoke(new Action(() =>
            {
                for (int i = qualityCheckGrid.Rows.Count - 1; i > -1; i--)
                {
                    if (qualityCheckGrid.Rows[i].Cells[0].Value.ToString() == qc.FileName)
                    {
                        qualityCheckGrid.Rows.RemoveAt(i);
                        naviPanel.Nodes[1].Nodes.RemoveAt(i);
                        return;
                    }
                }
            }));
            Data.Delete(qc);
        }

        private void filter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Unchecked)
            {
                multipathChart.Series[e.Index].Enabled = true;
                e.NewValue = CheckState.Checked;
            }
            else
            {
                multipathChart.Series[e.Index].Enabled = false;
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            if (filterBtn.Text == "反选")
            {
                for (int i = 0; i < filter.Items.Count; i++)
                {
                    if (filter.GetItemChecked(i))
                    {
                        filter.SetItemChecked(i, false);
                    }
                    else
                    {
                        filter.SetItemChecked(i, true);
                    }
                }
                filter.ClearSelected();
                filterBtn.Text = "全选";
            }
            else
            {
                for (int i = 0; i < filter.Items.Count; i++)
                {
                    filter.SetItemChecked(i, true);
                }
                filterBtn.Text = "反选";
            }
        }

        private void inputFileGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_selectedRinexFiles.Count>0)
            {
                naviPanel.SelectedNode = naviPanel.Nodes[0].Nodes[Data.IndexOf(_selectedRinexFiles[0])];
            }            
        }

        private void inputFileGrid_SelectionChanged(object sender, EventArgs e)
        {
            ClearProperties();
            SetSelectedRinexFileIndexes();
            if (inputFileGrid.SelectedRows.Count > 0)
            {
                if (inputFileGrid.SelectedRows.Count > 1)
                {
                    //多选
                    propertyLb.Text = "选中多个文件";
                }
                else
                {
                    ShowInputFileProperty();
                }
            }
            else
            {
                //未选
            }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            logBox.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MainFormBG;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Opacity = 0.95;
        }

        private void naviPanel_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (naviPanel.SelectedNode == e.Node)
            {
                return;
            }
            TreeNode node = e.Node;
            naviPanel.SelectedNode = node;
            if (node.Parent == naviPanel.Nodes[0])
            {
                tabControl.SelectedTab = inputFilePage;
                inputFileGrid.ClearSelection();
                inputFileGrid.Rows[node.Index].Selected = true;
            }
            if (node.Parent == naviPanel.Nodes[1])
            {
                if (tabControl.SelectedTab == inputFilePage)
                {
                    _needToShow = false;
                    tabControl.SelectedTab = qualityCheckPage;
                    logBox.Select(0, 0);
                }
                qualityCheckGrid.ClearSelection();
                _needToShow = true;
                qualityCheckGrid.Rows[node.Index].Selected = true;
            }
        }

        private void propertyGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (propertyGrid.SelectedRows.Count > 0)
            {
                var row = propertyGrid.SelectedRows[0];
                string name = row.Cells[0].Value.ToString();
                string value = row.Cells[1].Value.ToString();
                propertyBox.Clear();
                propertyBox.AppendText($"{name}:" + Environment.NewLine + value);
            }
        }

        private void qualityCheckGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_selectedRinexFileQualityChecks.Count>0)
            {
                naviPanel.SelectedNode = naviPanel.Nodes[1].Nodes[Data.IndexOf(_selectedRinexFileQualityChecks[0])];
            }            
        }

        private void qualityCheckGrid_SelectionChanged(object sender, EventArgs e)
        {
            SetSelectedRinexFileQualityCheckIndexes();
            ClearProperties();
            ClearIntegrityPage();
            ClearSlipPage();
            ClearMultipathPage();
            if (qualityCheckGrid.SelectedRows.Count > 0)
            {
                if (qualityCheckGrid.SelectedRows.Count > 1)
                {
                    //多选
                    propertyLb.Text = "选中多个文件";
                }
                else
                {
                    if (_needToShow)
                    {
                        ShowQualityCheckProperty();
                        var integrityThread = new Thread(ShowIntegrityPage);
                        var slipThread = new Thread(ShowSlipPage);
                        var multipathThread = new Thread(ShowMultipathPage);
                        naviPanel.Enabled = false;
                        qualityCheckGrid.Enabled = false;
                        toolStrip.Enabled = false;
                        menuStrip.Enabled = false;
                        filter.Enabled = false;
                        filterBtn.Enabled = false;
                        integrityThread.Start();
                        slipThread.Start();
                        multipathThread.Start();
                    }
                }
            }
            else
            {
                //未选
            }
        }

        private void SetSelectedRinexFileIndexes()
        {
            _selectedRinexFiles.Clear();
            foreach (DataGridViewRow row in inputFileGrid.SelectedRows)
            {
                _selectedRinexFiles.Add(Data.RinexFiles[row.Index]);
            }
        }

        private void SetSelectedRinexFileQualityCheckIndexes()
        {
            _selectedRinexFileQualityChecks.Clear();
            foreach (DataGridViewRow row in qualityCheckGrid.SelectedRows)
            {
                _selectedRinexFileQualityChecks.Add(Data.RinexFileQualityChecks[row.Index]);
            }
        }

        private void ShowInputFileProperty()
        {
            propertyLb.Text = _selectedRinexFiles[0].FileName;
            DataGridViewRow row = inputFileGrid.SelectedRows[0];
            for (int i = 0; i < inputFileGrid.Columns.Count; i++)
            {
                AddProperty(inputFileGrid.Columns[i].HeaderText, row.Cells[i].Value.ToString());
            }
        }

        private void ShowIntegrityPage()
        {
            RinexFileQualityCheck qc = _selectedRinexFileQualityChecks[0];
            DataIntegrityOfSatellite[] dIs = qc.DataIntegrityOfSatellites;
            Invoke(new Action(() =>
            {
                for (int i = 0; i < dIs.Length; i++)
                {
                    DataIntegrityOfSatellite dI = dIs[i];
                    float i1 = (float)dI.ActualEpochCountAtL1OrB1 / dI.TheoreticalEpochCount;
                    float i2 = (float)dI.ActualEpochCountAtL2OrB2 / dI.TheoreticalEpochCount;
                    float iA = (float)dI.ActualEpochAtAll / dI.TheoreticalEpochCount;
                    float i3 = (float)dI.ActualEpochCountAtB3 / dI.TheoreticalEpochCount;
                    integrityGrid.Rows.Add(dI.PRN, dI.ActualEpochCountAtL1OrB1, dI.ActualEpochCountAtL2OrB2, dI.ActualEpochCountAtB3, dI.ActualEpochAtAll, dI.TheoreticalEpochCount);
                    integrityChart.Series[0].Points.AddXY(dI.PRN, iA);
                    integrityChart.Series[1].Points.AddXY(dI.PRN, i1);
                    integrityChart.Series[2].Points.AddXY(dI.PRN, i2);
                    integrityChart.Series[3].Points.AddXY(dI.PRN, i3);
                }
            }));
        }

        private void ShowMultipathPage()
        {
            RinexFileQualityCheck qc = _selectedRinexFileQualityChecks[0];
            int epochNum = qc.RinexFile.FileDataRecord.Count;
            int prnNum = qc.RinexFile.PrnsOfGPSAndBDS.Count;
            for (int prnIndex = 0; prnIndex < prnNum; prnIndex++)
            {
                string prn = qc.RinexFile.PrnsOfGPSAndBDS[prnIndex];
                var s1 = new Series($"{prn}:MP1");
                var s2 = new Series($"{prn}:MP2");
                s1.ChartType = SeriesChartType.FastLine;
                s2.ChartType = SeriesChartType.FastLine;
                for (int epochIndex = 0; epochIndex < epochNum; epochIndex++)
                {
                    var t = qc.RinexFile.FileDataRecord[epochIndex].DateTime.ToLongTimeString();
                    s1.Points.AddXY(t, qc.MultipathsAtF1[epochIndex, prnIndex]);
                    s2.Points.AddXY(t, qc.MultipathsAtF2[epochIndex, prnIndex]);
                }
                float mp1 = qc.MultipathRMSOfSatellitesAtF1[prnIndex];
                float mp2 = qc.MultipathRMSOfSatellitesAtF2[prnIndex];
                Invoke(new Action(() =>
                {
                    multipathGrid.Rows.Add(prn, mp1, mp2);
                    multipathChart.Series.Add(s1);
                    multipathChart.Series.Add(s2);
                    filter.Items.Add($"{prn}:MP1");
                    filter.SetItemChecked(filter.Items.Count - 1, true);
                    filter.Items.Add($"{prn}:MP2");
                    filter.SetItemChecked(filter.Items.Count - 1, true);
                }));
            }

            Invoke(new Action(() =>
            {
                naviPanel.Enabled = true;
                qualityCheckGrid.Enabled = true;
                toolStrip.Enabled = true;
                menuStrip.Enabled = true;
                filter.Enabled = true;
                filterBtn.Enabled = true;
                filterBtn.Text = "全不选";
                naviPanel.SelectedNode = naviPanel.Nodes[1].Nodes[Data.IndexOf(_selectedRinexFileQualityChecks[0])];
            }));
        }

        private void ShowQualityCheckProperty()
        {
            propertyLb.Text = _selectedRinexFileQualityChecks[0].FileName;
            var row = qualityCheckGrid.SelectedRows[0];
            for (int i = 0; i < qualityCheckGrid.Columns.Count; i++)
            {
                AddProperty(qualityCheckGrid.Columns[i].HeaderText, row.Cells[i].Value.ToString());
            }
        }

        private void ShowSlipPage()
        {
            Invoke(new Action(() =>
            {
                slipGridView.Columns.Add("Time", "历元");
                slipGridView.Columns[slipGridView.Columns.Count - 1].Width = 200;
                RinexFileQualityCheck rinexFileQualityCheck = _selectedRinexFileQualityChecks[0];
                for (int prnIndex = 0; prnIndex < rinexFileQualityCheck.RinexFile.PrnsOfGPSAndBDS.Count; prnIndex++)
                {
                    var sD = rinexFileQualityCheck.SlipDetectionOfSatellites[prnIndex];
                    string prn = sD.PRN;
                    slipGridView.Columns.Add(prn, prn);
                    slipGridView.Columns[slipGridView.Columns.Count - 1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    slipGrid.Rows.Add(sD.PRN, sD.ValidDualFrequencyObservationsCount, sD.SlipCount, sD.NoneSlipRatio);
                }
                for (int i = 0; i < rinexFileQualityCheck.RinexFile.FileDataRecord.Count; i++)
                {
                    slipGridView.Rows.Add();
                    slipGridView.Rows[i].Cells[0].Value = rinexFileQualityCheck.RinexFile.FileDataRecord[i].DateTime.ToString("F");
                    for (int j = 0; j < rinexFileQualityCheck.RinexFile.PrnsOfGPSAndBDS.Count; j++)
                    {
                        int slip = rinexFileQualityCheck.SlipDetectionOfEpochs[i, j];
                        switch (slip)
                        {
                            case 0:
                                slipGridView.Rows[i].Cells[j + 1].Style.BackColor = ColorTranslator.FromHtml("#39c5bb");
                                break;

                            case 1:
                                slipGridView.Rows[i].Cells[j + 1].Style.BackColor = Color.FromKnownColor(KnownColor.HotPink);
                                break;

                            case -1:
                                slipGridView.Rows[i].Cells[j + 1].Style.BackColor = Color.Gray;
                                break;

                            default:
                                break;
                        }
                    }
                }
            }));
        }

        private void slipGridView_SelectionChanged(object sender, EventArgs e)
        {
            slipGridView.ClearSelection();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage page = tabControl.SelectedTab;
            ClearProperties();
            if (page == inputFilePage)
            {
                if (_selectedRinexFiles.Count == 1)
                {
                    ShowInputFileProperty();
                    naviPanel.SelectedNode = naviPanel.Nodes[0].Nodes[Data.IndexOf(_selectedRinexFiles[0])];
                }
            }
            else
            {
                if (_selectedRinexFileQualityChecks.Count == 1)
                {
                    ShowQualityCheckProperty();
                    naviPanel.SelectedNode = naviPanel.Nodes[1].Nodes[Data.IndexOf(_selectedRinexFileQualityChecks[0])];
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            MemoryManagement.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sB = new StringBuilder();
            sB.AppendLine("可一次性读取多个文件,只能读取3.02版本Rinex的O文件，只处理GPS的L1L2和BDS的B1B2B3频点的伪距和相位观测值");
            sB.AppendLine("MW没有平滑处理，阈值为2周，GF阈值为0.05m");
            sB.AppendLine("多路径时序图需要一定时间加载");
            sB.AppendLine("可以导出报告查看详细数据");
            sB.AppendLine("点击顶部菜单栏的文件->导入RINEX观测值文件或工具栏的导入按钮以打开对话框选择文件导入（仅支持3.02），按住Ctrl或Shift可选中多个文件同时导入，下方输出栏可查看日志，右侧属性栏或导入的文件页面可查看选中文件基本信息。");
            sB.AppendLine("点击工具栏检核->全部检核/检核选中文件以开始检核，在质检报告页面可查看整体结果。");
            sB.AppendLine("选中单个质检报告后，可选择数据完整度、周跳探测或多路径效应查看各模块详细结果，绿色代表无周跳，红色代表周跳，灰色代表无观测值");
            sB.AppendLine("其中，表格、统计图、导航栏、输出栏和属性栏的大小均可自由改变。");
            sB.AppendLine("也可以直接点击菜单栏的视图->导航栏 / 属性栏 / 输出栏选择隐藏或显示对应窗口。");
            sB.AppendLine("右侧筛选器可以选择只查看部分卫星MP序列图。");
            sB.AppendLine("对于BDS卫星的周跳探测和多路径效应计算，缺省设置是使用B1 + B2双频观测值。若文件中B2观测值较少，可点击菜单栏的选项->启用B1 + B3双频观测值进行计算。");
            sB.AppendLine(" 点击菜单栏的文件->导出质检报告或工具栏的导出以保存质检报告。");
            AddLog(LogType.INFO, sB.ToString());
        }

        private void 导出StripButton_Click(object sender, EventArgs e)
        {
            if (Data.RinexFileQualityChecks.Count > 0)
            {
                int successNum = 0;
                var dialog = new FolderBrowserDialog();
                dialog.Description = "选择导出位置";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var qc in Data.RinexFileQualityChecks)
                    {
                        try
                        {
                            string filePath = Path.Combine(dialog.SelectedPath, qc.FileName);
                            var sw = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write));
                            sw.Write(qc.ToDocumentText());
                            sw.Dispose();
                            successNum++;
                            AddLog(LogType.INFO, $"{qc.FileName}导出完成");
                        }
                        catch (Exception)
                        {
                            AddLog(LogType.ERROR, $"{qc.FileName}导出失败");
                            continue;
                        }
                    }
                    AddLog(LogType.INFO, $"总计导出{Data.RinexFileQualityChecks.Count}个文件，成功{successNum}个，失败{Data.RinexFileQualityChecks.Count - successNum}个");
                }
            }
            else
            {
                AddLog(LogType.WARN, "无检核报告！");
            }
        }

        private void 导航toolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !导航toolStripMenuItem.Checked;
        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader[] srs = RMM.RMM_FileHelper.ReadFile("导入", "Rinex观测值文件|*.??O", out string[] filePaths);
            if (srs != null)
            {
                naviPanel.Enabled = false;
                toolStrip.Enabled = false;
                menuStrip.Enabled = false;
                int successNum = 0;
                for (int i = 0; i < srs.Length; i++)
                {
                    try
                    {
                        string fileName = Path.GetFileName(filePaths[i]);
                        var rF = Data.RinexFiles.Find(t => t.FileName == fileName);
                        if (rF != null)
                        {
                            if (MessageBox.Show($"{fileName}已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Delete(rF);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        RinexFile rinexFile = new RinexFile(fileName, srs[i]);
                        Data.RinexFiles.Add(rinexFile);
                        string stationName = rinexFile.GetCommentOf("MARKER NAME").Trim();
                        DateTime startTime = RinexFileComment.GetDateTime(rinexFile.GetCommentOf("TIME OF FIRST OBS"), out string startTimeSystemName);
                        DateTime endTime = RinexFileComment.GetDateTime(rinexFile.GetCommentOf("TIME OF LAST OBS"), out string endTimeSystemName);
                        TimeSpan timeSpan = endTime - startTime;
                        Invoke(new Action(() =>
                        {
                            inputFileGrid.Rows.Add(fileName, stationName, $"({startTimeSystemName}){startTime.ToString("F")}", $"({endTimeSystemName}){endTime.ToString("F")}", timeSpan.ToString(), filePaths[i]);
                            naviPanel.Nodes[0].Nodes.Add(fileName, fileName);
                            AddLog(LogType.INFO, $"导入{filePaths[i]}成功");
                        }));
                        successNum++;
                    }
                    catch (Exception)
                    {
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show($"读取{filePaths[i]}失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AddLog(LogType.ERROR, $"导入{filePaths[i]}失败");
                        }));
                        continue;
                    }
                }
                if (successNum != 0)
                {
                    inputFileGrid.ClearSelection();
                    inputFileGrid.Rows[0].Selected = true;
                    naviPanel.SelectedNode = naviPanel.Nodes[0].FirstNode;
                    naviPanel.Nodes[0].Expand();
                }
                AddLog(LogType.INFO, $"总计导入{srs.Length}个文件，成功{successNum}个，失败{srs.Length - successNum}个");
                naviPanel.Enabled = true;
                toolStrip.Enabled = true;
                menuStrip.Enabled = true;
            }
            else
            {
                return;
            }
        }

        private void 导入的文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(inputFilePage);
        }

        private void 多路径效应ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(multipathPage);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("基于.NET Framework 4.8 框架设计，开发环境是Visual Studio 2022");
            sb.AppendLine("作者：周天晨，专业：武汉大学测绘学院导航工程，学号：2020302142257，邮箱：2020302142257@whu.edu.cn");
            AddLog(LogType.INFO, sb.ToString());
        }

        private void 检核选中文件MenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedRinexFiles.Count > 0)
            {
                naviPanel.Enabled = false;
                toolStrip.Enabled = false;
                menuStrip.Enabled = false;
                AddLog(LogType.INFO, "开始检核");

                foreach (RinexFile rF in _selectedRinexFiles)
                {
                    try
                    {
                        ThreadStart threadStart = new ThreadStart(new Action(() =>
                        {
                            RinexFileQualityCheck qc = new RinexFileQualityCheck(rF);
                            var qc1 = Data.RinexFileQualityChecks.Find(t => t.FileName == qc.FileName);
                            if (qc1 != null)
                            {
                                Delete(qc1);
                            }
                            Data.RinexFileQualityChecks.Add(qc);
                            Invoke(new Action(() =>
                            {
                                naviPanel.Nodes[1].Nodes.Add(new TreeNode(rF.FileName, 1, 1));
                                qualityCheckGrid.Rows.Add(qc.FileName, rF.FileName, $"(LT){qc.CheckTime.ToString("F")}", qc.DataIntegrityOfGPS[0], qc.DataIntegrityOfBDS[0], qc.NoneSlipRatio, qc.MultipathRMSAtF1, qc.MultipathRMSAtF2);
                                AddLog(LogType.INFO, $"{rF.FileName}检核完成");
                            }));
                        }));
                        Thread thread = new Thread(threadStart);
                        thread.Start();
                    }
                    catch (Exception)
                    {
                        AddLog(LogType.WARN, $"{rF.FileName}检核失败！");
                    }
                }
                if (qualityCheckGrid.Rows.Count > 0)
                {
                    qualityCheckGrid.ClearSelection();
                    qualityCheckGrid.Rows[0].Selected = true;
                }
                naviPanel.Enabled = true;
                toolStrip.Enabled = true;
                menuStrip.Enabled = true;
            }
            else
            {
                AddLog(LogType.WARN, "检核失败！未选中任何文件！");
            }
        }

        private void 启用B1B3双频观测值ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Data.useB1B2 = !启用B1B3双频观测值ToolStripMenuItem.Checked;
            AddLog(LogType.INFO, "检测到检核配置改变，请重新检核");
        }

        private void 全部检核toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.RinexFiles.Count > 0)
            {
                naviPanel.Enabled = false;
                toolStrip.Enabled = false;
                menuStrip.Enabled = false;
                AddLog(LogType.INFO, "开始检核");
                Data.RinexFileQualityChecks.Clear();
                qualityCheckGrid.Rows.Clear();
                naviPanel.Nodes[1].Nodes.Clear();
                foreach (RinexFile rF in Data.RinexFiles)
                {
                    try
                    {
                        ThreadStart threadStart = new ThreadStart(new Action(() =>
                        {
                            RinexFileQualityCheck qc = new RinexFileQualityCheck(rF);
                            var qc1 = Data.RinexFileQualityChecks.Find(t => t.FileName == qc.FileName);
                            if (qc1 != null)
                            {
                                Delete(qc1);
                            }
                            Data.RinexFileQualityChecks.Add(qc);
                            Invoke(new Action(() =>
                            {
                                naviPanel.Nodes[1].Nodes.Add(qc.FileName, qc.FileName, 1, 1);
                                qualityCheckGrid.Rows.Add(qc.FileName, rF.FileName, $"(LT){qc.CheckTime.ToString("F")}", qc.DataIntegrityOfGPS[0], qc.DataIntegrityOfBDS[0], qc.NoneSlipRatio, qc.MultipathRMSAtF1, qc.MultipathRMSAtF2);
                                AddLog(LogType.INFO, $"{rF.FileName}检核完成");
                            }));
                        }));
                        Thread thread = new Thread(threadStart);
                        thread.Start();
                    }
                    catch (Exception)
                    {
                        AddLog(LogType.ERROR, $"{rF.FileName}检核失败！");
                        continue;
                    }
                }
                if (qualityCheckGrid.Rows.Count > 0)
                {
                    qualityCheckGrid.ClearSelection();
                    qualityCheckGrid.Rows[0].Selected = true;
                }
                naviPanel.Enabled = true;
                toolStrip.Enabled = true;
                menuStrip.Enabled = true;
            }
            else
            {
                AddLog(LogType.WARN, "检核失败！没有导入任何文件！");
            }
        }

        private void 删除toolStripButton_Click(object sender, EventArgs e)
        {
            TabPage page = tabControl.SelectedTab;
            if (page == inputFilePage)
            {
                if (_selectedRinexFiles.Count > 0)
                {
                    var targets = _selectedRinexFiles.ToArray();
                    foreach (var target in targets)
                    {
                        Delete(target);
                    }
                    inputFileGrid.ClearSelection();
                    if (inputFileGrid.Rows.Count > 0)
                    {
                        inputFileGrid.Rows[0].Selected = true;
                        naviPanel.SelectedNode = naviPanel.Nodes[0].FirstNode;
                    }
                }
            }
            else
            {
                if (_selectedRinexFileQualityChecks.Count > 0)
                {
                    _needToShow = false;
                    var targets = _selectedRinexFileQualityChecks.ToArray();
                    foreach (var target in targets)
                    {
                        Delete(target);
                    }
                    qualityCheckGrid.ClearSelection();
                    _needToShow = true;
                    if (qualityCheckGrid.Rows.Count > 0)
                    {
                        qualityCheckGrid.Rows[0].Selected = true;
                        naviPanel.SelectedNode = naviPanel.Nodes[1].FirstNode;
                    }
                }
            }
        }

        private void 上一个toolStripButton_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == inputFilePage)
            {
                if (_selectedRinexFiles.Count > 0)
                {
                    int index = Data.IndexOf(_selectedRinexFiles[0]);
                    if (index > 0)
                    {
                        inputFileGrid.ClearSelection();
                        inputFileGrid.Rows[index - 1].Selected = true;
                        naviPanel.SelectedNode = naviPanel.Nodes[0].Nodes[index - 1];
                    }
                    else
                    {
                        AddLog(LogType.WARN, "已经是第一个！");
                    }
                }
            }
            else
            {
                if (_selectedRinexFileQualityChecks.Count > 0)
                {
                    int index = Data.IndexOf(_selectedRinexFileQualityChecks[0]);
                    if (index > 0)
                    {
                        qualityCheckGrid.ClearSelection();
                        qualityCheckGrid.Rows[index - 1].Selected = true;
                        naviPanel.SelectedNode = naviPanel.Nodes[1].Nodes[index - 1];
                    }
                    else
                    {
                        AddLog(LogType.WARN, "已经是第一个！");
                    }
                }
            }
        }

        private void 输出栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer4.Panel2Collapsed = !输出栏ToolStripMenuItem.Checked;
        }

        private void 属性栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = !属性栏ToolStripMenuItem.Checked;
        }

        private void 数据完整度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(integrityPage);
        }

        private void 下一个toolStripButton_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == inputFilePage)
            {
                if (_selectedRinexFiles.Count > 0)
                {
                    int index = Data.IndexOf(_selectedRinexFiles.Last());
                    if (index < Data.RinexFiles.Count - 1)
                    {
                        inputFileGrid.ClearSelection();
                        inputFileGrid.Rows[index + 1].Selected = true;
                        naviPanel.SelectedNode = naviPanel.Nodes[0].Nodes[index + 1];
                    }
                    else
                    {
                        AddLog(LogType.WARN, "已经是最后一个！");
                    }
                }
            }
            else
            {
                if (_selectedRinexFileQualityChecks.Count > 0)
                {
                    int index = Data.IndexOf(_selectedRinexFileQualityChecks.Last());
                    if (index < Data.RinexFileQualityChecks.Count - 1)
                    {
                        qualityCheckGrid.ClearSelection();
                        qualityCheckGrid.Rows[index + 1].Selected = true;
                        naviPanel.SelectedNode = naviPanel.Nodes[1].Nodes[index + 1];
                    }
                    else
                    {
                        AddLog(LogType.WARN, "已经是最后一个！");
                    }
                }
            }
        }

        private void 向右翻页toolStripButton_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex < 4)
            {
                tabControl.SelectedIndex++;
            }
            else
            {
                AddLog(LogType.WARN, "已经是最后一页！");
            }
        }

        private void 向左翻页toolStripButton_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex > 0)
            {
                tabControl.SelectedIndex--;
            }
            else
            {
                AddLog(LogType.WARN, "已经是第一页！");
            }
        }

        private void 质检报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(qualityCheckPage);
        }

        private void 周跳探测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(slipPage);
        }
    }
}