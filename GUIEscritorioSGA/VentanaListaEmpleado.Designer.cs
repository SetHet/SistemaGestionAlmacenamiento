namespace GUIEscritorioSGA
{
    partial class VentanaListaEmpleado
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
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.DataGridView_ListaEmpleado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Location = new System.Drawing.Point(427, 407);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(92, 35);
            this.Btn_Actualizar.TabIndex = 8;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(525, 407);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(92, 35);
            this.Btn_Salir.TabIndex = 7;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click_1);
            // 
            // DataGridView_ListaEmpleado
            // 
            this.DataGridView_ListaEmpleado.AllowUserToAddRows = false;
            this.DataGridView_ListaEmpleado.AllowUserToDeleteRows = false;
            this.DataGridView_ListaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ListaEmpleado.Location = new System.Drawing.Point(183, 8);
            this.DataGridView_ListaEmpleado.Name = "DataGridView_ListaEmpleado";
            this.DataGridView_ListaEmpleado.ReadOnly = true;
            this.DataGridView_ListaEmpleado.Size = new System.Drawing.Size(434, 380);
            this.DataGridView_ListaEmpleado.TabIndex = 6;
            // 
            // VentanaListaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.DataGridView_ListaEmpleado);
            this.Name = "VentanaListaEmpleado";
            this.Text = "SGA Persia Lista de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.DataGridView DataGridView_ListaEmpleado;
    }
}