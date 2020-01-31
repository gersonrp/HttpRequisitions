# HttpRequisitions
Two classes for Csharp that you'll love!
This classes makes a easy way to build an C# application with requisitions.

It's simple, just add this classes to your project and use it.

# Getting Started
Download code and use with no restrictions.

# ! Warning !
This requisitions don't allow edit Authorizations, this funcionality is note present in this project yet.

# Basic Usage

    class Program
    {
        static void Main(string[] args)
        {
            var get = HttpRequisitons.Get("https://httpbin.org/get");

            Console.WriteLine("Result for Get: " + get.ToString());

            Console.WriteLine("Result for Get: "+ 
                ViaCep.GetCep("<Digite seu cep>")
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
                    PostData = "'Test'"
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
    
# Support
Send me an e-mail at gerson@jedisistemas.com.br
    
Enjoy!
