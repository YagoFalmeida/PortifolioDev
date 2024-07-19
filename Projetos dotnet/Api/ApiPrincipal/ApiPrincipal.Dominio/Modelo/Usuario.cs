namespace ApiPrincipal.Dominio.Modelo
{
    public class Usuario:ClasseBase
    {
        public long CodigoUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Boolean Ativo { get; set; }

        public Usuario()
        {
            Nome = string.Empty;
            Login = string.Empty;
            Senha = string.Empty;
        }
    }
}
