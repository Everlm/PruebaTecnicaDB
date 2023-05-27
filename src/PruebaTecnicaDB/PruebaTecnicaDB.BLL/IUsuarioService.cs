using PruebaTecnicaDB.BLL.Dtos;
using System.Collections.Generic;
using System.ServiceModel;

namespace PruebaTecnicaDB.BLL
{
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
        List<UsuarioDto> ListaUsuario();

        [OperationContract]
        UsuarioDto ObtenerUsuarioPorId(int? id);

        [OperationContract]
        void CrearUsuario(UsuarioDto usuario);

        [OperationContract]
        void EditarUsuario(UsuarioDto usuario, int id);

        [OperationContract]
        void EliminarUsuario(int? id);
    }
}
