namespace GUIEscritorioSGA
{
    partial class VentanaInformeMoreStock
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
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_Bodegas = new System.Windows.Forms.ComboBox();
            this.DataGridView_ListaProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(26, 400);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(223, 38);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Location = new System.Drawing.Point(26, 356);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(223, 38);
            this.Btn_Actualizar.TabIndex = 1;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bodega";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox_Bodegas
            // 
            this.ComboBox_Bodegas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Bodegas.FormattingEnabled = true;
            this.ComboBox_Bodegas.Location = new System.Drawing.Point(26, 44);
            this.ComboBox_Bodegas.Name = "ComboBox_Bodegas";
            this.ComboBox_Bodegas.Size = new System.Drawing.Size(223, 28);
            this.ComboBox_Bodegas.TabIndex = 3;
            this.ComboBox_Bodegas.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Bodegas_SelectedIndexChanged);
            // 
            // DataGridView_ListaProductos
            // 
            this.DataGridView_ListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ListaProductos.Location = new System.Drawing.Point(285, 13);
            this.DataGridView_ListaProductos.Name = "DataGridView_ListaProductos";
            this.DataGridView_ListaProductos.Size = new System.Drawing.Size(503, 425);
            this.DataGridView_ListaProductos.TabIndex = 4;
            // 
            // VentanaInformeMoreStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView_ListaProductos);
            this.Controls.Add(this.ComboBox_Bodegas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Salir);
            this.Name = "VentanaInformeMoreStock";
            this.Text = "SGA Persia Informe Top Stock de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_Bodegas;
        private System.Windows.Forms.DataGridView DataGridView_ListaProductos;
    }
}