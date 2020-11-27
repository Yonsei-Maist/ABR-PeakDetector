/// <summary>
/// 1. 서버 응답 데이터(json)를 그래프 객체로 변환, Convert server response data (json) to graph object
/// 2. 전체 그래프 화면 출력, Display the entire graph screen
/// 3. 선택 그래프 화면 출력, Display the selection graph screen
/// 4. 정점 화면 출력, Display the vertex screen
/// 5. 전체 그래프, 선택 그래프 화면 초기화, Initialize the entire graph, selected graph screen
/// @Author Mina Kim, Yonsei University Researcher, since 2020.08
/// @Date 2020.09.21
/// </summary>

using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

namespace PeakDetector.DetectiveProcess {

	public class Graph {

		private MainForm mainForm;
		public static GraphData graphData;

		public Graph(MainForm mainForm) {

			this.mainForm = mainForm;
		}

		public class GraphData {
			public Data data { get; set; }
			public string id { get; set; }
			public string result { get; set; }
		}

		public class Data {
			public List<Extract> extract { get; set; }
		}

		public class Extract {
			public double[] graph { get; set; }
			public Peak peak { get; set; }
		}

		public class Peak {
			public int prediction { get; set; }
			public double score { get; set; }
		}

		/// <summary>
		/// 서버 응답 데이터(json)를 그래프 객체로 변환(역직렬화)
		/// Convert server response data (json) to graph object (deserialize)
		/// </summary>
		/// <param name="jsonData">서버로부터 응답받은 데이터, Data received from the server</param>
		/// <returns>서버 응답 결과(success/fail), Server response result</returns>
		public string createChartList(string jsonData) {

			graphData = JsonConvert.DeserializeObject<GraphData>(jsonData);
			return graphData.result;
		}

		/// <summary>
		/// 전체 그래프 화면 출력
		/// Full graph display
		/// </summary>
		/// <param name="chartAll">전체 차트 컨트롤, Full chart control</param>
		/// <param name="chartDetail">선택 차트 컨트롤, Selection chart control</param>
		public void drawAllGraph(Chart chartAll, Chart chartDetail) {

			clearGraph(chartAll, chartDetail);

			for (int i = 0; i < graphData.data.extract.Count; i++) {
				Extract extract = graphData.data.extract[i]; // 분석 데이터
				double[] grpah = extract.graph; // graph 좌표 데이터

				Series series = new Series();
				series.ChartType = SeriesChartType.Line;
				for (int j = 0; j < grpah.Length; j++) {
					double y = grpah[j]; // y값
					series.Points.AddY(y); // graph point 추가
				}

				chartAll.Series.Add(series);
			}
		}

		/// <summary>
		/// 선택 그래프 화면 출력
		/// Display selection graph screen
		/// </summary>
		/// <param name="chartDetail">선택 차트 컨트롤, Selection chart control</param>
		/// <param name="series">전체 차트 컨트롤에서 선택된 시리즈, Series selected in the entire chart control</param>
		public void drawDetailGraph(Chart chartDetail, Series series) {

			chartDetail.Series.Clear();

			int extractIndex = Int32.Parse(series.Name.Substring(6, 1)) - 1; // 그래프 index
			Extract extract = graphData.data.extract[extractIndex]; // 분석 데이터

			int x = extract.peak.prediction; // peak 예측 y값
			double y = series.Points[x].YValues[0]; // peak 예측 x값

			chartDetail.ChartAreas[0].AxisX.Maximum = extract.graph.Length; // 축값 조정
			chartDetail.Series.Add(series); // graph 추가

			drawPeak(chartDetail, x, y);
		}

		/// <summary>
		/// 정점 화면 출력
		/// Vertex screen output
		/// </summary>
		/// <param name="chartDetail">선택 차트 컨트롤, Selection chart control</param>
		/// <param name="x">정점 예측 x값, Vertex prediction x-value</param>
		/// <param name="y">정점 예측 y값, Vertex prediction y-value</param>
		public void drawPeak(Chart chartDetail, int x, double y) {

			Series peak = new Series();
			peak.Name = "Peak";
			peak.ChartType = SeriesChartType.Point;
			peak.MarkerSize = 8;
			peak.MarkerStyle = MarkerStyle.Circle;

			chartDetail.Series.Add(peak);
			peak.Points.AddXY(x, y); // peak point 추가             
		}

		/// <summary>
		/// 전체 그래프, 선택 그래프 화면 초기화
		/// Initialize the entire graph, selected graph screen
		/// </summary>
		/// <param name="chartAll">전체 차트 컨트롤, Full chart control</param>
		/// <param name="chartDetail">선택 차트 컨트롤, Selection chart control</param>
		public void clearGraph(Chart chartAll, Chart chartDetail) {
			chartAll.Series.Clear();
			chartDetail.Series.Clear();
		}
	}

}
