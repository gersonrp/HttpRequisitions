using System;
using System.Net;

namespace ConsumindoWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var get = HttpRequisitons.Get("https://httpbin.org/get");

            Console.WriteLine("Result for Get: " + get.ToString());

            Console.WriteLine("Result for Get: "+ 
                ViaCep.GetCep("13223400")
            );

            var post = HttpRequisitons.Post(
                "http://localhost:54085/api/webservices/gravardados",
                new HttpRequisitons.Options
                {
                    ContentType = "application/json",
                    PostData = "'Teste'"
                }
            );

            Console.WriteLine("Result for post: \n "+ post.ToString());

            var put = HttpRequisitons.Put(
                "http://localhost:54085/api/webservices/5",
                new HttpRequisitons.Options
                {
                    ContentType = "application/json",
                    PostData = "'Teste'"
                }
            );

            Console.WriteLine("Result for put: \n " + put.ToString());

            // Options is not required here
            var delete = HttpRequisitons.Delete(
                "http://localhost:54085/api/webservices/5"
            );

            Console.WriteLine("Result for delete: \n " + delete.ToString());

        }
    }
}
