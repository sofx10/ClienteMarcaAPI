using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace AppClienteAPI
{
    class ClienteAPI
    {
        private string BASE_URL="https://marcagestorapi.herokuapp.com/";
        
        public Task<HttpResponseMessage> Find(String service = "")
        {
            try
            {
                HttpClient cliente = new HttpClient();
                cliente.BaseAddress = new Uri(BASE_URL);
                cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                return cliente.GetAsync(service);

            }
            catch
            {
                return null;
            }

        }

    }
}
