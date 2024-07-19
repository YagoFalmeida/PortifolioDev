namespace ApiPrincipal.Dominio.Modelo
{
    public class EmailUsuario
    {
        public long CodigoEmail {  get; set; }
        public string DescricaoEmail { get; set; }
        public Boolean Ativo { get; set; }
        public long CodigoUsuario { get; set; }
        public Boolean Principal { get; set; }

        public EmailUsuario()
        {
            DescricaoEmail = string.Empty;
        }
    }
}
