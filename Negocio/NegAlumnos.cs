﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegAlumnos
    {
        DatosAlumnos objDatosAlumnos = new DatosAlumnos();
        public int abmAlumnos(string accion, Alumno objAlumnos)
        {
            return objDatosAlumnos.abmAlumnos(accion, objAlumnos);
        }

        public DataSet listadoAlumnos(string cual)
        {
            return objDatosAlumnos.listadoAlumnos(cual);

        }

        public bool ExisteCodigoAlumno(string dniAlumno)
        {
            return objDatosAlumnos.ExisteCodigoAlumno(dniAlumno);
        }
    }
}
