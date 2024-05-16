using Teste.Blazor.Dominio.Modelo.Aerojet;

namespace Teste.Blazor.Dominio.ConfiguracaoAPI.SiteDePedidos
{
    public class UserToken
    {
        public Usuario Usuario { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
