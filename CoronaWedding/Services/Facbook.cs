using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoronaWedding.Services
{
    public class Facbook
    {
        private const string token = "EAAFCQAhcjKoBAKKVnIGxEA2ANylZCJsMHbfgksTkREA6tLy0mDuveiajh5bD4x3MAoXU3yXHZCy6MQVKnLq2MJGtZAoZCB9Gbkh1E6DwHV6qryCLUjyoJLZBZBuJCRxPkQOTcL00tha7JRQUA2eb8pytBGzPkdc3Oo1CkruaKvZAGuJPhZBUWYiQMJzMB1Io1yZBZBhdBlRbw8ZAWElbkY7ZA450MSzZBPvRfh3XUfGkuhWTCsQZDZD";
        public static async void PostToPage(string postContent)
        {
            var url = $"https://graph.facebook.com/354317762333866/feed?message={postContent}&access_token={token}";
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.PostAsync(url, new StringContent(""))) 
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}
