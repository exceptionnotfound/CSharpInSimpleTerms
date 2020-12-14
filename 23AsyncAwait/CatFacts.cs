using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _23AsyncAwait
{
    public class CatFacts
    {
        public async Task<CatFact> GetRandomFact()
        {
            var url = "https://cat-fact.herokuapp.com/facts/random?number=1";

            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();

            var fact = JsonSerializer.Deserialize<CatFact>(responseString);

            return fact;
        }
    }

    public class CatFact
    {
        public string text { get; set; }
        public string type { get; set; }
        public DateTime updated_at { get; set; }
    }
}
