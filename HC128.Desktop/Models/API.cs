using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HC128.Desktop.Models
{
    public static class API
    {
        public static async Task<List<string>> GetImageName(string url)
        {
            var path = url + @"/api/Image/Names";
            string responseString = "";
            using (HttpClient client = new HttpClient())
            {
                responseString = await client.GetStringAsync("http://"+path);
            }

            return JsonConvert.DeserializeObject<List<string>>(responseString);
        }

        public static async Task<ImgAPI> GetImageDetail(string url, string name)
        {
            var path = url + @"/api/Image/" + name;
            string responseString = "";
            using (HttpClient client = new HttpClient())
            {
                responseString = await client.GetStringAsync("http://" + path);
            }

            return JsonConvert.DeserializeObject<ImgAPI>(responseString);
        }
    }
}
