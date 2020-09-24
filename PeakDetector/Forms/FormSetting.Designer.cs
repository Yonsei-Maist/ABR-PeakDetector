namespace PeakDetector.Forms {
	partial class FormSetting {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbHeight = new System.Windows.Forms.TextBox();
			this.tbWidth = new System.Windows.Forms.TextBox();
			this.tbYValue = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbXValue = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbLoopPeriod = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.labelInfo = new System.Windows.Forms.Label();
			this.buttonConfirm = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbHeight);
			this.groupBox1.Controls.Add(this.tbWidth);
			this.groupBox1.Controls.Add(this.tbYValue);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbXValue);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(12, 150);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(218, 83);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "캡쳐크기";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label8.Location = new System.Drawing.Point(107, 55);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 28;
			this.label8.Text = "높이";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(6, 55);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 27;
			this.label5.Text = "넓이";
			// 
			// tbHeight
			// 
			this.tbHeight.Location = new System.Drawing.Point(143, 50);
			this.tbHeight.Name = "tbHeight";
			this.tbHeight.Size = new System.Drawing.Size(64, 21);
			this.tbHeight.TabIndex = 26;
			this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_onlyNumber);
			// 
			// tbWidth
			// 
			this.tbWidth.Location = new System.Drawing.Point(41, 50);
			this.tbWidth.Name = "tbWidth";
			this.tbWidth.Size = new System.Drawing.Size(60, 21);
			this.tbWidth.TabIndex = 25;
			this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_onlyNumber);
			// 
			// tbYValue
			// 
			this.tbYValue.Location = new System.Drawing.Point(143, 23);
			this.tbYValue.Name = "tbYValue";
			this.tbYValue.Size = new System.Drawing.Size(64, 21);
			this.tbYValue.TabIndex = 23;
			this.tbYValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_onlyNumber);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(107, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 12);
			this.label3.TabIndex = 24;
			this.label3.Text = "Y";
			// 
			// tbXValue
			// 
			this.tbXValue.Location = new System.Drawing.Point(41, 23);
			this.tbXValue.Name = "tbXValue";
			this.tbXValue.Size = new System.Drawing.Size(60, 21);
			this.tbXValue.TabIndex = 21;
			this.tbXValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_onlyNumber);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(6, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 12);
			this.label4.TabIndex = 22;
			this.label4.Text = "X";
			// 
			// tbLoopPeriod
			// 
			this.tbLoopPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLoopPeriod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tbLoopPeriod.Location = new System.Drawing.Point(8, 20);
			this.tbLoopPeriod.Name = "tbLoopPeriod";
			this.tbLoopPeriod.Size = new System.Drawing.Size(165, 21);
			this.tbLoopPeriod.TabIndex = 11;
			this.tbLoopPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbLoopPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress_onlyNumber);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(177, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "(ms)";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbLoopPeriod);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 95);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(218, 49);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "캡쳐주기";
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.labelInfo.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.labelInfo.ForeColor = System.Drawing.Color.Black;
			this.labelInfo.Location = new System.Drawing.Point(86, 11);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(148, 68);
			this.labelInfo.TabIndex = 21;
			this.labelInfo.Text = "AI Peak Detector\r\n{version}\r\nⓒ 2020. YWCM MAIST.\r\nAll Rights Reserved.";
			this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.Location = new System.Drawing.Point(155, 239);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
			this.buttonConfirm.TabIndex = 22;
			this.buttonConfirm.Text = "확인";
			this.buttonConfirm.UseVisualStyleBackColor = true;
			this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::PeakDetector.Properties.Resources.logo;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(12, 11);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(68, 68);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// FormSetting
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(242, 271);
			this.Controls.Add(this.buttonConfirm);
			this.Controls.Add(this.labelInfo);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormSetting";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "설정 및 정보";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbHeight;
		private System.Windows.Forms.TextBox tbWidth;
		private System.Windows.Forms.TextBox tbYValue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbXValue;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbLoopPeriod;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.Button buttonConfirm;
	}
}