using JulianaSosaAPIPublica.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulianaSosaAPIPublica.Services
{
    public class JSApodService
    {
    
            public async Task<JSApod> GetImage(DateTime dt)
            {
                JSApod dto=null;
                HttpResponseMessage response;
                string requestUrl = $"https://api.nasa.gov/planetary/apod?date={dt.ToString("yyyy-MM-dd")}&api_key=VqAcRXxrbpDz4F87wvLL6pNsMBZoekLKDF2q9HNv";
                try
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
                    HttpClient client = new HttpClient();
                    response = await client.SendAsync(request);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dto = JsonConvert.DeserializeObject<JSApod>(json);
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    throw;
                }
                return dto;
            }
        
    }
}
