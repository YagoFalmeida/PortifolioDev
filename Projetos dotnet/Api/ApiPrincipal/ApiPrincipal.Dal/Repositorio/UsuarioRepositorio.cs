using ApiPrincipal.Dominio.Modelo;
using Helpers;

namespace ApiPrincipal.Dal.Repositorio
{
    internal class UsuarioRepositorio : IComandosCRUD<Usuario>
    {
        public Usuario Atualizar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Usuario Cadastrar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public bool Deletar()
        {
            throw new NotImplementedException();
        }

        public Usuario Encontrar(long identificacao)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            try
            {
                return new List<Usuario>();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
