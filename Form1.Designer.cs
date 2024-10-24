namespace Estudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.Observar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notas Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(157, 90);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(175, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(157, 129);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(175, 20);
            this.tbApellido.TabIndex = 5;
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(157, 175);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(175, 20);
            this.tbNota.TabIndex = 6;
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(403, 90);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(113, 63);
            this.Ingresar.TabIndex = 7;
            this.Ingresar.Text = "Ingresar estudiante";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // dgvSalida
            // 
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Location = new System.Drawing.Point(92, 260);
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.Size = new System.Drawing.Size(393, 150);
            this.dgvSalida.TabIndex = 8;
            // 
            // Observar
            // 
            this.Observar.Location = new System.Drawing.Point(601, 90);
            this.Observar.Name = "Observar";
            this.Observar.Size = new System.Drawing.Size(113, 63);
            this.Observar.TabIndex = 9;
            this.Observar.Text = "Observar lista";
            this.Observar.UseVisualStyleBackColor = true;
            this.Observar.Click += new System.EventHandler(this.Observar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Observar);
            this.Controls.Add(this.dgvSalida);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.DataGridView dgvSalida;
        private System.Windows.Forms.Button Observar;
    }
}

