namespace Teste.Blazor.Dominio.Modelo.Aerojet
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdPerfil { get; set; }
        public string Login { get; set; }
        public string NomeCompleto { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string? Situacao { get; set; }
        public string? Observacoes { get; set; }
        public string? TelefoneFixo { get; set; }
        public string? TelefoneMovel { get; set; }
        public DateTime DataAlteracaoSenha { get; set; }
        public int QuantidadeLoginsExtras { get; set; }
        public string? Lembrete { get; set; }
        public int? IdVendedor { get; set; }
        public DateTime? DataHoraUltimoAcesso { get; set; }
        public Boolean ForcarAlteracao { get; set; }
    }
}
