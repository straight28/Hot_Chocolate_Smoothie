using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Selfhost.ConsoleClient
{
    class Program
    {

        static string[] GetFromServer()
        {
            var client = new HttpClient();
            var response = client.GetAsync("http://localhost:9090/api/product").Result;
            var result = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                //return result;
            }
            return null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($" 계속하려면 enterkey를 누르세요 ");
            Console.ReadLine();

            GetFromServer().ToList().ForEach(p =>
            {
                Console.WriteLine($"Iten : {p} ");

            });
            Console.ReadLine();
        }

    }
}
