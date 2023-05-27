using System;

namespace PruebaTecnicaDB.DAL.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; } 
        public string Sexo { get; set; }
    }
}
