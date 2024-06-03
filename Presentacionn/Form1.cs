using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
namespace Presentacionn
{
    public partial class Form1 : Form
    {
        public Alumno objEntAlum = new Alumno();
        public NegAlumnos objNegAlum = new NegAlumnos();
        public Asistencia objEntAsis = new Asistencia();
        public NegAsistencias objNegAsis = new NegAsistencias();


        public Form1()
        {
            InitializeComponent();
            CrearDGV();
            LlenarDGVAlumnos();
            LlenarDGVAsistencias();
        }

        private void CrearDGV()
        {
            //TABLA ALUMNOS
            DGVAlumno.ColumnCount = 2;
            DGVAlumno.Columns[0].HeaderText = "DNI";
            DGVAlumno.Columns[1].HeaderText = "Nombre";

            //TABLA ASISTENCIAS
            DGVAsistencias.ColumnCount = 3;
            DGVAsistencias.Columns[0].HeaderText = "DNI";
            DGVAsistencias.Columns[1].HeaderText = "Fecha";
            DGVAsistencias.Columns[2].HeaderText = "Asistencia";

            //Declaro lo que quiero que salga como tabla en el DGV

        }

        private void LlenarDGVAlumnos()
        {
            DGVAlumno.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegAlum.listadoAlumnos("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DGVAlumno.Rows.Add(dr[0].ToString(), dr[1].ToString());
                }
            }
            else
            {
                lblMensajes.Text = "no hay alumnos en la lista";
            }
        }

        private void txt_a_objAlum()
        {
            objEntAlum.Dni = int.Parse(txtDni.Text);
            objEntAlum.Nombre = txtAlumno.Text;
        }

        private void ds_a_txtAlum(DataSet ds)
        {
            txtDni.Text = ds.Tables[0].Rows[0]["dni"].ToString();
            txtAlumno.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            txtDni.Enabled = false;
        }

        private void DGVAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();

            objEntAlum.Dni = Convert.ToInt32(DGVAlumno.CurrentRow.Cells[0].Value);

