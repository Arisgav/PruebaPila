namespace PilaApp
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
            this.components = new System.ComponentModel.Container();
            this.Tbnombre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Nombre = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.Salario = new System.Windows.Forms.Label();
            this.Tbapellido = new System.Windows.Forms.TextBox();
            this.Tbcargo = new System.Windows.Forms.TextBox();
            this.Tbsalario = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Pilatext = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Tbnombre
            // 
            this.Tbnombre.Location = new System.Drawing.Point(208, 32);
            this.Tbnombre.Name = "Tbnombre";
            this.Tbnombre.Size = new System.Drawing.Size(232, 20);
            this.Tbnombre.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(121, 35);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(121, 65);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 3;
            this.Apellido.Text = "Apellido";
            this.Apellido.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Location = new System.Drawing.Point(121, 92);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(35, 13);
            this.Cargo.TabIndex = 4;
            this.Cargo.Text = "Cargo";
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Location = new System.Drawing.Point(121, 121);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(39, 13);
            this.Salario.TabIndex = 5;
            this.Salario.Text = "Salario";
            // 
            // Tbapellido
            // 
            this.Tbapellido.Location = new System.Drawing.Point(205, 63);
            this.Tbapellido.Name = "Tbapellido";
            this.Tbapellido.Size = new System.Drawing.Size(234, 20);
            this.Tbapellido.TabIndex = 6;
            // 
            // Tbcargo
            // 
            this.Tbcargo.Location = new System.Drawing.Point(208, 93);
            this.Tbcargo.Name = "Tbcargo";
            this.Tbcargo.Size = new System.Drawing.Size(230, 20);
            this.Tbcargo.TabIndex = 7;
            // 
            // Tbsalario
            // 
            this.Tbsalario.Location = new System.Drawing.Point(209, 122);
            this.Tbsalario.Name = "Tbsalario";
            this.Tbsalario.Size = new System.Drawing.Size(229, 20);
            this.Tbsalario.TabIndex = 8;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(572, 75);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(117, 59);
            this.Agregar.TabIndex = 9;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(567, 154);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(122, 72);
            this.Eliminar.TabIndex = 10;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Pilatext
            // 
            this.Pilatext.FormattingEnabled = true;
            this.Pilatext.Location = new System.Drawing.Point(175, 164);
            this.Pilatext.Name = "Pilatext";
            this.Pilatext.Size = new System.Drawing.Size(263, 121);
            this.Pilatext.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pilatext);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Tbsalario);
            this.Controls.Add(this.Tbcargo);
            this.Controls.Add(this.Tbapellido);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Tbnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbnombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.TextBox Tbapellido;
        private System.Windows.Forms.TextBox Tbcargo;
        private System.Windows.Forms.TextBox Tbsalario;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.ListBox Pilatext;
    }
}

