using Microsoft.AspNetCore.Components;
using Teste.Blazor.Dominio.ConfiguracaoAPI.SiteDePedidos;
using Teste.Blazor.Dominio.Modelo.Aerojet;

namespace Teste.Blazor.Pages
{
    public class LoginBase:ComponentBase
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public Usuario Usuario { get; set; }

        public UsuarioAPI UsuarioAPI { get; set; }

        protected override void OnInitialized()
        {
            Usuario = new Usuario();

            UsuarioAPI = new UsuarioAPI();

            Usuario = UsuarioAPI.LogarUsuario(Login, Senha).Usuario;

            base.OnInitialized();
        }
    }
}
