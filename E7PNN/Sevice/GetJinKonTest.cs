
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CSHttpClientSample 
{
    public class GetJinKonTest 
    {

        static async Task<string> Microsoft_Computer_Vision_API(string API_key, string API_Analyze_Picture_Url)
          //  Microsoft_Computer_Vision_API副程式
          //  呼叫Microsoft_Computer_Vision_API副程式時需傳入API金鑰(key)與欲分析影像Url
      {                                                                                                            //  進入Microsoft_Computer_Vision_API副程式
           var client = new HttpClient();                //  宣告client為HttpClient(Http客戶端新執行個體)
           var queryString = HttpUtility.ParseQueryString(string.Empty);
           //  宣告queryString為HttpUtility.ParseQueryString字串
           // Request headers
           client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", API_key);
    //  設定標頭資訊Request headers
    // Request parameters
          queryString["visualFeatures"] = "Categories";
    //  設定"visualFeatures"資訊為"Categories"
    //queryString["details"] = "{string}";
             var Request_Url = "https://api.projectoxford.ai/vision/v1.0/analyze?" + queryString;
        //  設定連線Request URL
            HttpResponseMessage response;
        //  宣告response為HttpResponseMessage物件
        // Request body
        //byte[] byteData = Encoding.UTF8.GetBytes("{\"url\":\"" + "http://kingofwallpapers.com/book/book-004.jpg" + "\"}");
        //  以上為固定Url寫法
          byte[] byteData = Encoding.UTF8.GetBytes("{\"url\":\"" + API_Analyze_Picture_Url + "\"}");
    //  設定Request body字串

    using (var content = new ByteArrayContent(byteData))
    {
        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
       //Console.WriteLine(content.Headers.ToString());
      //  終端機顯示ContentType
         response = await client.PostAsync(Request_Url, content);
     }
          return await response.Content.ReadAsStringAsync();
         //  回傳辨識結果字串
}          

    }
}//  結束Microsoft_Computer_Vision_API副程式