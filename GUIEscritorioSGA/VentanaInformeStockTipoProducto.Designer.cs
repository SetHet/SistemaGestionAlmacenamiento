namespace GUIEscritorioSGA
{
    partial class VentanaInformeStockTipoProducto
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
            this.DataGridView_ListaTipoProductos = new System.Windows.Forms.DataGridView();
            this.ComboBox_Bodegas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaTipoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_ListaTipoProductos
            // 
            this.DataGridView_ListaTipoProductos.AllowUserToAddRows = false;
            this.DataGridView_ListaTipoProductos.AllowUserToDeleteRows = false;
            this.DataGridView_ListaTipoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView_ListaTipoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ListaTipoProductos.Location = new System.Drawing.Point(278, 13);
            this.DataGridView_ListaTipoProductos.Name = "DataGridView_ListaTipoProductos";
            this.DataGridView_ListaTipoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_ListaTipoProductos.Size = new System.Drawing.Size(503, 425);
            this.DataGridView_ListaTipoProductos.TabIndex = 14;
            // 
            // ComboBox_Bodegas
            // 
            this.ComboBox_Bodegas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Bodegas.FormattingEnabled = true;
            this.ComboBox_Bodegas.Location = new System.Drawing.Point(19, 44);
            this.ComboBox_Bodegas.Name = "ComboBox_Bodegas";
            this.ComboBox_Bodegas.Size = new System.Drawing.Size(223, 28);
            this.ComboBox_Bodegas.TabIndex = 13;
            this.ComboBox_Bodegas.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Bodegas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bodega";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Location = new System.Drawing.Point(19, 356);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(223, 38);
            this.Btn_Actualizar.TabIndex = 11;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(19, 400);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(223, 38);
            this.Btn_Salir.TabIndex = 10;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // VentanaInformeStockTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView_ListaTipoProductos);
            this.Controls.Add(this.ComboBox_Bodegas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Salir);
            this.Name = "VentanaInformeStockTipoProducto";
            this.Text = "SGA Persia Informe Top Stock de Tipos de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaTipoProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_ListaTipoProductos;
        private System.Windows.Forms.ComboBox ComboBox_Bodegas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Salir;
    }
}