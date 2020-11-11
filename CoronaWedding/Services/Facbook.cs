using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoronaWedding.Services
{
    public class Facbook
    {
        private const string token = "EAAFCQAhcjKoBAP95zb5vW6lcA9ZCLwOtaKY88tiZCNTFJXgZC9M095VFfidBnxCxLZA62dFQym5B99drzv9KhY3XN7jPwbOzinmGjqvblVC0ZA4JnmTHCk1mNZABF1WMH9PXyIYQIGHnzxBGldIaienklzadgxhMP8dT9TQ7ckZCA8E9pBRVZAOg1Tr1Gd9tGGgZD";
        public static async void PostToPage(string postContent)
        {
            var url = $"https://graph.facebook.com/105162454734818/feed?message={postContent}&access_token={token}";
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
