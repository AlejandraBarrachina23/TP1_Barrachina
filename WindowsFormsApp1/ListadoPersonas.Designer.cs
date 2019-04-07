namespace WindowsFormsApp1
{
    partial class frmPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnOtros = new System.Windows.Forms.RadioButton();
            this.gboxSexo = new System.Windows.Forms.GroupBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNacimiento = new System.Windows.Forms.Label();
            this.gboxMusica = new System.Windows.Forms.GroupBox();
            this.chkbCountry = new System.Windows.Forms.CheckBox();
            this.chkbMetal = new System.Windows.Forms.CheckBox();
            this.chkbJazz = new System.Windows.Forms.CheckBox();
            this.chkbElectronico = new System.Windows.Forms.CheckBox();
            this.chkbRock = new System.Windows.Forms.CheckBox();
            this.chkbPop = new System.Windows.Forms.CheckBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvDatosPersona = new System.Windows.Forms.DataGridView();
            this.lbEdad = new System.Windows.Forms.Label();
            this.cboxColor = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gboxSexo.SuspendLayout();
            this.gboxMusica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(157, 35);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(173, 20);
            this.txtbNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(157, 61);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 20);
            this.txtApellido.TabIndex = 0;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(157, 87);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(173, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(74, 22);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtnFemenino.TabIndex = 2;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(183, 22);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 2;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnOtros
            // 
            this.rbtnOtros.AutoSize = true;
            this.rbtnOtros.Location = new System.Drawing.Point(307, 22);
            this.rbtnOtros.Name = "rbtnOtros";
            this.rbtnOtros.Size = new System.Drawing.Size(50, 17);
            this.rbtnOtros.TabIndex = 2;
            this.rbtnOtros.TabStop = true;
            this.rbtnOtros.Text = "Otros";
            this.rbtnOtros.UseVisualStyleBackColor = true;
            // 
            // gboxSexo
            // 
            this.gboxSexo.Controls.Add(this.rbtnOtros);
            this.gboxSexo.Controls.Add(this.rbtnMasculino);
            this.gboxSexo.Controls.Add(this.rbtnFemenino);
            this.gboxSexo.Location = new System.Drawing.Point(24, 125);
            this.gboxSexo.Name = "gboxSexo";
            this.gboxSexo.Size = new System.Drawing.Size(425, 59);
            this.gboxSexo.TabIndex = 3;
            this.gboxSexo.TabStop = false;
            this.gboxSexo.Text = "Sexo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(95, 42);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(95, 68);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 3;
            this.lbApellido.Text = "Apellido";
            // 
            // lbNacimiento
            // 
            this.lbNacimiento.AutoSize = true;
            this.lbNacimiento.Location = new System.Drawing.Point(95, 94);
            this.lbNacimiento.Name = "lbNacimiento";
            this.lbNacimiento.Size = new System.Drawing.Size(37, 13);
            this.lbNacimiento.TabIndex = 3;
            this.lbNacimiento.Text = "Fecha";
            // 
            // gboxMusica
            // 
            this.gboxMusica.Controls.Add(this.chkbCountry);
            this.gboxMusica.Controls.Add(this.chkbMetal);
            this.gboxMusica.Controls.Add(this.chkbJazz);
            this.gboxMusica.Controls.Add(this.chkbElectronico);
            this.gboxMusica.Controls.Add(this.chkbRock);
            this.gboxMusica.Controls.Add(this.chkbPop);
            this.gboxMusica.Location = new System.Drawing.Point(24, 206);
            this.gboxMusica.Name = "gboxMusica";
            this.gboxMusica.Size = new System.Drawing.Size(425, 95);
            this.gboxMusica.TabIndex = 4;
            this.gboxMusica.TabStop = false;
            this.gboxMusica.Text = "Estilos Musicales";
            // 
            // chkbCountry
            // 
            this.chkbCountry.AutoSize = true;
            this.chkbCountry.Location = new System.Drawing.Point(276, 58);
            this.chkbCountry.Name = "chkbCountry";
            this.chkbCountry.Size = new System.Drawing.Size(62, 17);
            this.chkbCountry.TabIndex = 0;
            this.chkbCountry.Text = "Country";
            this.chkbCountry.UseVisualStyleBackColor = true;
            // 
            // chkbMetal
            // 
            this.chkbMetal.AutoSize = true;
            this.chkbMetal.Location = new System.Drawing.Point(183, 58);
            this.chkbMetal.Name = "chkbMetal";
            this.chkbMetal.Size = new System.Drawing.Size(52, 17);
            this.chkbMetal.TabIndex = 0;
            this.chkbMetal.Text = "Metal";
            this.chkbMetal.UseVisualStyleBackColor = true;
            // 
            // chkbJazz
            // 
            this.chkbJazz.AutoSize = true;
            this.chkbJazz.Location = new System.Drawing.Point(276, 35);
            this.chkbJazz.Name = "chkbJazz";
            this.chkbJazz.Size = new System.Drawing.Size(47, 17);
            this.chkbJazz.TabIndex = 0;
            this.chkbJazz.Text = "Jazz";
            this.chkbJazz.UseVisualStyleBackColor = true;
            // 
            // chkbElectronico
            // 
            this.chkbElectronico.AutoSize = true;
            this.chkbElectronico.Location = new System.Drawing.Point(77, 58);
            this.chkbElectronico.Name = "chkbElectronico";
            this.chkbElectronico.Size = new System.Drawing.Size(79, 17);
            this.chkbElectronico.TabIndex = 0;
            this.chkbElectronico.Text = "Electronico";
            this.chkbElectronico.UseVisualStyleBackColor = true;
            // 
            // chkbRock
            // 
            this.chkbRock.AutoSize = true;
            this.chkbRock.Location = new System.Drawing.Point(183, 35);
            this.chkbRock.Name = "chkbRock";
            this.chkbRock.Size = new System.Drawing.Size(52, 17);
            this.chkbRock.TabIndex = 0;
            this.chkbRock.Text = "Rock";
            this.chkbRock.UseVisualStyleBackColor = true;
            // 
            // chkbPop
            // 
            this.chkbPop.AutoSize = true;
            this.chkbPop.Location = new System.Drawing.Point(77, 35);
            this.chkbPop.Name = "chkbPop";
            this.chkbPop.Size = new System.Drawing.Size(45, 17);
            this.chkbPop.TabIndex = 0;
            this.chkbPop.Text = "Pop";
            this.chkbPop.UseVisualStyleBackColor = true;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(95, 325);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(34, 13);
            this.lbColor.TabIndex = 3;
            this.lbColor.Text = "Color:";
            this.lbColor.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(131, 375);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 44);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(251, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvDatosPersona
            // 
            this.dgvDatosPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPersona.Location = new System.Drawing.Point(466, 12);
            this.dgvDatosPersona.Name = "dgvDatosPersona";
            this.dgvDatosPersona.ReadOnly = true;
            this.dgvDatosPersona.Size = new System.Drawing.Size(770, 407);
            this.dgvDatosPersona.TabIndex = 6;
            this.dgvDatosPersona.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatosPersona_RowHeaderMouseClick);
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(344, 91);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(35, 13);
            this.lbEdad.TabIndex = 3;
            this.lbEdad.Text = "Edad:";
            // 
            // cboxColor
            // 
            this.cboxColor.FormattingEnabled = true;
            this.cboxColor.Location = new System.Drawing.Point(157, 317);
            this.cboxColor.Name = "cboxColor";
            this.cboxColor.Size = new System.Drawing.Size(173, 21);
            this.cboxColor.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(708, 439);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 38);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(884, 439);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 38);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 489);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cboxColor);
            this.Controls.Add(this.dgvDatosPersona);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gboxMusica);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbNacimiento);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.gboxSexo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtbNombre);
            this.Location = new System.Drawing.Point(100, 5);
            this.Name = "frmPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.frmPersona_Load);
            this.gboxSexo.ResumeLayout(false);
            this.gboxSexo.PerformLayout();
            this.gboxMusica.ResumeLayout(false);
            this.gboxMusica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnOtros;
        private System.Windows.Forms.GroupBox gboxSexo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNacimiento;
        private System.Windows.Forms.GroupBox gboxMusica;
        private System.Windows.Forms.CheckBox chkbCountry;
        private System.Windows.Forms.CheckBox chkbMetal;
        private System.Windows.Forms.CheckBox chkbJazz;
        private System.Windows.Forms.CheckBox chkbElectronico;
        private System.Windows.Forms.CheckBox chkbRock;
        private System.Windows.Forms.CheckBox chkbPop;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvDatosPersona;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.ComboBox cboxColor;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}