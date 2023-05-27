using System;
using System.ComponentModel.DataAnnotations;

namespace PruebaTecnicaDB.BLL.Dtos
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
    }
}