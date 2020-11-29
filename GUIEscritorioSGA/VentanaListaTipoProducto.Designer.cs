namespace GUIEscritorioSGA
{
    partial class VentanaListaTipoProducto
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
            this.DataGridView_ListaTipoProducto = new System.Windows.Forms.DataGridView();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaTipoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_ListaTipoProducto
            // 
            this.DataGridView_ListaTipoProducto.AllowUserToAddRows = false;
            this.DataGridView_ListaTipoProducto.AllowUserToDeleteRows = false;
            this.DataGridView_ListaTipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ListaTipoProducto.Location = new System.Drawing.Point(12, 12);
            this.DataGridView_ListaTipoProducto.Name = "DataGridView_ListaTipoProducto";
            this.DataGridView_ListaTipoProducto.ReadOnly = true;
            this.DataGridView_ListaTipoProducto.Size = new System.Drawing.Size(434, 380);
            this.DataGridView_ListaTipoProducto.TabIndex = 0;
            this.DataGridView_ListaTipoProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ListaTipoProducto_CellContentClick);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(354, 411);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(92, 35);
            this.Btn_Salir.TabIndex = 1;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Location = new System.Drawing.Point(256, 411);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(92, 35);
            this.Btn_Actualizar.TabIndex = 2;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // VentanaListaTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 458);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.DataGridView_ListaTipoProducto);
            this.Name = "VentanaListaTipoProducto";
            this.Text = "SGA Persia Lista Tipos Productos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaTipoProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_ListaTipoProducto;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Actualizar;
    }
}