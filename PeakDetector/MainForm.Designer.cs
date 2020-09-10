﻿namespace PeakDetector
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnFullCaptureStart = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbLoopPeriod = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCaptureStop = new System.Windows.Forms.Button();
			this.btnCaptureStart = new System.Windows.Forms.Button();
			this.rtbLog = new System.Windows.Forms.RichTextBox();
			this.panelCaptureArea = new System.Windows.Forms.Panel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.chartDetail = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartAll = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.checkBoxAll = new System.Windows.Forms.CheckBox();
			this.btnDelLocalRes = new System.Windows.Forms.Button();
			this.btnLocalRes = new System.Windows.Forms.Button();
			this.listViewRes = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.timerCapture = new System.Windows.Forms.Timer(this.components);
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartAll)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(12, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(46, 42);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(61, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "[ABR] AI Peak Detector";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.ItemSize = new System.Drawing.Size(100, 25);
			this.tabControl1.Location = new System.Drawing.Point(12, 60);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(996, 521);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnFullCaptureStart);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.btnCaptureStop);
			this.tabPage1.Controls.Add(this.btnCaptureStart);
			this.tabPage1.Controls.Add(this.rtbLog);
			this.tabPage1.Controls.Add(this.panelCaptureArea);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Size = new System.Drawing.Size(988, 488);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Capture";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnFullCaptureStart
			// 
			this.btnFullCaptureStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFullCaptureStart.Location = new System.Drawing.Point(828, 13);
			this.btnFullCaptureStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnFullCaptureStart.Name = "btnFullCaptureStart";
			this.btnFullCaptureStart.Size = new System.Drawing.Size(146, 29);
			this.btnFullCaptureStart.TabIndex = 13;
			this.btnFullCaptureStart.Text = "Full Capture Start";
			this.btnFullCaptureStart.UseVisualStyleBackColor = true;
			this.btnFullCaptureStart.Click += new System.EventHandler(this.btnFullCaptureStart_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tbLoopPeriod);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(823, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(159, 61);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Setting";
			// 
			// tbLoopPeriod
			// 
			this.tbLoopPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLoopPeriod.Location = new System.Drawing.Point(6, 20);
			this.tbLoopPeriod.Name = "tbLoopPeriod";
			this.tbLoopPeriod.Size = new System.Drawing.Size(146, 21);
			this.tbLoopPeriod.TabIndex = 11;
			this.tbLoopPeriod.Text = "1000";
			this.tbLoopPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(126, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "(ms)";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(828, 309);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 12);
			this.label3.TabIndex = 11;
			this.label3.Text = "Log";
			// 
			// btnCaptureStop
			// 
			this.btnCaptureStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCaptureStop.Enabled = false;
			this.btnCaptureStop.Location = new System.Drawing.Point(828, 73);
			this.btnCaptureStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCaptureStop.Name = "btnCaptureStop";
			this.btnCaptureStop.Size = new System.Drawing.Size(146, 29);
			this.btnCaptureStop.TabIndex = 7;
			this.btnCaptureStop.Text = "Capture Stop";
			this.btnCaptureStop.UseVisualStyleBackColor = true;
			this.btnCaptureStop.Click += new System.EventHandler(this.btnCaptureStop_Click);
			// 
			// btnCaptureStart
			// 
			this.btnCaptureStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCaptureStart.Location = new System.Drawing.Point(828, 43);
			this.btnCaptureStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCaptureStart.Name = "btnCaptureStart";
			this.btnCaptureStart.Size = new System.Drawing.Size(146, 29);
			this.btnCaptureStart.TabIndex = 6;
			this.btnCaptureStart.Text = "Capture Start";
			this.btnCaptureStart.UseVisualStyleBackColor = true;
			this.btnCaptureStart.Click += new System.EventHandler(this.btnCaptureStart_Click);
			// 
			// rtbLog
			// 
			this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbLog.Location = new System.Drawing.Point(828, 324);
			this.rtbLog.Name = "rtbLog";
			this.rtbLog.Size = new System.Drawing.Size(146, 159);
			this.rtbLog.TabIndex = 8;
			this.rtbLog.Text = "";
			// 
			// panelCaptureArea
			// 
			this.panelCaptureArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelCaptureArea.BackColor = System.Drawing.Color.AliceBlue;
			this.panelCaptureArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCaptureArea.Location = new System.Drawing.Point(5, 13);
			this.panelCaptureArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelCaptureArea.Name = "panelCaptureArea";
			this.panelCaptureArea.Size = new System.Drawing.Size(812, 475);
			this.panelCaptureArea.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.splitContainer1);
			this.tabPage2.Controls.Add(this.checkBoxAll);
			this.tabPage2.Controls.Add(this.btnDelLocalRes);
			this.tabPage2.Controls.Add(this.btnLocalRes);
			this.tabPage2.Controls.Add(this.listViewRes);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Size = new System.Drawing.Size(988, 488);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Result";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// chartDetail
			// 
			this.chartDetail.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.chartDetail.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea4.AxisX.Minimum = 0D;
			chartArea4.Name = "ChartArea1";
			this.chartDetail.ChartAreas.Add(chartArea4);
			this.chartDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			legend4.Name = "Legend1";
			this.chartDetail.Legends.Add(legend4);
			this.chartDetail.Location = new System.Drawing.Point(0, 0);
			this.chartDetail.Name = "chartDetail";
			this.chartDetail.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
			this.chartDetail.Size = new System.Drawing.Size(369, 400);
			this.chartDetail.TabIndex = 9;
			this.chartDetail.Text = "chartDetail";
			// 
			// chartAll
			// 
			this.chartAll.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.chartAll.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea3.Name = "ChartArea1";
			this.chartAll.ChartAreas.Add(chartArea3);
			this.chartAll.Dock = System.Windows.Forms.DockStyle.Fill;
			legend3.Name = "Legend1";
			this.chartAll.Legends.Add(legend3);
			this.chartAll.Location = new System.Drawing.Point(0, 0);
			this.chartAll.Name = "chartAll";
			series9.BorderWidth = 2;
			series9.ChartArea = "ChartArea1";
			series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series9.Legend = "Legend1";
			series9.Name = "Series1";
			series10.BorderWidth = 2;
			series10.ChartArea = "ChartArea1";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series10.Legend = "Legend1";
			series10.Name = "Series2";
			series11.BorderWidth = 2;
			series11.ChartArea = "ChartArea1";
			series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series11.Legend = "Legend1";
			series11.Name = "Series3";
			series12.BorderWidth = 2;
			series12.ChartArea = "ChartArea1";
			series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series12.Legend = "Legend1";
			series12.Name = "Series4";
			series13.BorderWidth = 2;
			series13.ChartArea = "ChartArea1";
			series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series13.Legend = "Legend1";
			series13.Name = "Series5";
			series14.BorderWidth = 2;
			series14.ChartArea = "ChartArea1";
			series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series14.Legend = "Legend1";
			series14.Name = "Series6";
			series15.BorderWidth = 2;
			series15.ChartArea = "ChartArea1";
			series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series15.Legend = "Legend1";
			series15.Name = "Series7";
			series16.BorderWidth = 2;
			series16.ChartArea = "ChartArea1";
			series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series16.Legend = "Legend1";
			series16.Name = "Series8";
			this.chartAll.Series.Add(series9);
			this.chartAll.Series.Add(series10);
			this.chartAll.Series.Add(series11);
			this.chartAll.Series.Add(series12);
			this.chartAll.Series.Add(series13);
			this.chartAll.Series.Add(series14);
			this.chartAll.Series.Add(series15);
			this.chartAll.Series.Add(series16);
			this.chartAll.Size = new System.Drawing.Size(423, 400);
			this.chartAll.TabIndex = 8;
			this.chartAll.Text = "chartAll";
			this.chartAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartAll_MouseClick);
			this.chartAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartAll_MouseMove);
			// 
			// checkBoxAll
			// 
			this.checkBoxAll.AutoSize = true;
			this.checkBoxAll.Location = new System.Drawing.Point(21, 56);
			this.checkBoxAll.Name = "checkBoxAll";
			this.checkBoxAll.Size = new System.Drawing.Size(15, 14);
			this.checkBoxAll.TabIndex = 7;
			this.checkBoxAll.UseVisualStyleBackColor = true;
			this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
			// 
			// btnDelLocalRes
			// 
			this.btnDelLocalRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDelLocalRes.Location = new System.Drawing.Point(6, 454);
			this.btnDelLocalRes.Name = "btnDelLocalRes";
			this.btnDelLocalRes.Size = new System.Drawing.Size(96, 29);
			this.btnDelLocalRes.TabIndex = 6;
			this.btnDelLocalRes.Text = "Delete";
			this.btnDelLocalRes.UseVisualStyleBackColor = true;
			this.btnDelLocalRes.Click += new System.EventHandler(this.btnDelLocalRes_Click);
			// 
			// btnLocalRes
			// 
			this.btnLocalRes.Location = new System.Drawing.Point(6, 15);
			this.btnLocalRes.Name = "btnLocalRes";
			this.btnLocalRes.Size = new System.Drawing.Size(169, 29);
			this.btnLocalRes.TabIndex = 4;
			this.btnLocalRes.Text = "Local resource";
			this.btnLocalRes.UseVisualStyleBackColor = true;
			this.btnLocalRes.Click += new System.EventHandler(this.btnLocalRes_Click);
			// 
			// listViewRes
			// 
			this.listViewRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listViewRes.CheckBoxes = true;
			this.listViewRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listViewRes.FullRowSelect = true;
			this.listViewRes.GridLines = true;
			this.listViewRes.HideSelection = false;
			this.listViewRes.Location = new System.Drawing.Point(6, 49);
			this.listViewRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listViewRes.Name = "listViewRes";
			this.listViewRes.Size = new System.Drawing.Size(174, 400);
			this.listViewRes.TabIndex = 1;
			this.listViewRes.UseCompatibleStateImageBehavior = false;
			this.listViewRes.View = System.Windows.Forms.View.Details;
			this.listViewRes.DoubleClick += new System.EventHandler(this.listViewRes_MouseDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "";
			this.columnHeader1.Width = 20;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "file name";
			this.columnHeader2.Width = 200;
			// 
			// timerCapture
			// 
			this.timerCapture.Tick += new System.EventHandler(this.timerCapture_Tick);
			// 
			// trayIcon
			// 
			this.trayIcon.ContextMenuStrip = this.contextMenuStrip;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "ABR Capture";
			this.trayIcon.Visible = true;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(105, 48);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.showToolStripMenuItem.Text = "Show";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(186, 49);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.chartAll);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.chartDetail);
			this.splitContainer1.Size = new System.Drawing.Size(796, 400);
			this.splitContainer1.SplitterDistance = 423;
			this.splitContainer1.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1018, 592);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "ABR";
			this.TransparencyKey = System.Drawing.Color.AliceBlue;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartAll)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCaptureStart;
        private System.Windows.Forms.Button btnCaptureStop;
        private System.Windows.Forms.ListView listViewRes;
        private System.Windows.Forms.Panel panelCaptureArea;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Timer timerCapture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLocalRes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLoopPeriod;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Button btnDelLocalRes;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnFullCaptureStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDetail;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}

