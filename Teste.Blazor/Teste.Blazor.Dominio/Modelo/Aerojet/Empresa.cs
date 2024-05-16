namespace Teste.Blazor.Dominio.Modelo.Aerojet
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CodigoErp { get; set; }
        public string RazaoSocial { get; set; }

        public Empresa()
        {
            Nome = string.Empty;
            RazaoSocial = string.Empty;
        }
    }
}
