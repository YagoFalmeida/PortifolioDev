using Newtonsoft.Json;
using RestSharp;
using System.Collections.Specialized;
using System.Net;
using System.Web;

namespace Teste.Blazor.Dominio.ConfiguracaoAPI.SiteDePedidos
{
    public class UsuarioAPI:BaseAPI
    {
        public UserToken LogarUsuario(string login, string senha)
        {
            try
            {
                UriBuilder builder = new UriBuilder($"{UrlBase}/Seguranca/Login");
                NameValueCollection query = HttpUtility.ParseQueryString(builder.Query);

                query["login"] = login;
                query["senha"] = senha;

                builder.Query = query.ToString();

                Client = new RestClient(builder.ToString());
                Request = new RestRequest
                {
                    Method = Method.Post,
                    RequestFormat = DataFormat.Json,
                };

                Response = Client.Execute(Request);

                if (Response.StatusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<UserToken>(Response.Content);
                else
                    throw new Exception(Response.Content);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
