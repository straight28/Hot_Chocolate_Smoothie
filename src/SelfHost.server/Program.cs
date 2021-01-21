using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost.server
{
    class Program
    {
        static void Main(string[] args)
        {

            string url = "http://localhost:9090";

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine($" Services started at : {DateTime.Now:D} at Url: {url} ");
                Console.ReadLine();
            }
        }
    }
}
