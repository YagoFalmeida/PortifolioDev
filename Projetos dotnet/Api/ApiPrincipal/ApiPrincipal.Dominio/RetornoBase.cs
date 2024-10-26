namespace ApiPrincipal.Dominio
{
    public class RetornoBase<T>
    {
        public List<T> ListaObjetos { get; set; }

        public RetornoBase()
        {
            ListaObjetos = new List<T>();
        }
    }
}
