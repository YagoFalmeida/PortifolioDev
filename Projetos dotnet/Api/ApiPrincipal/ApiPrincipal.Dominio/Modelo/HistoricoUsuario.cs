namespace ApiPrincipal.Dominio.Modelo
{
    public class HistoricoUsuario
    {
        public long CodigoHistorico { get; set; }
        public DateTime DataHoraAtividade { get; set; }
        public string DescricaoAtividade { get; set; }
        public TipoAtividade TipoAtividade { get; set; }
        public long CodigoUsuario { get; set; }

        public HistoricoUsuario()
        {
            DescricaoAtividade = string.Empty;
        }
    }

    public enum TipoAtividade
    {
        Criar = 1,
        Deletar = 2,
        Ativar = 3,
        Inativar = 4,
        Atualizar = 5,
        Cadastro = 6        
    }
}
