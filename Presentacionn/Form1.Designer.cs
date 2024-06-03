namespace Presentacionn
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.DGVAlumno = new System.Windows.Forms.DataGridView();
            this.lblDniAlu = new System.Windows.Forms.Label();
            this.txtDNIAlu = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAsis = new System.Windows.Forms.Label();
            this.rbPre = new System.Windows.Forms.RadioButton();
            this.rbAus = new System.Windows.Forms.RadioButton();
            this.btnBorAsi = new System.Windows.Forms.Button();
            this.btnModAsi = new System.Windows.Forms.Button();
            this.btnCarAsi = new System.Windows.Forms.Button();
            this.DGVAsistencias = new System.Windows.Forms.DataGridView();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.lblMensajeA = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(155, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblMensajes);
            this.tabPage1.Controls.Add(this.DGVAlumno);
            this.tabPage1.Controls.Add(this.btnBorrar);
            this.tabPage1.Controls.Add(this.btnModificar);
            this.tabPage1.Controls.Add(this.btnCargar);
            this.tabPage1.Controls.Add(this.txtDni);
            this.tabPage1.Controls.Add(this.lblDni);
            this.tabPage1.Controls.Add(this.txtAlumno);
            this.tabPage1.Controls.Add(this.lblAlumno);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alumno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMensajeA);
            this.tabPage2.Controls.Add(this.DGVAsistencias);
            this.tabPage2.Controls.Add(this.btnBorAsi);
            this.tabPage2.Controls.Add(this.btnModAsi);
            this.tabPage2.Controls.Add(this.btnCarAsi);
            this.tabPage2.Controls.Add(this.rbAus);
            this.tabPage2.Controls.Add(this.rbPre);
            this.tabPage2.Controls.Add(this.lblAsis);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.txtDNIAlu);
            this.tabPage2.Controls.Add(this.lblDniAlu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asistencia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(18, 40);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(44, 13);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "Nombre";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(21, 67);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(114, 20);
            this.txtAlumno.TabIndex = 1;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(18, 114);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(21, 142);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(114, 20);
            this.txtDni.TabIndex = 3;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(40, 186);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(68, 21);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(40, 224);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(68, 21);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(40, 262);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(68, 21);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // DGVAlumno
            // 
            this.DGVAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAlumno.Location = new System.Drawing.Point(196, 53);
            this.DGVAlumno.Name = "DGVAlumno";
            this.DGVAlumno.Size = new System.Drawing.Size(266, 245);
            this.DGVAlumno.TabIndex = 7;
            this.DGVAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAlumno_CellContentClick);
            // 
            // lblDniAlu
            // 
            this.lblDniAlu.AutoSize = true;
            this.lblDniAlu.Location = new System.Drawing.Point(15, 16);
            this.lblDniAlu.Name = "lblDniAlu";
            this.lblDniAlu.Size = new System.Drawing.Size(64, 13);
            this.lblDniAlu.TabIndex = 0;
            this.lblDniAlu.Text = "DNI Alumno";
            // 
            // txtDNIAlu
            // 
            this.txtDNIAlu.Location = new System.Drawing.Point(18, 41);
            this.txtDNIAlu.Name = "txtDNIAlu";
            this.txtDNIAlu.Size = new System.Drawing.Size(101, 20);
            this.txtDNIAlu.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblAsis
            // 
            this.lblAsis.AutoSize = true;
            this.lblAsis.Location = new System.Drawing.Point(64, 126);
            this.lblAsis.Name = "lblAsis";
            this.lblAsis.Size = new System.Drawing.Size(55, 13);
            this.lblAsis.TabIndex = 3;
            this.lblAsis.Text = "Asistencia";
            // 
            // rbPre
            // 
            this.rbPre.AutoSize = true;
            this.rbPre.Location = new System.Drawing.Point(18, 166);
            this.rbPre.Name = "rbPre";
            this.rbPre.Size = new System.Drawing.Size(67, 17);
            this.rbPre.TabIndex = 4;
            this.rbPre.TabStop = true;
            this.rbPre.Text = "Presente";
            this.rbPre.UseVisualStyleBackColor = true;
            // 
            // rbAus
            // 
            this.rbAus.AutoSize = true;
            this.rbAus.Location = new System.Drawing.Point(120, 166);
            this.rbAus.Name = "rbAus";
            this.rbAus.Size = new System.Drawing.Size(64, 17);
            this.rbAus.TabIndex = 5;
            this.rbAus.TabStop = true;
            this.rbAus.Text = "Ausente";
            this.rbAus.UseVisualStyleBackColor = true;
            // 
            // btnBorAsi
            // 
            this.btnBorAsi.Location = new System.Drawing.Point(67, 288);
            this.btnBorAsi.Name = "btnBorAsi";
            this.btnBorAsi.Size = new System.Drawing.Size(68, 21);
            this.btnBorAsi.TabIndex = 9;
            this.btnBorAsi.Text = "Borrar";
            this.btnBorAsi.UseVisualStyleBackColor = true;
            this.btnBorAsi.Click += new System.EventHandler(this.btnBorAsi_Click);
            // 
            // btnModAsi
            // 
            this.btnModAsi.Location = new System.Drawing.Point(67, 250);
            this.btnModAsi.Name = "btnModAsi";
            this.btnModAsi.Size = new System.Drawing.Size(68, 21);
            this.btnModAsi.TabIndex = 8;
            this.btnModAsi.Text = "Modificar";
            this.btnModAsi.UseVisualStyleBackColor = true;
            this.btnModAsi.Click += new System.EventHandler(this.btnModAsi_Click);
            // 
            // btnCarAsi
            // 
            this.btnCarAsi.Location = new System.Drawing.Point(67, 212);
            this.btnCarAsi.Name = "btnCarAsi";
            this.btnCarAsi.Size = new System.Drawing.Size(68, 21);
            this.btnCarAsi.TabIndex = 7;
            this.btnCarAsi.Text = "Cargar";
            this.btnCarAsi.UseVisualStyleBackColor = true;
            this.btnCarAsi.Click += new System.EventHandler(this.btnCarAsi_Click);
            // 
            // DGVAsistencias
            // 
            this.DGVAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAsistencias.Location = new System.Drawing.Point(212, 40);
            this.DGVAsistencias.Name = "DGVAsistencias";
            this.DGVAsistencias.Size = new System.Drawing.Size(261, 248);
            this.DGVAsistencias.TabIndex = 10;
            this.DGVAsistencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAsistencias_CellContentClick);
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Location = new System.Drawing.Point(167, 305);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(35, 13);
            this.lblMensajes.TabIndex = 8;
            this.lblMensajes.Text = "label1";
            // 
            // lblMensajeA
            // 
            this.lblMensajeA.AutoSize = true;
            this.lblMensajeA.Location = new System.Drawing.Point(210, 306);
            this.lblMensajeA.Name = "lblMensajeA";
            this.lblMensajeA.Size = new System.Drawing.Size(35, 13);
            this.lblMensajeA.TabIndex = 11;
            this.lblMensajeA.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAsistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.DataGridView DGVAlumno;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Button btnBorAsi;
        private System.Windows.Forms.Button btnModAsi;
        private System.Windows.Forms.Button btnCarAsi;
        private System.Windows.Forms.RadioButton rbAus;
        private System.Windows.Forms.RadioButton rbPre;
        private System.Windows.Forms.Label lblAsis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDNIAlu;
        private System.Windows.Forms.Label lblDniAlu;
        private System.Windows.Forms.DataGridView DGVAsistencias;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Label lblMensajeA;
    }
}