            ds = objNegAlum.listadoAlumnos(objEntAlum.Dni.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                ds_a_txtAlum(ds);
                btnCargar.Visible = false;
            }
        }
        
        private void LimpiarDGVAlumnos()
        {
            txtDni.Text = string.Empty;
            txtAlumno.Text= string.Empty;
            btnCargar.Visible = true;
        }


        //ACCION DEL BOTON CARGAR ALUMNO
        private void btnCargar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            string dniAlumno = txtDni.Text;

            if (objNegAlum.ExisteCodigoAlumno(dniAlumno))
            {
                MessageBox.Show(this, "ERROR", "Alumno existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_a_objAlum();

                nGrabados = objNegAlum.abmAlumnos("Alta", objEntAlum);

                if (nGrabados == -1 ) // >0 "no se cargo alumnos
                {
                    lblMensajes.Text = "NO SE CARGO ALUMNOS";
                }
                else
                {
                    lblMensajes.Text = "Se agrego alumno correctamente";
                    LlenarDGVAlumnos();
                    LimpiarDGVAlumnos();
                }
            }
        }

        //ACCION DEL BOTON MODIFICAR ALUMNO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            txt_a_objAlum();
            nResultado = objNegAlum.abmAlumnos("Modificar", objEntAlum);

            if (nResultado != -1 ) //== -1 ERROR
            {
                MessageBox.Show("Aviso", "El alumno fue modificado con exito");
                LlenarDGVAlumnos();
                LimpiarDGVAlumnos();
                txtDni.Enabled = true;
            }
            else
            {
                MessageBox.Show("ERROR", "No se pudo modificar alumno");
            }

        }

        //ACCION DEL BOTON BORRAR ALUMNO
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string asisAlumno = txtDni.Text;
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el alumno con DNI " + int.Parse(txtDni.Text) + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (objNegAsis.ExisteAsistencia(asisAlumno))
                {
                    MessageBox.Show(this, "El alumno cuenta con asistencias cargadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else 
                {
                    int nGrabados = -1;
                    Alumno NuevoAlumno = new Alumno(int.Parse(txtDni.Text), txtAlumno.Text);

                    nGrabados = objNegAlum.abmAlumnos("Borrar", NuevoAlumno);
                    LlenarDGVAlumnos();

                    txtDni.Enabled = true ;


                }
            }
        }


        private void LlenarDGVAsistencias()
        {
            DGVAsistencias.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegAsis.listadoAsistencias("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DGVAsistencias.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
            }
            else
            {
                lblMensajeA.Text = "No hay asistencias cargadas";
            }
        }
        
        private void ds_a_txtAsis(DataSet ds)
        {
            txtDNIAlu.Text = ds.Tables[0].Rows[0]["dni"].ToString();
            dateTimePicker1.Value = (DateTime)ds.Tables[0].Rows[0]["fecha"];
            rbPre.Checked = (bool)ds.Tables[0].Rows[0]["presentismo"];
            txtDNIAlu.Enabled = false;
        }

        private void DGVAsistencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string documentoAlumno = DGVAsistencias.CurrentRow.Cells[0].Value.ToString();
            DateTime fecha = Convert.ToDateTime(DGVAsistencias.CurrentRow.Cells[1].Value);
            DataSet ds = objNegAsis.listadoAsistencias(documentoAlumno);

            if (ds.Tables[0].Rows.Count > 0) 
            {
                ds_a_txtAsis(ds);
                btnCarAsi.Visible = false;
                lblMensajeA.Text = string.Empty;
            }
        }


        //ACCION DEL BOTON CARGAR ASISTENCIA
        private void btnCarAsi_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            string dniAlu = txtDNIAlu.Text;
            DateTime fecha = dateTimePicker1.Value.Date;

            if (objNegAsis.ExisteCodigoAlumno(dniAlu))
            {
                string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

                Asistencia nuevaAsistencia = new Asistencia(int.Parse(txtDNIAlu.Text), DateTime.Parse(fechaFormateada), rbPre.Checked);

                nGrabados = objNegAsis.abmAsistencias("Alta", nuevaAsistencia);

                if (nGrabados == -1)
                {
                    lblMensajeA.Text = "no se cargo alumno";
                }
                else
                {
                    lblMensajeA.Text = "Se cargo la asistencia con exito";
                    LlenarDGVAsistencias();
                }
            }

            else
            {
                MessageBox.Show("El DNI no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                #region
                //string documentoAlumno = txtDNIAlu.Text;
                //DateTime fecha = dateTimePicker1.Value.Date;

                //if(objNegAsis.ExisteAsistencia(int.Parse(documentoAlumno),fecha))
                //{
                //    MessageBox.Show("Ya existe una asistencia registrada para este alumno en la fecha especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                #endregion
            }


        }

        //ACCION DEL BOTON MODIFICAR ASISTENCIA

        private void btnModAsi_Click(object sender, EventArgs e)
        {
            int nResultado = -1;

            DateTime fecha = dateTimePicker1.Value.Date;
            Asistencia NuevaAsistencia = new Asistencia(int.Parse(txtDNIAlu.Text), fecha, rbPre.Checked);
            string dniAlu = txtDNIAlu.Text;


            DateTime nuevaFecha = fecha;
            if (objNegAsis.ExisteAsistenciaFecha(int.Parse(dniAlu), nuevaFecha))
            {
                MessageBox.Show("Ya existe una asistencia registrada para este alumno en la fecha especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                nResultado = objNegAsis.abmAsistencias("Modificar", NuevaAsistencia); 

                if (nResultado != -1)
                {
                    MessageBox.Show("La fecha fue Modificada con éxito", "Aviso");
                    
                    LlenarDGVAsistencias();
                    txtDNIAlu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar la asistencia", "Error");
                }
            }

        }

        //ACCION DEL BOTON BORRAR ASISTENCIA
        private void btnBorAsi_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value.Date;

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la asistencia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Asistencia NuevaAsistencia = new Asistencia(int.Parse(txtDNIAlu.Text), fecha, rbPre.Checked);

                nGrabados = objNegAsis.abmAsistencias("Borrar", NuevaAsistencia);
                LlenarDGVAsistencias();
                

            }
        }
    }
}
