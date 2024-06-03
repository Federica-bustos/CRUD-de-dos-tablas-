using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DatosAlumnos : DatosConeccionDB
    {
        public int abmAlumnos(string accion, Alumno objAlumno)

        {
            int resultado = -1;  // controlar que se realize la operacion con exito
            string orden = string.Empty; // para guardar consulta sql


            if (accion == "Alta")
            {
                orden = "INSERT INTO alumnos (Dni, Nombre) VALUES (@Dni, @Nombre);";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Alumnos SET Nombre = @Nombre WHERE Dni = @Dni;";
            }
            else if (accion == "Borrar")
            {
                orden = "DELETE FROM Alumnos WHERE Dni = @Dni;";
            }


            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@Dni", objAlumno.Dni);
            cmd.Parameters.AddWithValue("@Nombre", objAlumno.Nombre);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar, borrar o modificar algun alumno.", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;

        }

            public DataSet listadoAlumnos(string cual)
            {
                string orden = string.Empty;

                if (cual != "Todos")
                    orden = "select * from alumnos where Dni = " + int.Parse(cual) + ";";
                else
                    orden = "select * from alumnos;";

                SqlCommand cmd = new SqlCommand(orden, conexion);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                try
                {
                    Abrirconexion();
                    cmd.ExecuteNonQuery();

                    da.SelectCommand = cmd;
                    da.Fill(ds);
                }
                catch (Exception e)
                {
                    throw new Exception("Error al listar alumnos", e);
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
                return ds;
            }
            

            public bool ExisteCodigoAlumno(string dniAlumno)
            {
            string consulta = "SELECT COUNT(*) FROM alumnos WHERE dni = @dniAlum";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@dniAlum", dniAlumno);

            try
            {
                Abrirconexion();
                int count = (int)cmd.ExecuteScalar(); // Obtenemos el resultado del conteo de filas
                return count > 0; // Devolvemos true si el código de alumno existe en la tabla
            }
            catch (Exception e)
            {
                throw new Exception("Error al verificar la existencia del DNI del Alumno.", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

        }
    }
}
