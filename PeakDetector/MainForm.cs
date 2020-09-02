using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PeakDetector.DetectiveProcess;

namespace PeakDetector
{
    public partial class MainForm : Form

    {
        public Capture capture;
        public Resource resource;
        private Timer timer;

        public MainForm()
        {
            InitializeComponent();
            this.init();
        }

        public void init()
        {
            this.capture = new Capture(this);
            this.resource = new Resource(this);
        }

        public void debug(Object obj)
        {
            String now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            rtbLog.AppendText("[" + now + "] " + obj + "\n");
            rtbLog.ScrollToCaret();
        }

        // 트레이 아이콘 Shown Button
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        // 트레이 아이콘 Close Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                trayIcon.Visible = true;
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

            btnFullCaptureStart.Enabled = false;
            btnCaptureStart.Enabled = false;
            btnCaptureStop.Enabled = true;
        }

        private void timerCapture_Tick(object sender, EventArgs e)
        {
            this.debug("Capture!");
            this.capture.doCaptureByFile(panelCaptureArea);
        }

        private void btnFullCaptureStart_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            if (tbLoopPeriod.Text != "")
            {
                timer.Interval = Int32.Parse(tbLoopPeriod.Text);
            }
            timer.Tick += new EventHandler(timerFullCapture_Tick);

            this.debug("Full Capture Start!");
            timer.Start();

            btnFullCaptureStart.Enabled = false;
            btnCaptureStart.Enabled = false;
            btnCaptureStop.Enabled = true;
        }

        private void timerFullCapture_Tick(object sender, EventArgs e)
        {
            this.debug("Full Capture!");
            // this.capture.showWindowABR();
            this.capture.doFullCaptureByFile();
        }

        private void btnCaptureStop_Click(object sender, EventArgs e)
        {
            this.debug("Capture Stop!");
            timer.Stop();

            btnFullCaptureStart.Enabled = true;
            btnCaptureStart.Enabled = true;
            btnCaptureStop.Enabled = false;
        }

        private void btnLocalRes_Click(object sender, EventArgs e)
        {
            this.debug("Load Local Resource!");
            this.resource.loadLocalResource(listViewRes);
        }

        private void listViewRes_MouseDoubleClick(object sender, EventArgs e)
        {
            if(listViewRes.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listViewRes.SelectedItems;
                ListViewItem item = items[0];
                String fileName = item.SubItems[1].Text;
                String filePath = "C:\\temp\\ABR_capture\\";

                using (FileStream stream = new FileStream(filePath+fileName, FileMode.Open, FileAccess.Read))
                {
                    pbResourceArea.Image = Image.FromStream(stream);
                    stream.Dispose();
                }
            }
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listViewRes.Items)
            {
                if (checkBoxAll.Checked == true)
                    item.Checked = true;
                else
                    item.Checked = false;
            }
        }

        private void btnDelLocalRes_Click(object sender, EventArgs e)
        {
            pbResourceArea.Image = null;
            this.resource.deleteLocalResource(listViewRes);
        }

        private void btnTransferFiles_Click(object sender, EventArgs e)
        {
            //this.resource.transferCaptureFiles(listViewRes);
            //this.debug(result);
        }

    }

}
