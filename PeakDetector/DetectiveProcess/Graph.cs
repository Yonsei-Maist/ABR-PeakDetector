using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

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
            public int prediction { get; set; }
            public double score { get; set; }
        }

        public void createChartList(Chart chartAll, Chart chartDetail, string jsonData)
        {
            graphData = JsonConvert.DeserializeObject<GraphData>(jsonData);
            drawAllGraph(chartAll, chartDetail);
        }

        public void drawAllGraph(Chart chartAll, Chart chartDetail)
        {
            chartDetail.Series.Clear();
            foreach (Series series in chartAll.Series)
            {
                series.Points.Clear();
            }
            
            for (int i=0; i<graphData.data.extract.Count; i++)
            {
                Extract extract = graphData.data.extract[i]; // 분석 데이터
                double[] grpah = extract.graph; // graph 좌표 데이터
                double prediction = extract.peak.prediction; // peak 예측 x값
                double score = extract.peak.score; // score 값

                for (int j=0; j<grpah.Length; j++)
                {
                    double y = grpah[j]; // y값
                    chartAll.Series[i].Points.AddY(y); // graph point 추가
                }
            }
        }

        public void drawDetailGraph(Chart chartDetail, Series series)
        {
            chartDetail.Series.Clear();

            int extractIndex = Int32.Parse(series.Name.Substring(6, 1))-1; // 그래프 index
            Extract extract = graphData.data.extract[extractIndex]; // 분석 데이터

            int x = extract.peak.prediction; // peak 예측 y값
            double y = series.Points[x].YValues[0]; // peak 예측 x값

            chartDetail.ChartAreas[0].AxisX.Maximum = extract.graph.Length; // 축값 조정
            chartDetail.Series.Add(series); // graph 추가

            Series peak = new Series();
            peak.Name = "Peak";
            peak.ChartType = SeriesChartType.Point;
            peak.MarkerSize = 8;
            peak.MarkerStyle = MarkerStyle.Circle;
            chartDetail.Series.Add(peak);
            peak.Points.AddXY(x, y); // peak point 추가             
        }
    }

}
