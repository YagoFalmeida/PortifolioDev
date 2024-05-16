using Newtonsoft.Json;
using RestSharp;
using System.Net;
using Teste.Blazor.Dominio.Modelo.Aerojet;

namespace Teste.Blazor.Dominio.ConfiguracaoAPI.SiteDePedidos
{
    public class EmpresaAPI: BaseAPI
    {
        public List<Empresa> ListarEmpresas()
        {
            try
            {
                InicializarRequisicao(Method.Get, "");

                Response = Client.Execute(Request);

                if (Response.StatusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<List<Empresa>>(Response.Content);
                else
                    return new List<Empresa>();
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
