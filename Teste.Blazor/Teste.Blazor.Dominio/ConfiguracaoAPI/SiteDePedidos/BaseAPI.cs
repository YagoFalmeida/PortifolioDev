using RestSharp;
using Teste.Blazor.Dominio.Modelo.Aerojet;

namespace Teste.Blazor.Dominio.ConfiguracaoAPI.SiteDePedidos
{
    public class BaseAPI
    {
        public string UrlBase = "https://localhost:7052/api";

        public RestClient Client;
        public RestRequest Request;
        public RestResponse Response;

        public void InicializarRequisicao(Method metodo, string url)
        {
            Client = new RestClient(url);
            Request = new RestRequest
            {
                Method = metodo,
                RequestFormat = DataFormat.Json,
            };
            Request.AddHeader("Authorization", string.Format("Bearer {0}", Autenticacao.Token));
        }
    }

    static class Autenticacao
    {
        private static Usuario usuario;

        public static Usuario Usuario { get => usuario; set => usuario = value; }

        private static string token;

        public static string Token { get => token; set => token = value; }

        public static Boolean Autenticado()
        {
            return usuario != null;
        }

        public static void LimparAutenticacao()
        {
            usuario = null;
        }
    }
}
