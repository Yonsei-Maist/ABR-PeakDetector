using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Net;
using System.Drawing;
using Newtonsoft.Json.Linq;
using System.Drawing.Imaging;

namespace PeakDetector.DetectiveProcess
{
    public class Resource
    {
        private MainForm mainForm;
        private const String FILE_PATH = "C:\\temp\\ABR_capture";

        public Resource(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void loadLocalResource(ListView listViewRes)
        {
            listViewRes.Items.Clear();

            var files = (from file in Directory.GetFiles(FILE_PATH)
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                         }).ToList();

            foreach (var f in files)
            {
                String[] data = { "", f.Name};
                ListViewItem item = new ListViewItem(data);
                listViewRes.Items.Add(item);
            }
        }

        public void deleteLocalResource(ListView listViewRes)
        {
            if(listViewRes.CheckedItems.Count >0)
            {
                foreach (ListViewItem item in listViewRes.CheckedItems)
                {
                    String fileName = item.SubItems[1].Text;
                    File.Delete(FILE_PATH + "\\" + fileName);
                }
                this.loadLocalResource(listViewRes);
            }   
        }
    }
}
