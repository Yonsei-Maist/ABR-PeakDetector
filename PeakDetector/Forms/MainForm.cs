/// <summary>
/// 프로그램 메인 화면
/// @Author Mina Kim, Yonsei Univ. Researcher, since 2020.08
/// @Date 2020.08
/// @Author Chanwoo Gwon, Yonsei Univ. Researcher, since 2020.05
/// @Date 2020.09.24
/// </summary>

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PeakDetector.DetectiveProcess;
using PeakDetector.Forms;

namespace PeakDetector {
	public partial class MainForm : Form {

		public Capture capture;
		public Graph graph;
		public Resource resource;
		public Timer timer;
		private string selectedSeries = "";

		public MainForm() {

			InitializeComponent();
			this.init();
		}

		public void init() {

			this.capture = new Capture(this);
			this.graph = new Graph(this);
			this.resource = new Resource(this);

			// 캡쳐크기가 정해져있지 않은 경우 세팅
			Properties.Settings setting = Properties.Settings.Default;
			if (!setting.IsSet) {

				int width = Screen.PrimaryScreen.Bounds.Width;
				int height = Screen.PrimaryScreen.Bounds.Height;

				setting.X = (int)(width * 0.03);
				setting.Y = (int)(height * 0.11);
				setting.Width = (int)(width * 0.37);
				setting.Height = (int)(height * 0.81);

				setting.Save();
			}
		}

		/// <summary>
		/// Log 컨트롤에 실행 결과 출력
		/// <param name="obj">실행 결과 값</param>
		/// </summary>
		public void debug(Object obj) {

			String now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			// rtbLog.AppendText("[" + now + "] " + obj + "\n");
			// rtbLog.ScrollToCaret();
		}

		/// <summary>
		/// 트레이 아이콘 메뉴바 show 선택 시 프로그램 화면에 띄우기
		/// </summary>
		private void showToolStripMenuItem_Click(object sender, EventArgs e) {

			this.Show();
		}

		/// <summary>
		/// 트레이 아이콘 메뉴바 exit 선택 시 프로그램 종료
		/// </summary>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {

			trayIcon.Visible = false;
			trayIcon.Dispose();
			Application.Exit();
		}

		/// <summary>
		/// 프로그램 닫기 버튼 클릭 시 트레이 아이콘 생성
		/// </summary>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {

