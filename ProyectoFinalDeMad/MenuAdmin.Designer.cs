
namespace ProyectoFinalDeMad
{
    partial class MenuAdmin
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
            this.EmpleadosBTN = new System.Windows.Forms.Button();
            this.ProductosBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InventarioBTN = new System.Windows.Forms.Button();
            this.VentasBTN = new System.Windows.Forms.Button();
            this.DevolucionBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketsBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpleadosBTN
            // 
            this.EmpleadosBTN.Location = new System.Drawing.Point(226, 61);
            this.EmpleadosBTN.Name = "EmpleadosBTN";
            this.EmpleadosBTN.Size = new System.Drawing.Size(148, 34);
            this.EmpleadosBTN.TabIndex = 0;
            this.EmpleadosBTN.Text = "Manejo Empleados";
            this.EmpleadosBTN.UseVisualStyleBackColor = true;
            // 
            // ProductosBTN
            // 
            this.ProductosBTN.Location = new System.Drawing.Point(226, 119);
            this.ProductosBTN.Name = "ProductosBTN";
            this.ProductosBTN.Size = new System.Drawing.Size(148, 34);
            this.ProductosBTN.TabIndex = 1;
            this.ProductosBTN.Text = "Manejo Productos";
            this.ProductosBTN.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // InventarioBTN
            // 
            this.InventarioBTN.Location = new System.Drawing.Point(226, 179);
            this.InventarioBTN.Name = "InventarioBTN";
            this.InventarioBTN.Size = new System.Drawing.Size(148, 34);
            this.InventarioBTN.TabIndex = 3;
            this.InventarioBTN.Text = "Ver Inventario";
            this.InventarioBTN.UseVisualStyleBackColor = true;
            // 
            // VentasBTN
            // 
            this.VentasBTN.Location = new System.Drawing.Point(403, 61);
            this.VentasBTN.Name = "VentasBTN";
            this.VentasBTN.Size = new System.Drawing.Size(148, 34);
            this.VentasBTN.TabIndex = 4;
            this.VentasBTN.Text = "Generar Venta";
            this.VentasBTN.UseVisualStyleBackColor = true;
            // 
            // DevolucionBTN
            // 
            this.DevolucionBTN.Location = new System.Drawing.Point(403, 119);
            this.DevolucionBTN.Name = "DevolucionBTN";
            this.DevolucionBTN.Size = new System.Drawing.Size(148, 34);
            this.DevolucionBTN.TabIndex = 5;
            this.DevolucionBTN.Text = "Generar Devolucion";
            this.DevolucionBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Articulos con poco stock";
            // 
            // TicketsBTN
            // 
            this.TicketsBTN.Location = new System.Drawing.Point(403, 179);
            this.TicketsBTN.Name = "TicketsBTN";
            this.TicketsBTN.Size = new System.Drawing.Size(148, 34);
            this.TicketsBTN.TabIndex = 7;
            this.TicketsBTN.Text = "Consulta  de Tickets";
            this.TicketsBTN.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TicketsBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DevolucionBTN);
            this.Controls.Add(this.VentasBTN);
            this.Controls.Add(this.InventarioBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProductosBTN);
            this.Controls.Add(this.EmpleadosBTN);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmpleadosBTN;
        private System.Windows.Forms.Button ProductosBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InventarioBTN;
        private System.Windows.Forms.Button VentasBTN;
        private System.Windows.Forms.Button DevolucionBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TicketsBTN;
    }
}