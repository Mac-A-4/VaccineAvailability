using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;
using System.IO;

namespace COVID21
{

    internal class MyTurnRequest
    {

        protected U Request<T, U>(string url, T input) {
            var request = WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "POST";
            using (var stream = new StreamWriter(request.GetRequestStream())) {
                stream.Write(JsonSerializer.Serialize(input));
            }
            var response = request.GetResponse();
            using (var stream = new StreamReader(response.GetResponseStream())) {
                var result = stream.ReadToEnd();
                return JsonSerializer.Deserialize<U>(result);
            }
        }

    }

}
