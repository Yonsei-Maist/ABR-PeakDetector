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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLoopPeriod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCaptureStop = new System.Windows.Forms.Button();
            this.btnCaptureStart = new System.Windows.Forms.Button();
            this.chartDetail = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAll = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDelLocalRes = new System.Windows.Forms.Button();
            this.listViewRes = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerCapture = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbXValue = new System.Windows.Forms.TextBox();
            this.tbYValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.labelGraph = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAll)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.panelGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "AI Peak Detector";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.panelGraph);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.btnCaptureStop);
            this.panel.Controls.Add(this.btnDelLocalRes);
            this.panel.Controls.Add(this.btnCaptureStart);
            this.panel.Controls.Add(this.chartDetail);
            this.panel.Controls.Add(this.chartAll);
            this.panel.Controls.Add(this.listViewRes);
            this.panel.Location = new System.Drawing.Point(12, 58);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1299, 540);
            this.panel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(803, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "since 2020";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(455, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "YWCM Medical Artificial Intelligence Solution Team";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbHeight);
            this.groupBox1.Controls.Add(this.tbWidth);
            this.groupBox1.Controls.Add(this.tbYValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbXValue);
            this.groupBox1.Controls.Add(this.tbLoopPeriod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(1142, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 155);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "설정";
            // 
            // tbLoopPeriod
            // 
            this.tbLoopPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoopPeriod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbLoopPeriod.Location = new System.Drawing.Point(8, 20);
            this.tbLoopPeriod.Name = "tbLoopPeriod";
            this.tbLoopPeriod.Size = new System.Drawing.Size(128, 21);
            this.tbLoopPeriod.TabIndex = 11;
            this.tbLoopPeriod.Text = "1000";
            this.tbLoopPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "(ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(8, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "X:";
            // 
            // btnCaptureStop
            // 
            this.btnCaptureStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaptureStop.BackColor = System.Drawing.Color.Transparent;
            this.btnCaptureStop.Enabled = false;
            this.btnCaptureStop.Location = new System.Drawing.Point(1142, 42);
            this.btnCaptureStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCaptureStop.Name = "btnCaptureStop";
            this.btnCaptureStop.Size = new System.Drawing.Size(146, 29);
            this.btnCaptureStop.TabIndex = 15;
            this.btnCaptureStop.Text = "캡처 중지";
            this.btnCaptureStop.UseVisualStyleBackColor = false;
            this.btnCaptureStop.Click += new System.EventHandler(this.btnCaptureStop_Click);
            // 
            // btnCaptureStart
            // 
            this.btnCaptureStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaptureStart.BackColor = System.Drawing.Color.Transparent;
            this.btnCaptureStart.Location = new System.Drawing.Point(1142, 12);
            this.btnCaptureStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCaptureStart.Name = "btnCaptureStart";
            this.btnCaptureStart.Size = new System.Drawing.Size(146, 29);
            this.btnCaptureStart.TabIndex = 14;
            this.btnCaptureStart.Text = "캡처 시작";
            this.btnCaptureStart.UseVisualStyleBackColor = false;
            this.btnCaptureStart.Click += new System.EventHandler(this.btnCaptureStart_Click);
            // 
            // chartDetail
            // 
            this.chartDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDetail.BorderlineColor = System.Drawing.Color.Black;
            this.chartDetail.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.chartDetail.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDetail.Legends.Add(legend3);
            this.chartDetail.Location = new System.Drawing.Point(735, 13);
            this.chartDetail.Name = "chartDetail";
            this.chartDetail.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartDetail.Size = new System.Drawing.Size(401, 493);
            this.chartDetail.TabIndex = 9;
            this.chartDetail.Text = "chartDetail";
            this.chartDetail.MouseHover += new System.EventHandler(this.chartDetail_MouseHover);
            // 
            // chartAll
            // 
            this.chartAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chartAll.BorderlineColor = System.Drawing.Color.Black;
            this.chartAll.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chartAll.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartAll.Legends.Add(legend4);
            this.chartAll.Location = new System.Drawing.Point(194, 13);
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
            this.chartAll.Size = new System.Drawing.Size(535, 493);
            this.chartAll.TabIndex = 8;
            this.chartAll.Text = "chartAll";
            this.chartAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartAll_MouseClick);
            this.chartAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartAll_MouseMove);
            // 
            // btnDelLocalRes
            // 
            this.btnDelLocalRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelLocalRes.Location = new System.Drawing.Point(14, 477);
            this.btnDelLocalRes.Name = "btnDelLocalRes";
            this.btnDelLocalRes.Size = new System.Drawing.Size(174, 29);
            this.btnDelLocalRes.TabIndex = 7;
            this.btnDelLocalRes.Text = "전체 삭제";
            this.btnDelLocalRes.UseVisualStyleBackColor = true;
            this.btnDelLocalRes.Click += new System.EventHandler(this.btnDelLocalRes_Click);
            // 
            // listViewRes
            // 
            this.listViewRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewRes.FullRowSelect = true;
            this.listViewRes.GridLines = true;
            this.listViewRes.HideSelection = false;
            this.listViewRes.Location = new System.Drawing.Point(14, 13);
            this.listViewRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewRes.MultiSelect = false;
            this.listViewRes.Name = "listViewRes";
            this.listViewRes.Size = new System.Drawing.Size(174, 459);
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
            // tbXValue
            // 
            this.tbXValue.Location = new System.Drawing.Point(29, 70);
            this.tbXValue.Name = "tbXValue";
            this.tbXValue.Size = new System.Drawing.Size(41, 21);
            this.tbXValue.TabIndex = 21;
            this.tbXValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXValue_KeyPress);
            // 
            // tbYValue
            // 
            this.tbYValue.Location = new System.Drawing.Point(99, 70);
            this.tbYValue.Name = "tbYValue";
            this.tbYValue.Size = new System.Drawing.Size(38, 21);
            this.tbYValue.TabIndex = 23;
            this.tbYValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYValue_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(76, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "Y:";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(49, 97);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(88, 21);
            this.tbWidth.TabIndex = 25;
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(49, 122);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(88, 21);
            this.tbHeight.TabIndex = 26;
            this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(8, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "넓이 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(8, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "높이 :";
            // 
            // panelGraph
            // 
            this.panelGraph.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelGraph.Controls.Add(this.labelGraph);
            this.panelGraph.Location = new System.Drawing.Point(194, 13);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(942, 493);
            this.panelGraph.TabIndex = 5;
            // 
            // labelGraph
            // 
            this.labelGraph.AutoSize = true;
            this.labelGraph.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelGraph.Location = new System.Drawing.Point(406, 220);
            this.labelGraph.Name = "labelGraph";
            this.labelGraph.Size = new System.Drawing.Size(129, 12);
            this.labelGraph.TabIndex = 0;
            this.labelGraph.Text = "이미지를 선택해주세요";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 608);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "AI Peak Detector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAll)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.panelGraph.ResumeLayout(false);
            this.panelGraph.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListView listViewRes;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnDelLocalRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDetail;
        private System.Windows.Forms.Button btnCaptureStop;
        private System.Windows.Forms.Button btnCaptureStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLoopPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerCapture;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbYValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbXValue;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Label labelGraph;
    }
}