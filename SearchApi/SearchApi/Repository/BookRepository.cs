using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Deserializers;
using SearchApi.Intefaces;
using SearchApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SearchApi.Repository
{
    public class BookRepository :  IBook
    {
       
        public Task<Book> SearchBookById(string bookId)
        {
            throw new NotImplementedException();
        }

        public static HttpClient httpClient()
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient client = new HttpClient(handler);
            client.Timeout = new TimeSpan(1, 1, 6000, 200, 0);
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            return client;
        }
        public async Task<List<Book>> SearchBookByTitle(string param)
        {
            
            List<Book> books = new List<Book>();
            HttpClient client = httpClient();

            string path = $"http://openlibrary.org/search.json?q={param}";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage APIResponse = client.GetAsync(path).Result;

            if (APIResponse.IsSuccessStatusCode)
            {
                string JsonContent = APIResponse.Content.ReadAsStringAsync().Result;

               var list = JObject.Parse(JsonContent)["docs"].Select(m => m).ToList();
                foreach (var item in list)
                {
                    var jsonResult = JsonConvert.DeserializeObject(item.ToString()).ToString();
                    var book = JsonConvert.DeserializeObject<Book>(jsonResult);

                    books.Add(book);
                }
             
            }
            return books;
        }
    }
}
