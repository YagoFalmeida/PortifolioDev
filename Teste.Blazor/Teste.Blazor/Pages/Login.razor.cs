using Microsoft.AspNetCore.Components;
using Teste.Blazor.Dominio.ConfiguracaoAPI.SiteDePedidos;
using Teste.Blazor.Dominio.Modelo.Aerojet;

namespace Teste.Blazor.Pages
{
    public class LoginBase:ComponentBase
    {
        public string? LoginUsuario { get; set; }

        public string? SenhaUsuario { get; set; }

        public Usuario? Usuario { get; set; }

        public UsuarioAPI? UsuarioAPI { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        public void Autenticar()
        {
            Usuario = new Usuario();
            UsuarioAPI = new UsuarioAPI();
            Usuario = UsuarioAPI.LogarUsuario(LoginUsuario, SenhaUsuario).Usuario;
        }
    }
}
