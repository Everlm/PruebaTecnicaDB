using PruebaTecnicaDB.DAL.Entidades;
using PruebaTecnicaDB.DAL.Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PruebaTecnicaDB.DAL.Repositorio.Implementacion
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string CS = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        
        public IList<Usuario> ListaUsuarios()
        {
            List<Usuario> _usuario = new List<Usuario>();

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("sp_ListaUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    var usuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),
                        Nombre = Convert.ToString(rdr["Nombre"]),
                        FechaNacimiento = Convert.ToDateTime(rdr["FechaNacimiento"]),
                        Sexo = Convert.ToString(rdr["Sexo"]),

                    };

                    _usuario.Add(usuario);
                }

                return (_usuario);
            }
        }

        public Usuario ObtenerUsuarioPorId(int? id)
        {
            Usuario _usuario = new Usuario();

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerUsuarioPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IdUsuario", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    _usuario.IdUsuario = Convert.ToInt32(rdr["IdUsuario"]);
                    _usuario.Nombre = Convert.ToString(rdr["Nombre"]);
                    _usuario.FechaNacimiento = Convert.ToDateTime(rdr["FechaNacimiento"]);
                    _usuario.Sexo = Convert.ToString(rdr["Sexo"]);


                }

                return _usuario;
            }
        }
        public void CrearUsuario(Usuario usuario)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                var cmd = new SqlCommand("sp_CrearUsuario", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", usuario.Sexo);

                cmd.ExecuteNonQuery();
            }
        }

        public void EditarUsuario(Usuario usuario)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                var cmd = new SqlCommand("sp_EditarUsuario", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarUsuario(int? id)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                var cmd = new SqlCommand("sp_EliminarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@IdUsuario", id);
                cmd.ExecuteNonQuery();
            }
        }


    }
}
