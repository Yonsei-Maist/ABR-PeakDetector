﻿/// <summary>
/// 1. 로컬 파일 리스트 출력
/// 2. 선택된 로컬 파일 삭제
/// @Author Mina Kim, Yonsei University Researcher, since 2020.08
/// @Date 2020.09.21
/// </summary>

using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace PeakDetector.DetectiveProcess {
    
    public class Resource {

        private MainForm mainForm;
        private const String FILE_PATH = "C:\\temp\\ABR_capture";

        public Resource(MainForm mainForm) {

            this.mainForm = mainForm;
        }

        /// <summary>
        /// 로컬 파일 리스트 출력
        /// </summary>
        /// <param name="listViewRes">리스트 뷰 컨트롤</param>
        public void loadLocalResource(ListView listViewRes) {
            DirectoryInfo directoryInfo = new DirectoryInfo(FILE_PATH);
            if (directoryInfo.Exists == false) {
                directoryInfo.Create();
            }

            listViewRes.Items.Clear();

            var files = (from file in Directory.GetFiles(FILE_PATH)
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                         }).ToList();

            foreach (var f in files) 
            {
                String[] data = { f.Name};
                ListViewItem item = new ListViewItem(data);
                listViewRes.Items.Add(item);
            }
        }

        /// <summary>
        /// 전체 로컬 파일 삭제
        /// </summary>
        public void deleteLocalResourceAll(ListView listViewRes) {

            foreach (ListViewItem item in listViewRes.Items)
            {
                String fileName = item.SubItems[0].Text;
                File.Delete(FILE_PATH + "\\" + fileName);
            }
            this.loadLocalResource(listViewRes);     
        }

        /// <summary>
        /// 선택된 로컬 파일 삭제
        /// </summary>
        /// <param name="listViewRes">리스트 뷰 컨트롤</param>
        public void deleteLocalResource(ListView listViewRes) {

            if(listViewRes.CheckedItems.Count >0) 
            {
                foreach (ListViewItem item in listViewRes.CheckedItems) 
                {
                    String fileName = item.SubItems[0].Text;
                    File.Delete(FILE_PATH + "\\" + fileName);
                }
                this.loadLocalResource(listViewRes);
            }   
        }
    }
}
