///
/// 이미지를 읽어 서버에 전송
/// 1. 로컬 이미지 읽기
/// 2. 서버 전송 (multipart/form-data)
/// 3. Response 반환
/// @Author Chanwoo Gwon, Yonsei University Researcher, since 2020.05
/// @Date 2020.09.
///

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace PeakDetector.DetectiveProcess {
	public class FormFile {
		public string Name { get; set; }
		public string ContentType { get; set; }
		public string FilePath { get; set; }
	}

	public class Network {

		/// <summary>
		/// 서버로 파일 전송
		/// 출처 : https://spirit32.tistory.com/21
		/// </summary>

		/// <summary>
		/// multipart/form-data로 파일 및 파라미터 전송
		/// </summary>
		/// <param name="url">서버 url</param>
		/// <param name="parameters">서버로 전송할 파라미터</param>
		/// <returns>서버로부터 응답</returns>
		public static string PostMultipart(string url, Dictionary<string, object> parameters) {

			string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
			byte[] boundaryBytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.ContentType = "multipart/form-data; boundary=" + boundary;
			request.Method = "POST";
			request.KeepAlive = true;
			request.Credentials = System.Net.CredentialCache.DefaultCredentials;

			if (parameters != null && parameters.Count > 0) {
				// 서버로 전송할 request 작성
				using (Stream requestStream = request.GetRequestStream()) {

					foreach (KeyValuePair<string, object> pair in parameters) {

						requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
						if (pair.Value is FormFile) {
							// 파일일 경우
							FormFile file = pair.Value as FormFile;
							string header = "Content-Disposition: form-data; name=\"" + pair.Key + "\"; filename=\"" + file.Name + "\"\r\nContent-Type: " + file.ContentType + "\r\n\r\n";
							byte[] bytes = System.Text.Encoding.UTF8.GetBytes(header);
							requestStream.Write(bytes, 0, bytes.Length);
							byte[] buffer = new byte[32768];
							int bytesRead;

							using (FileStream fileStream = File.OpenRead(file.FilePath)) {
								while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
									requestStream.Write(buffer, 0, bytesRead);
								fileStream.Close();
							}
						} else {
							// 일반 파라미터일 경우
							string data = "Content-Disposition: form-data; name=\"" + pair.Key + "\"\r\n\r\n" + pair.Value;
							byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
							requestStream.Write(bytes, 0, bytes.Length);
						}
					}

					byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
					requestStream.Write(trailer, 0, trailer.Length);
					requestStream.Close();
				}
			}

			using (WebResponse response = request.GetResponse()) {
				using (Stream responseStream = response.GetResponseStream()) {
					using (StreamReader reader = new StreamReader(responseStream))
						return reader.ReadToEnd();
				}
			}
		}
	}
}