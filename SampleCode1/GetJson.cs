using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SharepointUrlUpdater
{
    internal class GetJson
    {
        public string URL { get; set; }

        public async Task<List<Post>> GetDataAsync()
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(URL);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    var posts = JsonSerializer.Deserialize<List<Post>>(responseBody, options);

                    return posts;

                    //Console.WriteLine(data);
                    // Now you can work with the 'data' object
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
