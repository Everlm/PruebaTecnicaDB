using PruebaTecnicaDB.DAL.Entidades;
using System.Collections.Generic;

namespace PruebaTecnicaDB.DAL.Repositorio.Interfaz
{
    public interface IUsuarioRepository
    {
        IList<Usuario> ListaUsuarios();
        Usuario ObtenerUsuarioPorId(int? id);
        void CrearUsuario(Usuario usuario);
        void EditarUsuario(Usuario usuario);
        void EliminarUsuario(int? id);
    }
}
