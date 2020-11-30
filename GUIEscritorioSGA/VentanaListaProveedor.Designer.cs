namespace GUIEscritorioSGA
{
    partial class VentanaListaProveedor
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
            this.DataGridView_ListaProveedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaProveedor)).BeginInit();
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
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click_1);
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
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // DataGridView_ListaProveedor
            // 
            this.DataGridView_ListaProveedor.AllowUserToAddRows = false;
            this.DataGridView_ListaProveedor.AllowUserToDeleteRows = false;
            this.DataGridView_ListaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ListaProveedor.Location = new System.Drawing.Point(183, 8);
            this.DataGridView_ListaProveedor.Name = "DataGridView_ListaProveedor";
            this.DataGridView_ListaProveedor.ReadOnly = true;
            this.DataGridView_ListaProveedor.Size = new System.Drawing.Size(434, 380);
            this.DataGridView_ListaProveedor.TabIndex = 6;
            this.DataGridView_ListaProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ListaProveedor_CellContentClick_1);
            // 
            // VentanaListaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.DataGridView_ListaProveedor);
            this.Name = "VentanaListaProveedor";
            this.Text = "SGA Persia Lista de Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.DataGridView DataGridView_ListaProveedor;
    }
}