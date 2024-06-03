using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        #region atributos

        private long dni;
        private string nombre;
   

        #endregion

        #region constructor

        public Alumno()
        {

        }

        public Alumno(int doc, string name)
        {
            dni = doc;
            nombre = name;
        }

        public Alumno(int doc, string name, char act)
        {
            dni = doc;
            nombre = name;
           
        }
        #endregion

        #region propiedades

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

    }
}
