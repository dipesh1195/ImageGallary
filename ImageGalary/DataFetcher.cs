using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;

namespace ImageGalary
{
    
     class DataFetcher
    {
           async Task<string> GetDatafromService(string searchstring)
        {
            string readText = null;
            try
            {
                var azure = @"https://imagefetcher20200529182038.azurewebsites.net";
                string url = azure + @"/api/fetch_images?query=" + searchstring + "&max_count=5";
                using (HttpClient c = new HttpClient())
                {
                    readText = await c.GetStringAsync(url);
                }
            }
            catch
            {
                readText = File.ReadAllText(@"C:/Users/Dipesh Kushwaha/source/repos/ImageGalary/ImageGalary/Data/sampleData.json");
            }

            return readText;
        }
          public async Task<List<Imageitem>> GetImageData(string search)
        {
            string data = await GetDatafromService(search);
            return JsonConvert.DeserializeObject<List<Imageitem>>(data);
        }
        
    }
}
