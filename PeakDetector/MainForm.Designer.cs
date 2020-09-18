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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series65 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series66 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series67 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series68 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series69 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series70 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series71 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series72 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLoopPeriod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCaptureStop = new System.Windows.Forms.Button();
            this.btnCaptureStart = new System.Windows.Forms.Button();
            this.chartDetail = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAll = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDelLocalRes = new System.Windows.Forms.Button();
            this.listViewRes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLocalRes = new System.Windows.Forms.Button();
            this.timerCapture = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbResolutionW = new System.Windows.Forms.TextBox();
            this.tbResolutionH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAll)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "[ABR] AI Peak Detector";
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
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.rtbLog);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.btnCaptureStop);
            this.panel.Controls.Add(this.btnCaptureStart);
            this.panel.Controls.Add(this.chartDetail);
            this.panel.Controls.Add(this.chartAll);
            this.panel.Controls.Add(this.btnDelLocalRes);
            this.panel.Controls.Add(this.listViewRes);
            this.panel.Controls.Add(this.btnLocalRes);
            this.panel.Location = new System.Drawing.Point(12, 58);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1299, 513);
            this.panel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1142, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(1142, 318);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(146, 179);
            this.rtbLog.TabIndex = 18;
            this.rtbLog.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbLoopPeriod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbResolutionH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbResolutionW);
            this.groupBox1.Location = new System.Drawing.Point(1142, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 116);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // tbLoopPeriod
            // 
            this.tbLoopPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoopPeriod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbLoopPeriod.Location = new System.Drawing.Point(6, 20);
            this.tbLoopPeriod.Name = "tbLoopPeriod";
            this.tbLoopPeriod.Size = new System.Drawing.Size(133, 21);
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
            this.btnCaptureStop.Text = "Capture Stop";
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
            this.btnCaptureStart.Text = "Capture Start";
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
            chartArea17.Name = "ChartArea1";
            this.chartDetail.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chartDetail.Legends.Add(legend17);
            this.chartDetail.Location = new System.Drawing.Point(735, 13);
            this.chartDetail.Name = "chartDetail";
            this.chartDetail.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartDetail.Size = new System.Drawing.Size(401, 484);
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
            chartArea18.Name = "ChartArea1";
            this.chartAll.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chartAll.Legends.Add(legend18);
            this.chartAll.Location = new System.Drawing.Point(194, 13);
            this.chartAll.Name = "chartAll";
            series65.BorderWidth = 2;
            series65.ChartArea = "ChartArea1";
            series65.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series65.Legend = "Legend1";
            series65.Name = "Series1";
            series66.BorderWidth = 2;
            series66.ChartArea = "ChartArea1";
            series66.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series66.Legend = "Legend1";
            series66.Name = "Series2";
            series67.BorderWidth = 2;
            series67.ChartArea = "ChartArea1";
            series67.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series67.Legend = "Legend1";
            series67.Name = "Series3";
            series68.BorderWidth = 2;
            series68.ChartArea = "ChartArea1";
            series68.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series68.Legend = "Legend1";
            series68.Name = "Series4";
            series69.BorderWidth = 2;
            series69.ChartArea = "ChartArea1";
            series69.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series69.Legend = "Legend1";
            series69.Name = "Series5";
            series70.BorderWidth = 2;
            series70.ChartArea = "ChartArea1";
            series70.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series70.Legend = "Legend1";
            series70.Name = "Series6";
            series71.BorderWidth = 2;
            series71.ChartArea = "ChartArea1";
            series71.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series71.Legend = "Legend1";
            series71.Name = "Series7";
            series72.BorderWidth = 2;
            series72.ChartArea = "ChartArea1";
            series72.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series72.Legend = "Legend1";
            series72.Name = "Series8";
            this.chartAll.Series.Add(series65);
            this.chartAll.Series.Add(series66);
            this.chartAll.Series.Add(series67);
            this.chartAll.Series.Add(series68);
            this.chartAll.Series.Add(series69);
            this.chartAll.Series.Add(series70);
            this.chartAll.Series.Add(series71);
            this.chartAll.Series.Add(series72);
            this.chartAll.Size = new System.Drawing.Size(535, 484);
            this.chartAll.TabIndex = 8;
            this.chartAll.Text = "chartAll";
            this.chartAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartAll_MouseClick);
            this.chartAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartAll_MouseMove);
            // 
            // btnDelLocalRes
            // 
            this.btnDelLocalRes.Location = new System.Drawing.Point(14, 42);
            this.btnDelLocalRes.Name = "btnDelLocalRes";
            this.btnDelLocalRes.Size = new System.Drawing.Size(174, 29);
            this.btnDelLocalRes.TabIndex = 7;
            this.btnDelLocalRes.Text = "Delete";
            this.btnDelLocalRes.UseVisualStyleBackColor = true;
            this.btnDelLocalRes.Click += new System.EventHandler(this.btnDelLocalRes_Click);
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
            this.listViewRes.Location = new System.Drawing.Point(14, 76);
            this.listViewRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewRes.Name = "listViewRes";
            this.listViewRes.Size = new System.Drawing.Size(174, 421);
            this.listViewRes.TabIndex = 6;
            this.listViewRes.UseCompatibleStateImageBehavior = false;
            this.listViewRes.View = System.Windows.Forms.View.Details;
            this.listViewRes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewRes_MouseDoubleClick);
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
            // btnLocalRes
            // 
            this.btnLocalRes.Location = new System.Drawing.Point(14, 13);
            this.btnLocalRes.Name = "btnLocalRes";
            this.btnLocalRes.Size = new System.Drawing.Size(174, 29);
            this.btnLocalRes.TabIndex = 5;
            this.btnLocalRes.Text = "Local resource";
            this.btnLocalRes.UseVisualStyleBackColor = true;
            this.btnLocalRes.Click += new System.EventHandler(this.btnLocalRes_Click);
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
            // tbResolutionW
            // 
            this.tbResolutionW.Location = new System.Drawing.Point(7, 84);
            this.tbResolutionW.Name = "tbResolutionW";
            this.tbResolutionW.Size = new System.Drawing.Size(54, 21);
            this.tbResolutionW.TabIndex = 20;
            this.tbResolutionW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbResolutionW_KeyPress);
            // 
            // tbResolutionH
            // 
            this.tbResolutionH.Location = new System.Drawing.Point(86, 84);
            this.tbResolutionH.Name = "tbResolutionH";
            this.tbResolutionH.Size = new System.Drawing.Size(54, 21);
            this.tbResolutionH.TabIndex = 21;
            this.tbResolutionH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbResolutionH_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "Display Resolution";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "x";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 581);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Form";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnLocalRes;
        private System.Windows.Forms.ListView listViewRes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnDelLocalRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDetail;
        private System.Windows.Forms.Button btnCaptureStop;
        private System.Windows.Forms.Button btnCaptureStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLoopPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Timer timerCapture;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbResolutionH;
        private System.Windows.Forms.TextBox tbResolutionW;
    }
}