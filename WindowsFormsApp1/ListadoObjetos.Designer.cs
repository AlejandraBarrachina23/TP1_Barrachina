namespace WindowsFormsApp1
{
    partial class frmObjetos
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
            this.lstbIzquierda = new System.Windows.Forms.ListBox();
            this.lbObjeto = new System.Windows.Forms.Label();
            this.txtbObjeto = new System.Windows.Forms.TextBox();
            this.lstbDerecha = new System.Windows.Forms.ListBox();
            this.btnMoverTodos = new System.Windows.Forms.Button();
            this.btnMoverUnoDerecha = new System.Windows.Forms.Button();
            this.btnMoverUnoIzquierda = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbIzquierda
            // 
            this.lstbIzquierda.FormattingEnabled = true;
            this.lstbIzquierda.Location = new System.Drawing.Point(296, 99);
            this.lstbIzquierda.Name = "lstbIzquierda";
            this.lstbIzquierda.Size = new System.Drawing.Size(268, 342);
            this.lstbIzquierda.TabIndex = 1;
            // 
            // lbObjeto
            // 
            this.lbObjeto.AutoSize = true;
            this.lbObjeto.Location = new System.Drawing.Point(109, 169);
            this.lbObjeto.Name = "lbObjeto";
            this.lbObjeto.Size = new System.Drawing.Size(96, 13);
            this.lbObjeto.TabIndex = 2;
            this.lbObjeto.Text = "Nombre de Objeto:";
            // 
            // txtbObjeto
            // 
            this.txtbObjeto.Location = new System.Drawing.Point(68, 207);
            this.txtbObjeto.Name = "txtbObjeto";
            this.txtbObjeto.Size = new System.Drawing.Size(201, 20);
            this.txtbObjeto.TabIndex = 3;
            // 
            // lstbDerecha
            // 
            this.lstbDerecha.FormattingEnabled = true;
            this.lstbDerecha.Location = new System.Drawing.Point(668, 99);
            this.lstbDerecha.Name = "lstbDerecha";
            this.lstbDerecha.Size = new System.Drawing.Size(268, 342);
            this.lstbDerecha.TabIndex = 1;
            // 
            // btnMoverTodos
            // 
            this.btnMoverTodos.Location = new System.Drawing.Point(595, 152);
            this.btnMoverTodos.Name = "btnMoverTodos";
            this.btnMoverTodos.Size = new System.Drawing.Size(51, 47);
            this.btnMoverTodos.TabIndex = 4;
            this.btnMoverTodos.Text = ">>";
            this.btnMoverTodos.UseVisualStyleBackColor = true;
            this.btnMoverTodos.Click += new System.EventHandler(this.btnMoverTodos_Click);
            // 
            // btnMoverUnoDerecha
            // 
            this.btnMoverUnoDerecha.Location = new System.Drawing.Point(595, 205);
            this.btnMoverUnoDerecha.Name = "btnMoverUnoDerecha";
            this.btnMoverUnoDerecha.Size = new System.Drawing.Size(51, 47);
            this.btnMoverUnoDerecha.TabIndex = 4;
            this.btnMoverUnoDerecha.Text = ">";
            this.btnMoverUnoDerecha.UseVisualStyleBackColor = true;
            this.btnMoverUnoDerecha.Click += new System.EventHandler(this.btnMoverUnoDerecha_Click);
            // 
            // btnMoverUnoIzquierda
            // 
            this.btnMoverUnoIzquierda.Location = new System.Drawing.Point(595, 258);
            this.btnMoverUnoIzquierda.Name = "btnMoverUnoIzquierda";
            this.btnMoverUnoIzquierda.Size = new System.Drawing.Size(51, 47);
            this.btnMoverUnoIzquierda.TabIndex = 4;
            this.btnMoverUnoIzquierda.Text = "<";
            this.btnMoverUnoIzquierda.UseVisualStyleBackColor = true;
            this.btnMoverUnoIzquierda.Click += new System.EventHandler(this.btnMoverUnoIzquierda_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(595, 311);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(51, 46);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "...";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(112, 248);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 46);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 488);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnMoverUnoIzquierda);
            this.Controls.Add(this.btnMoverUnoDerecha);
            this.Controls.Add(this.btnMoverTodos);
            this.Controls.Add(this.txtbObjeto);
            this.Controls.Add(this.lbObjeto);
            this.Controls.Add(this.lstbDerecha);
            this.Controls.Add(this.lstbIzquierda);
            this.Location = new System.Drawing.Point(15, 5);
            this.Name = "frmObjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Objetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstbIzquierda;
        private System.Windows.Forms.Label lbObjeto;
        private System.Windows.Forms.TextBox txtbObjeto;
        private System.Windows.Forms.ListBox lstbDerecha;
        private System.Windows.Forms.Button btnMoverTodos;
        private System.Windows.Forms.Button btnMoverUnoDerecha;
        private System.Windows.Forms.Button btnMoverUnoIzquierda;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
    }
}