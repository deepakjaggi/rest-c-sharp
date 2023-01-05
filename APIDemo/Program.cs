using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("api/users/2");
            request.AddHeader("Accept", "application/json");

            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            Console.ReadKey();
        }
    }
}
