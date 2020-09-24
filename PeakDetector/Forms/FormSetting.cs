/// <summary>
/// 프로그램 정보 및 전반적 설정 화면
/// @Author Chanwoo Gwon, Yonsei Univ. Researcher, since 2020.05
/// @Date 2020.09.24
/// </summary>

using System;
using System.Windows.Forms;
using System.Reflection;

namespace PeakDetector.Forms {
	public partial class FormSetting : Form {
		public FormSetting() {
			InitializeComponent();

			// 설정 기본값 세팅
			Properties.Settings setting = Properties.Settings.Default;
			this.tbHeight.Text = setting.Height.ToString();
			this.tbWidth.Text = setting.Width.ToString();
			this.tbXValue.Text = setting.X.ToString();
			this.tbYValue.Text = setting.Y.ToString();
			this.tbLoopPeriod.Text = setting.LoopPeriod.ToString();

			string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			this.labelInfo.Text = this.labelInfo.Text.Replace("{version}", version);

		}

		/// <summary>
		/// 숫자 변경시 예외처리
		/// </summary>
		/// <param name="value">숫자로 변경할 문자</param>
		/// <returns></returns>
		private int changeToDefault(string value) {
			if (string.IsNullOrWhiteSpace(value))
				return 0;
			else
				return Convert.ToInt32(value);
		}

		/// <summary>
		/// 기본값 저장
		/// </summary>
		private void save() {
			Properties.Settings setting = Properties.Settings.Default;
			setting.Height = this.changeToDefault(this.tbHeight.Text);
			setting.Width = this.changeToDefault(this.tbWidth.Text);
			setting.X = this.changeToDefault(this.tbXValue.Text);
			setting.Y = this.changeToDefault(this.tbYValue.Text);
			setting.Save();
		}

		private void buttonConfirm_Click(object sender, EventArgs e) {
			this.save();
			this.Close();
		}

		private void keyPress_onlyNumber(object sender, KeyPressEventArgs e) {
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) {
				e.Handled = true;
			}
		}
	}
}
