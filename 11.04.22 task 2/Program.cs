using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace _11._04._22_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string resp = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;
            
            List<User> users = JsonConvert.DeserializeObject<List<User>>(resp);
            foreach (User item in users)
            {
                Console.WriteLine(item.title);
            }
        }
    }
}
