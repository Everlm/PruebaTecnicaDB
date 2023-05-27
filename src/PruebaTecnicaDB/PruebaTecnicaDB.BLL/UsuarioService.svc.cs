using AutoMapper;
using PruebaTecnicaDB.BLL.Dtos;
using PruebaTecnicaDB.DAL.Entidades;
using PruebaTecnicaDB.DAL.Repositorio.Implementacion;
using System.Collections.Generic;

namespace PruebaTecnicaDB.BLL
{

    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;
        private IMapper _mapper;
        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();

            IConfigurationProvider config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Usuario, UsuarioDto>();
                cfg.CreateMap<UsuarioDto, Usuario>();
              
            });

            _mapper = new Mapper(config);
        }

        public List<UsuarioDto> ListaUsuario()
        {
            return _mapper.Map<List<UsuarioDto>>(_usuarioRepository.ListaUsuarios());
        }
        public UsuarioDto ObtenerUsuarioPorId(int? id)
        {
            return _mapper.Map<UsuarioDto>(_usuarioRepository.ObtenerUsuarioPorId(id));
        }

        public void CrearUsuario(UsuarioDto usuario)
        {

            var _usuario = _mapper.Map<Usuario>(usuario);
            _usuarioRepository.CrearUsuario(_usuario);
        }

        public void EditarUsuario(UsuarioDto usuario, int id)
        {        
            var _usuario = _mapper.Map<Usuario>(usuario);
            _usuario.IdUsuario = id;
            _usuarioRepository.EditarUsuario(_usuario);
        }

        public void EliminarUsuario(int? id)
        {
            _usuarioRepository.EliminarUsuario(id);
        }

    }
}
