using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Hosting.Self;
using Microsoft.Owin.Hosting;
using NancyApiTokenAuth;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //var config = new HostConfiguration(); config.UrlReservations.CreateAutomatically = true;
            //var NancyApiTokenAuth = new NancyApiTokenAuth(config, new Uri("http://localhost:1234"));
            //NancyApiTokenAuth.Start();
            //Console.WriteLine("Service started!");
            //Console.ReadLine();
            //NancyApiTokenAuth.Stop();
            //Console.WriteLine("Service stoped!");
            const string url = "http://localhost:8080";

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();
            }
        }
    }
}