			if (e.CloseReason == CloseReason.UserClosing) {
				e.Cancel = true;
				trayIcon.Visible = true;
				this.Hide();
			}
		}

		/// <summary>
		/// capture start 버튼 클릭 시 타이머 동작
		/// </summary>
		private void btnCaptureStart_Click(object sender, EventArgs e) {

			timer = new Timer();
			timer.Interval = 1000;
			Properties.Settings setting = Properties.Settings.Default;

			timer.Interval = setting.LoopPeriod;

			timer.Tick += new EventHandler(timerCapture_Tick);
			this.debug("캡처 시작!");
			timer.Start();

			btnCaptureStart.Enabled = false;
			btnCaptureStart.Hide();
			btnCaptureStop.Enabled = true;
		}

		/// <summary>
		/// 캡처 메서드 호출
		/// </summary>
		private void timerCapture_Tick(object sender, EventArgs e) {

			try {
				this.debug("캡처!");
				this.capture.saveGraphScreenshotByFile();
				this.resource.loadLocalResource(listViewRes);
			} catch (IndexOutOfRangeException ex) // AEP 프로그램 미 실행 예외 처리
			  {
				btnCaptureStop_Click(sender, e);
				Console.WriteLine("Exception source: {0}", ex.Source);
				MessageBox.Show("AEP 프로그램을 실행해주세요.", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			} catch (OutOfMemoryException ex) // AEP 프로그램 full screen 아닐 시 예외 처리
			  {
				btnCaptureStop_Click(sender, e);
				Console.WriteLine("Exception source: {0}", ex.Source);
				MessageBox.Show("AEP 프로그램을 전체 화면으로 설정해주세요.", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
		}

		/// <summary>
		/// capture stop 버튼 클릭 시 캡처 타미어 중지
		/// </summary>
		private void btnCaptureStop_Click(object sender, EventArgs e) {

			this.debug("캡처 중지 !");
			timer.Stop();

			btnCaptureStart.Enabled = true;
			btnCaptureStop.Enabled = false;
			btnCaptureStart.Show();
		}

		/// <summary>
		/// local resource 버튼 클릭 시 로컬 파일 리스트 출력 메서드 호출
		/// </summary>
		private void btnLocalRes_Click(object sender, EventArgs e) {

			this.debug("로컬 파일 로드");
			this.resource.loadLocalResource(listViewRes);
		}

		/// <summary>
		/// delete 버튼 클릭 시 로컬 파일 전체 삭제 메서드 호출
		/// </summary>
		private void btnDelLocalRes_Click(object sender, EventArgs e) {
			DialogResult res = MessageBox.Show("전체삭제", "캡쳐된 이미지를 모두 삭제합니다.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (res == DialogResult.Yes) {
				this.debug("로컬 파일 전체 삭제");
				this.resource.deleteLocalResourceAll(listViewRes);
				this.graph.clearGraph(chartAll, chartDetail);
				labelGraph.Visible = true;
			}
		}

		/// <summary>
		/// 로컬 파일 리스트 더블 클릭 시
		/// 1. 네트워크 메서드 호출 (로컬 파일 전송, 서버 응답 결과 반환)
		/// 2. 서버 응답 데이터 -> 그래프 객체 데이터 변환 메서드 호출
		/// 3. 그래프 생성 메서드 호출 or 그래프 초기화 메서드 호출
		/// </summary>
		private void listViewRes_MouseDoubleClick(object sender, MouseEventArgs e) {

			ListView.SelectedListViewItemCollection items = listViewRes.SelectedItems;
			ListViewItem item = items[0];
			String fileName = item.SubItems[0].Text;
			String filePath = "C:\\temp\\ABR_capture\\";

			Dictionary<string, object> parameters = new Dictionary<string, object>();
			parameters.Add("file", new FormFile() {
				Name = fileName,
				ContentType = "application/png",
				FilePath = filePath + fileName
			});
			parameters.Add("id", Guid.NewGuid());

			string response = Network.PostMultipart("http://165.132.221.45:9120/abr/image/predict", parameters);
			this.debug(response);

			String result = this.graph.createChartList(response); // 분석 데이터 생성

			if (result.Equals("success")) {
				labelGraph.Visible = false;
				this.graph.drawAllGraph(chartAll, chartDetail); // 그래프 생성
				result = "성공";
			} else {
				this.graph.clearGraph(chartAll, chartDetail);
				result = "캡처된 사진이 올바르지 않습니다.";
				MessageBox.Show(result, "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			Console.WriteLine(result);
		}

		/// <summary>
		/// 전체 차트 컨트롤에서 마우스 이동 시
		/// 1. 그래프(시리즈) 굵기 5로 변경 및 커서 모양 변경
		/// 2. 그래프(시리즈) 굵기 2로 변경 및 커서 모양 원래대로
		/// </summary>
		private void chartAll_MouseMove(object sender, MouseEventArgs e) {

			HitTestResult result = this.chartAll.HitTest(e.X, e.Y);

			if (result != null && result.Series != null) {
				string selseries = result.Series.Name;
				selectedSeries = selseries;
				this.chartAll.Series[selseries].BorderWidth = 5;
				System.Windows.Forms.Cursor.Current = Cursors.Hand;
			} else {
				foreach (Series series in this.chartAll.Series) {
					series.BorderWidth = 2; // set these to default value
				}
				selectedSeries = ""; // reset selection
				System.Windows.Forms.Cursor.Current = Cursors.Default;
			}
		}

		/// <summary>
		/// 전체 차트 컨트롤에서 마우스 더블 클릭 시
		/// 상세 차트 화면 출력 메서드 호출
		/// </summary>
		private void chartAll_MouseClick(object sender, MouseEventArgs e) {

			HitTestResult result = chartAll.HitTest(e.X, e.Y);

			if (result != null && result.Series != null) {
				Series series = result.Series;
				graph.drawDetailGraph(chartDetail, series);
			}
		}

		/// <summary>
		/// 상세 차트 컨트롤의 정점에서 마우스 hover 시
		/// 정점 툴팁 생성
		/// </summary>
		private void chartDetail_MouseHover(object sender, EventArgs e) {

			Series sereis = chartDetail.Series.FindByName("Peak");
			if (sereis != null) {
				Series peak = chartDetail.Series[1];
				double peakValue = peak.Points[0].XValue;
				String toolTipText = "Peak : " + peakValue.ToString();
				peak.ToolTip = toolTipText;
			}
		}

		/// <summary>
		/// 화면 로드 시 로컬 파일 자동 로드
		/// </summary>
		private void MainForm_Load(object sender, EventArgs e) {

			this.resource.loadLocalResource(listViewRes);
		}

		private void btnSetting_Click(object sender, EventArgs e) {
			FormSetting form = new FormSetting();
			form.ShowDialog();
		}
	}
}
