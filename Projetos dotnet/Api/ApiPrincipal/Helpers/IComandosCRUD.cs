namespace Helpers
{
    public interface IComandosCRUD<T>
    {
        public T Atualizar(T obj);
        public T Cadastrar(T obj);
        public T Encontrar(long identificacao);
        public List<T> Listar();
        public Boolean Deletar();
    }
}
