using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PeakDetector.DetectiveProcess
{
    public class Graph
    {
        private MainForm mainForm;
        public static GraphData graphData;

        public Graph(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public class GraphData
        {
            public Data data { get; set; }
            public string id { get; set; }
        }
        public class Data
        {
            public List<Extract> extract { get; set; }
        }
        public class Extract
        {
            public double[] graph { get; set; }
            public Peak peak { get; set; }
        }
        public class Peak
        {
            public double prediction { get; set; }
            public double score { get; set; }
        }

        public void createChartList(ListView listViewChart)
        {
            listViewChart.Items.Clear();

            string jsonData = File.ReadAllText(@"C:\\Users\\Min A\\Desktop\\json.txt");
            graphData = JsonConvert.DeserializeObject<GraphData>(jsonData);

            String id = graphData.id;
            Extract extract = graphData.data.extract[0];
            string prediction = extract.peak.prediction.ToString();
            string score = extract.peak.score.ToString();

            String[] data = { graphData.id, " ", prediction };
            ListViewItem item = new ListViewItem(data);
            listViewChart.Items.Add(item);
        }

        public void drawGraph(Chart chart, string id)
        {
            
            for (int i = 0; i < graphData.data.extract.Count; i++)
            {
                Extract extract = graphData.data.extract[i];
                double[] graph = extract.graph;
                double prediction = extract.peak.prediction;

                for (int j = 0; j < graph.Length; j++)
                {
                    double y = graph[j];
                    int aaaa = chart.Series[0].Points.AddY(y);
                } 
            }
        }
    }

}
