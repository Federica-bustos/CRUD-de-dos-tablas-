using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Contexts;

namespace Datos
{
    public class DatosConeccionDB
    {
        public SqlConnection conexion;
        public string cadenaConexion = //@"Data Source=DESKTOP-AB45MES;Initial Catalog=asistencias;Integrated Security=True";
        //@"Data Source=DESKTOP-E8920I9\SQLEXPRESS;Initial Catalog = AsistenciaDB; Integrated Security = True";
        //@"Data Source = DESKTOP - E8920I9\SQLEXPRESS;Initial Catalog = AsistenciaDB; Integrated Security = True";
        @"Data Source=DESKTOP-E8920I9\SQLEXPRESS;Initial Catalog=Asistencia11;Integrated Security=True";

        public DatosConeccionDB() 
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }


    }
    
}

