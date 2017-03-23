using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HolaMoviles.Servicios
{
    class ServicioRest
    {
        public async void Conectar()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    //https://restcountries.eu/#api-endpoints
                    httpClient.BaseAddress = new Uri("https://restcountries.eu/rest/v2/alpha/col");
                    var resultado = await httpClient.GetAsync("/all").ConfigureAwait(false);
                    var codigo = resultado.StatusCode;
                    Debug.WriteLine(resultado);

                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
