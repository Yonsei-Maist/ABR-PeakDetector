namespace PeakDetector
{
    partial class MainForm
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel = new System.Windows.Forms.Panel();
			this.labelGraph = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.chartAll = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartDetail = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panelGraph = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.listViewRes = new System.Windows.Forms.ListView();
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnDelLocalRes = new System.Windows.Forms.Button();
			this.btnCaptureStop = new System.Windows.Forms.Button();
			this.btnCaptureStart = new System.Windows.Forms.Button();
			this.timerCapture = new System.Windows.Forms.Timer(this.components);
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSetting = new System.Windows.Forms.Button();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartAll)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDetail)).BeginInit();
			this.panel1.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel.BackColor = System.Drawing.Color.White;
			this.panel.Controls.Add(this.labelGraph);
			this.panel.Controls.Add(this.splitContainer1);
			this.panel.Controls.Add(this.panelGraph);
			this.panel.Controls.Add(this.panel1);
			this.panel.Location = new System.Drawing.Point(12, 46);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(942, 540);
			this.panel.TabIndex = 4;
			// 
			// labelGraph
			// 
			this.labelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelGraph.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.labelGraph.Location = new System.Drawing.Point(200, 0);
			this.labelGraph.Name = "labelGraph";
			this.labelGraph.Size = new System.Drawing.Size(742, 540);
			this.labelGraph.TabIndex = 0;
			this.labelGraph.Text = "이미지를 선택해주세요";
			this.labelGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(200, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.chartAll);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.chartDetail);
			this.splitContainer1.Size = new System.Drawing.Size(742, 540);
			this.splitContainer1.SplitterDistance = 360;
			this.splitContainer1.TabIndex = 18;
			// 
			// chartAll
			// 
			this.chartAll.BorderlineColor = System.Drawing.Color.Black;
			this.chartAll.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea3.Name = "ChartArea1";
			this.chartAll.ChartAreas.Add(chartArea3);
			this.chartAll.Dock = System.Windows.Forms.DockStyle.Fill;
			legend3.Name = "Legend1";
			this.chartAll.Legends.Add(legend3);
			this.chartAll.Location = new System.Drawing.Point(0, 0);
			this.chartAll.Name = "chartAll";
			this.chartAll.Size = new System.Drawing.Size(360, 540);
			this.chartAll.TabIndex = 8;
			this.chartAll.Text = "chartAll";
			this.chartAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartAll_MouseClick);
			this.chartAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartAll_MouseMove);
			// 
			// chartDetail
			// 
			this.chartDetail.BorderlineColor = System.Drawing.Color.Black;
			this.chartDetail.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea4.Name = "ChartArea1";
			this.chartDetail.ChartAreas.Add(chartArea4);
			this.chartDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			legend4.Name = "Legend1";
			this.chartDetail.Legends.Add(legend4);
			this.chartDetail.Location = new System.Drawing.Point(0, 0);
			this.chartDetail.Name = "chartDetail";
			this.chartDetail.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
			this.chartDetail.Size = new System.Drawing.Size(378, 540);
			this.chartDetail.TabIndex = 9;
			this.chartDetail.Text = "chartDetail";
			this.chartDetail.MouseHover += new System.EventHandler(this.chartDetail_MouseHover);
			// 
			// panelGraph
			// 
			this.panelGraph.BackColor = System.Drawing.Color.White;
			this.panelGraph.Location = new System.Drawing.Point(194, 13);
			this.panelGraph.Name = "panelGraph";
			this.panelGraph.Size = new System.Drawing.Size(0, 0);
			this.panelGraph.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.listViewRes);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
			this.panel1.Size = new System.Drawing.Size(200, 540);
			this.panel1.TabIndex = 19;
			// 
			// listViewRes
			// 
			this.listViewRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
			this.listViewRes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewRes.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.listViewRes.FullRowSelect = true;
			this.listViewRes.GridLines = true;
			this.listViewRes.HideSelection = false;
			this.listViewRes.Location = new System.Drawing.Point(0, 0);
			this.listViewRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listViewRes.MultiSelect = false;
			this.listViewRes.Name = "listViewRes";
			this.listViewRes.Size = new System.Drawing.Size(193, 540);
			this.listViewRes.Sorting = System.Windows.Forms.SortOrder.Descending;
			this.listViewRes.TabIndex = 6;
			this.listViewRes.UseCompatibleStateImageBehavior = false;
			this.listViewRes.View = System.Windows.Forms.View.Details;
			this.listViewRes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewRes_MouseDoubleClick);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "날짜-시간";
			this.columnHeader2.Width = 250;
			// 
			// btnDelLocalRes
			// 
			this.btnDelLocalRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelLocalRes.BackgroundImage = global::PeakDetector.Properties.Resources.remove;
			this.btnDelLocalRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDelLocalRes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelLocalRes.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnDelLocalRes.FlatAppearance.BorderSize = 0;
			this.btnDelLocalRes.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnDelLocalRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnDelLocalRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnDelLocalRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelLocalRes.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnDelLocalRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelLocalRes.Location = new System.Drawing.Point(888, 9);
			this.btnDelLocalRes.Name = "btnDelLocalRes";
			this.btnDelLocalRes.Size = new System.Drawing.Size(30, 30);
			this.btnDelLocalRes.TabIndex = 7;
			this.btnDelLocalRes.UseVisualStyleBackColor = true;
			this.btnDelLocalRes.Click += new System.EventHandler(this.btnDelLocalRes_Click);
			// 
			// btnCaptureStop
			// 
			this.btnCaptureStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCaptureStop.BackColor = System.Drawing.Color.Transparent;
			this.btnCaptureStop.BackgroundImage = global::PeakDetector.Properties.Resources.stop;
			this.btnCaptureStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCaptureStop.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCaptureStop.Enabled = false;
			this.btnCaptureStop.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnCaptureStop.FlatAppearance.BorderSize = 0;
			this.btnCaptureStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnCaptureStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnCaptureStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCaptureStop.Location = new System.Drawing.Point(852, 9);
			this.btnCaptureStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCaptureStop.Name = "btnCaptureStop";
			this.btnCaptureStop.Size = new System.Drawing.Size(30, 30);
			this.btnCaptureStop.TabIndex = 15;
			this.btnCaptureStop.UseVisualStyleBackColor = false;
			this.btnCaptureStop.Click += new System.EventHandler(this.btnCaptureStop_Click);
			// 
			// btnCaptureStart
			// 
			this.btnCaptureStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCaptureStart.BackColor = System.Drawing.Color.Transparent;
			this.btnCaptureStart.BackgroundImage = global::PeakDetector.Properties.Resources.start;
			this.btnCaptureStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCaptureStart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCaptureStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnCaptureStart.FlatAppearance.BorderSize = 0;
			this.btnCaptureStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnCaptureStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnCaptureStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnCaptureStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCaptureStart.Location = new System.Drawing.Point(852, 9);
			this.btnCaptureStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCaptureStart.Name = "btnCaptureStart";
			this.btnCaptureStart.Size = new System.Drawing.Size(30, 30);
			this.btnCaptureStart.TabIndex = 14;
			this.btnCaptureStart.UseVisualStyleBackColor = false;
			this.btnCaptureStart.Click += new System.EventHandler(this.btnCaptureStart_Click);
			// 
			// trayIcon
			// 
			this.trayIcon.ContextMenuStrip = this.contextMenuStrip;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "ABR AI Peak Detector";
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
			// btnSetting
			// 
			this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSetting.BackColor = System.Drawing.Color.Transparent;
			this.btnSetting.BackgroundImage = global::PeakDetector.Properties.Resources.settings;
			this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSetting.FlatAppearance.BorderSize = 0;
			this.btnSetting.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetting.Location = new System.Drawing.Point(924, 9);
			this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(30, 30);
			this.btnSetting.TabIndex = 21;
			this.btnSetting.UseVisualStyleBackColor = false;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(966, 608);
			this.Controls.Add(this.btnCaptureStart);
			this.Controls.Add(this.btnDelLocalRes);
			this.Controls.Add(this.btnSetting);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.btnCaptureStop);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "YWCM MAIST - AI Peak Detector";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartAll)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDetail)).EndInit();
			this.panel1.ResumeLayout(false);
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListView listViewRes;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnDelLocalRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDetail;
        private System.Windows.Forms.Button btnCaptureStop;
        private System.Windows.Forms.Button btnCaptureStart;
        private System.Windows.Forms.Timer timerCapture;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Label labelGraph;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnSetting;
	}
}