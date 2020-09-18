using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PeakDetector.DetectiveProcess;

namespace PeakDetector
{
    public partial class MainForm : Form
    {
        public Capture capture;
        public Graph graph;
        public Resource resource;
        public Timer timer;
        private string selectedSeries = "";

        public MainForm()
        {
            InitializeComponent();
            this.init();
        }
        public void init()
        {
            this.capture = new Capture(this);
            this.graph = new Graph(this);
            this.resource = new Resource(this);
        }
        public void debug(Object obj)
        {
            String now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            rtbLog.AppendText("[" + now + "] " + obj + "\n");
            rtbLog.ScrollToCaret();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                trayIcon.Visible = true;
                this.Hide();
            }
        }

        private void btnCaptureStart_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            if (tbLoopPeriod.Text != "")
            {
                timer.Interval = Int32.Parse(tbLoopPeriod.Text);
            }
            timer.Tick += new EventHandler(timerCapture_Tick);

            this.debug("Capture Start!");
            timer.Start();

            btnCaptureStart.Enabled = false;
            btnCaptureStop.Enabled = true;
        }

        private void timerCapture_Tick(object sender, EventArgs e)
        {         
            try
            {
                this.debug("Capture!");
                this.capture.saveGraphScreenshotByFile(tbResolutionW, tbResolutionH);
            }
            catch(IndexOutOfRangeException ex) 
            {
                btnCaptureStop_Click(sender, e);
                Console.WriteLine("Exception source: {0}", ex.Source);
                MessageBox.Show("Please run the AEP program.");
            }
            catch(OutOfMemoryException ex)
            {
                btnCaptureStop_Click(sender, e);
                Console.WriteLine("Exception source: {0}", ex.Source);
                MessageBox.Show("Please run the program in full screen");
            }
        }

        private void btnCaptureStop_Click(object sender, EventArgs e)
        {
            this.debug("Capture Stop!");
            timer.Stop();

            btnCaptureStart.Enabled = true;
            btnCaptureStop.Enabled = false;
        }

        private void btnLocalRes_Click(object sender, EventArgs e)
        {
            this.debug("Load Local Resource!");
            this.resource.loadLocalResource(listViewRes);
        }

        private void btnDelLocalRes_Click(object sender, EventArgs e)
        {
            this.debug("Delete Local Resource");
            this.resource.deleteLocalResource(listViewRes);
        }

        private void listViewRes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listViewRes.SelectedItems;
            ListViewItem item = items[0];
            String fileName = item.SubItems[1].Text;
            String filePath = "C:\\temp\\ABR_capture\\";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("file", new FormFile()
            {
                Name = fileName,
                ContentType = "application/png",
                FilePath = filePath + fileName
            });
            parameters.Add("id", Guid.NewGuid());

            string response = Network.PostMultipart("http://165.132.221.45:9120/abr/image/predict", parameters);
            this.debug(response);

            String result = this.graph.createChartList(chartAll, chartDetail, response); // 분석 데이터 생성
            this.debug(result);
        }

        private void chartAll_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = this.chartAll.HitTest(e.X, e.Y);

            if (result != null && result.Series != null)
            {
                string selseries = result.Series.Name;
                selectedSeries = selseries;
                this.chartAll.Series[selseries].BorderWidth = 5;
                System.Windows.Forms.Cursor.Current = Cursors.Hand;
            }
            else
            {
                foreach (Series series in this.chartAll.Series)
                {
                    series.BorderWidth = 2; // set these to default value
                }
                selectedSeries = ""; // reset selection
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
        }

        private void chartAll_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = chartAll.HitTest(e.X, e.Y);

            if (result != null && result.Series != null)
            {
                Series series = result.Series;
                graph.drawDetailGraph(chartDetail, series);
            }
        }

        private void chartDetail_MouseHover(object sender, EventArgs e)
        {
            Series sereis = chartDetail.Series.FindByName("Peak");
            if (sereis != null)
            {
                Series peak = chartDetail.Series[1];
                double peakValue = peak.Points[0].XValue;
                String toolTipText = "Peak : " + peakValue.ToString();
                peak.ToolTip = toolTipText;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbResolutionW.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
            tbResolutionH.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
        }

        private void keyPress_onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tbResolutionW_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress_onlyNumber(sender, e);
        }


        private void tbResolutionH_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress_onlyNumber(sender, e);
        }
    }
}
