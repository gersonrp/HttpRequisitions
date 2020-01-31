using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsumindoWebApi
{
    class ViaCep
    {
        public static string GetCep(string cep)
        {
            var url = string.Format("https://viacep.com.br/ws/{0}/json/", cep);

            return HttpRequisitons.Get(url).ToString();
        }
    }
}
