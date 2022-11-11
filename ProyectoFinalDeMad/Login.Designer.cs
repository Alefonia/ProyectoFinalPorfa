
namespace ProyectoFinalDeMad
{
    partial class Login
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
            this.NombreUsuarioTxBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContrasenaTxBx = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // NombreUsuarioTxBx
            // 
            this.NombreUsuarioTxBx.Location = new System.Drawing.Point(124, 69);
            this.NombreUsuarioTxBx.Multiline = true;
            this.NombreUsuarioTxBx.Name = "NombreUsuarioTxBx";
            this.NombreUsuarioTxBx.Size = new System.Drawing.Size(171, 38);
            this.NombreUsuarioTxBx.TabIndex = 1;
            this.NombreUsuarioTxBx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // ContrasenaTxBx
            // 
            this.ContrasenaTxBx.Location = new System.Drawing.Point(124, 141);
            this.ContrasenaTxBx.Multiline = true;
            this.ContrasenaTxBx.Name = "ContrasenaTxBx";
            this.ContrasenaTxBx.Size = new System.Drawing.Size(171, 35);
            this.ContrasenaTxBx.TabIndex = 3;
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(164, 205);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(84, 34);
            this.Ingresar.TabIndex = 4;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 268);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.ContrasenaTxBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreUsuarioTxBx);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Inicio de Sesion ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreUsuarioTxBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContrasenaTxBx;
        private System.Windows.Forms.Button Ingresar;
    }
}

