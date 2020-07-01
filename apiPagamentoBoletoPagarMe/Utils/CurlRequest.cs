/*/
Atualizado em 18/06/2020 -- Responsável: Ubiratan Roberte Cardoso Passos
--- Implementação da função que consome webService(RESTFULL API) via método GET 
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VirtualMarket.apiPagamentoCartaoPagarMe.Utils
{
    public static class CurlRequest
    {
        
        public static string SendRequest(string destURL ,string requestContent, string method)
        {

            byte[] byteArray = Encoding.UTF8.GetBytes(requestContent);

            if (method.Equals("GET")){
                string parseContent = requestContent.Replace('{','?');
                parseContent = parseContent.Replace('"', ' ');
                parseContent = parseContent.Replace(':', '=');
                parseContent = parseContent.Replace(',', '&');
                parseContent = parseContent.Replace('}', ' ');
                parseContent = parseContent.Replace(" ", "");
                destURL = destURL + parseContent.Trim(); ;
            }


            var httpWebRequest = (HttpWebRequest)WebRequest.Create(destURL);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = method;
            
            if (method.Equals("POST"))
            {
                httpWebRequest.ContentLength = byteArray.Length;
                Stream dataStream = httpWebRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
            }

            string responseText = "";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var reader = new System.IO.StreamReader(httpResponse.GetResponseStream(), ASCIIEncoding.UTF8))
            {
                responseText = reader.ReadToEnd();
            }

            return responseText;

        }

    }
}
