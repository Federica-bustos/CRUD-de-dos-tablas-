using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegAsistencias
    {
        DatosAsistencias objDatosAsist = new DatosAsistencias();

        public int abmAsistencias(string accion, Asistencia objAsistencias)
        {
            return objDatosAsist.abmAsistencias(accion, objAsistencias);
        }

        public DataSet listadoAsistencias(string cual)
        {
            return objDatosAsist.listadoAsistencias(cual);

        }

        public bool ExisteAsistencia(string asistenciaAlu)
        {
            return objDatosAsist.ExisteAsistencia(asistenciaAlu);
        }

        public bool ExisteCodigoAlumno(string dniAlumno)
        {
            return objDatosAsist.ExisteCodigoAlumno(dniAlumno);
        }

        public bool ExisteAsistenciaFecha(int asistenciaAlu, DateTime fecha)
        {
            return objDatosAsist.ExisteAsistenciaFecha(asistenciaAlu, fecha);
        }
    }
}
