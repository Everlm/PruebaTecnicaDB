using PruebaTecnicaDB.ApplicationWeb.UsuarioService;
using System.Web.Mvc;

namespace PruebaTecnicaDB.ApplicationWeb.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioServiceClient usuarioService = new UsuarioServiceClient();

       
        public ActionResult Index()
        {
           return View(usuarioService.ListaUsuario());
        }

        
        public ActionResult Details(int id)
        {
            var usuario = usuarioService.ObtenerUsuarioPorId(id);
            return View(usuario);
        }

       
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(UsuarioDto usuarioDto)
        {
            try
            {
                
                usuarioService.CrearUsuario(usuarioDto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            var usuario = usuarioService.ObtenerUsuarioPorId(id);
           
            return View(usuario);
        }

        
        [HttpPost]
        public ActionResult Edit(int id, UsuarioDto usuarioDto)
        {
            try
            {
                usuarioService.EditarUsuario(usuarioDto, id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      
        public ActionResult Delete(int id)
        {
            var usuario = usuarioService.ObtenerUsuarioPorId(id);
            return View(usuario);

        }

        
        [HttpPost]
        public ActionResult Delete(int id, UsuarioDto usuarioDto)
        {
            try
            {
                
                usuarioService.EliminarUsuario(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
