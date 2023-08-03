//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Collections;
using Microsoft.AspNetCore.SignalR.Client;

namespace ConsoleApp1
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //HttpClient _httpClient = new HttpClient();
            //string Teststring = "123";
            //Encoding SourceEncoding = Encoding.GetEncoding("shift-jis");
            //Encoding TargetEncoding = Encoding.UTF8;
            //byte[] UnicodeBytes = TargetEncoding.GetBytes(Teststring);
            //byte[] JapaneeseBytes = Encoding.Convert(TargetEncoding, SourceEncoding, UnicodeBytes);
            //char[] JapaneseChars = new char[SourceEncoding.GetCharCount(JapaneeseBytes, 0, JapaneeseBytes.Length)];
            //SourceEncoding.GetChars(JapaneeseBytes, 0, JapaneeseBytes.Length, JapaneseChars, 0);
            //string JapaneseString = new string(JapaneseChars);


            //string test = System.Text.Encoding.GetEncoding(932).GetString(JapaneeseBytes);
            //Console.Write(test);
            //Console.ReadLine();
            //var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7286/api/Reception/Test");
            //var temp = new DeleteReceptionRequest { PtId = 1, SinDate = 20230101, Flag = true };
            //string serializedUser = JsonConvert.SerializeObject(temp);
            //requestMessage.Headers.Authorization
            //  = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VySWQiOiIyIiwiSHBJZCI6IjEiLCJEZXBhcnRtZW50SWQiOiIxIiwianRpIjoiZDg2NmY3NmQtYzJlZS00NzE0LTkwOWUtNzU4OTRhMzAxODg0IiwiZXhwIjoxNjg2NDQ5MTg4fQ.3S2oH2LQ0PZtzc6GMld7fFry9WnOcTUN3TuGwm75cfk");
            //requestMessage.Content = new StringContent(serializedUser);
            //requestMessage.Content.Headers.ContentType
            //  = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //var response = await _httpClient.SendAsync(requestMessage);
            //var temp1 = response.StatusCode;


            //var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7286/api/History/GetList?PtId=19535&HpId=1&SinDate=20230531&UserId=2&Limit=1000&DeleteCondition=0&FilterId=0&IsShowApproval=1&Offset=0");
            //var temp = new List<long> { 800913277 , 800923114 };
            //string serializedUser = JsonConvert.SerializeObject(temp);
            //requestMessage.Headers.Authorization
            //  = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VySWQiOiIyIiwiSHBJZCI6IjEiLCJEZXBhcnRtZW50SWQiOiIxIiwianRpIjoiMjAxMzkzZDYtZDIyOC00OGVkLWIzMDAtOWY2MTgyZTAyOTMxIiwiZXhwIjoxNjg2NzIxMDAyfQ.7bM8JCSyCtQMrqmzTTnUhXe5vrOqA-nKJSbFq1Jt1CY");
            //requestMessage.Content = new StringContent(serializedUser);
            //requestMessage.Content.Headers.ContentType
            //  = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //var response = await _httpClient.SendAsync(requestMessage);
            //var content = response.Content.ReadAsStringAsync().Result;
            //var temp1 = response.StatusCode;
            //var dateTime = DateTime.UtcNow;
            //var dateTime1 = dateTime.AddMinutes(1);
            //if (dateTime1 > dateTime)
            //{
            //    Console.WriteLine("Done");
            //}

            //var content = JsonContent.Create(new CalculateMonthRequest { HpId = 1, SeikyuYm = 202308, PtIds = new List<long>(), PreFix = "" });

            //var httpMessage = new HttpRequestMessage();

            //var response =  _httpClient.PostAsync($"https://localhost:7146/api/Calculate/RunCalculateMonth", content);
            //var temp = response.Result;
            //Console.WriteLine(temp.Content.);
            //Console.ReadLine();

            // Creates an HttpWebRequest with the specified URL.
            //var myHttpWebRequest = WebRequest.Create("https://localhost:7146/api/Calculate/RunCalculateMonth");

            //myHttpWebRequest.Method = "POST";

            //var calculate = new CalculateMonthRequest { HpId = 1, SeikyuYm = 202308, PtIds = new List<long>(), PreFix = "" };
            //var json = JsonSerializer.Serialize(calculate);
            //byte[] byteArray = Encoding.UTF8.GetBytes(json);

            //myHttpWebRequest.ContentType = "application/json";
            //myHttpWebRequest.ContentLength = byteArray.Length;

            //using var reqStream = myHttpWebRequest.GetRequestStream();
            //reqStream.Write(byteArray, 0, byteArray.Length);
            //// Sends the HttpWebRequest and waits for the response.			
            //HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            //// Gets the stream associated with the response.
            //Stream receiveStream = myHttpWebResponse.GetResponseStream();
            //Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            //// Pipes the stream to a higher level stream reader with the required encoding format.
            //StreamReader readStream = new StreamReader(receiveStream, encode);
            //Console.WriteLine("\r\nResponse stream received.");
            //Char[] read = new Char[256];
            //// Reads 256 characters at a time.
            //int count = readStream.Read(read, 0, 256);
            //Console.WriteLine("HTML...\r\n");
            //while (count > 0)
            //{
            //    // Dumps the 256 characters on a string and displays the string to the console.
            //    String str = new String(read, 0, count);
            //    Console.Write(str);
            //    count = readStream.Read(read, 0, 256);
            //}
            //Console.WriteLine("");
            //// Releases the resources of the response.
            //myHttpWebResponse.Close();
            //// Releases the resources of the Stream.
            //readStream.Close();

            //var request = WebRequest.Create($"https://localhost:7146/Calculate/RunCalculateMonth");
            //request.Method = "POST";
            //request.ContentType = "application/json";
            //request.

            //using var webResponse = request.GetResponse();
            //using var webStream = webResponse.GetResponseStream();

            //using var reader = new StreamReader(webStream);
            //while ()
            //{
            //    var item = reader.Read();
            //}
            //var data = reader.ReadToEnd();

            //Console.WriteLine(data);

            //WebRequest wRequest = WebRequest.Create("https://localhost:7146/Calculate/RunCalculateMonth");
            //wRequest.Method = "POST";
            //string postString = "This message send to webserver";
            //byte[] bArray = Encoding.UTF8.GetBytes(postString);
            //wRequest.ContentType = "application/x-www-form-urlencoded";
            //wRequest.ContentLength = bArray.Length;
            //Stream webData = wRequest.GetRequestStream();
            //webData.Write(bArray, 0, bArray.Length);
            //webData.Close();

            //using (var hubConnection = new HubConnection("http://www.contoso.com/"))
            //{
            //    IHubProxy stockTickerHubProxy = hubConnection.CreateHubProxy("stockTicker");
            //    stockTickerHubProxy.On<Stock>("UpdateStockPrice", stock =>
            //        Console.WriteLine("Stock update for {0} new price {1}", stock.Symbol, stock.Price));
            //    await hubConnection.Start();
            //}

            string socketUrl = "wss://localhost:7286/CommonHub?tenantId=uat-tenant.smartkarte.org";
            var connection = new HubConnectionBuilder()
                              .WithUrl(socketUrl)
                              .Build();

            var connect = connection.StartAsync();
            connect.Wait();

            connection.On<string, string>("ReceiveMessage", (function, data) =>
            {
                Console.WriteLine(data);
            });
            //await connection.StartAsync();


            //Console.WriteLine(console);
            Console.ReadLine();
        }

        public class DeleteReceptionRequest
        {
            public long PtId { get; set; }

            public int SinDate { get; set; }

            public bool Flag { get; set; }
        }

        public class CalculateMonthRequest
        {
            public int HpId { get; set; }

            public int SeikyuYm { get; set; }

            public List<long> PtIds { get; set; } = new List<long>();

            public string PreFix { get; set; } = string.Empty;
        }


    }
}
