namespace GUIEscritorioSGA
{
    partial class VentanaTransaccionEntrada
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
            this.DataGridView_ProductosCantidad = new System.Windows.Forms.DataGridView();
            this.Btn_Cant_0 = new System.Windows.Forms.Button();
            this.Btn_Cant_menos10 = new System.Windows.Forms.Button();
            this.Btn_Cant_menos1 = new System.Windows.Forms.Button();
            this.Btn_Cant_mas1 = new System.Windows.Forms.Button();
            this.Btn_Cant_mas10 = new System.Windows.Forms.Button();
            this.Btn_Completar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.ComboBox_Proveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_Bodega = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Empleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ProductosCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_ProductosCantidad
            // 
            this.DataGridView_ProductosCantidad.AllowUserToAddRows = false;
            this.DataGridView_ProductosCantidad.AllowUserToDeleteRows = false;
            this.DataGridView_ProductosCantidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView_ProductosCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ProductosCantidad.Location = new System.Drawing.Point(383, 12);
            this.DataGridView_ProductosCantidad.MultiSelect = false;
            this.DataGridView_ProductosCantidad.Name = "DataGridView_ProductosCantidad";
            this.DataGridView_ProductosCantidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_ProductosCantidad.Size = new System.Drawing.Size(405, 297);
            this.DataGridView_ProductosCantidad.TabIndex = 0;
            // 
            // Btn_Cant_0
            // 
            this.Btn_Cant_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_0.Location = new System.Drawing.Point(383, 316);
            this.Btn_Cant_0.Name = "Btn_Cant_0";
            this.Btn_Cant_0.Size = new System.Drawing.Size(57, 35);
            this.Btn_Cant_0.TabIndex = 1;
            this.Btn_Cant_0.Text = "0";
            this.Btn_Cant_0.UseVisualStyleBackColor = true;
            this.Btn_Cant_0.Click += new System.EventHandler(this.Btn_Cant_0_Click);
            // 
            // Btn_Cant_menos10
            // 
            this.Btn_Cant_menos10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_menos10.Location = new System.Drawing.Point(446, 315);
            this.Btn_Cant_menos10.Name = "Btn_Cant_menos10";
            this.Btn_Cant_menos10.Size = new System.Drawing.Size(57, 35);
            this.Btn_Cant_menos10.TabIndex = 2;
            this.Btn_Cant_menos10.Text = "-10";
            this.Btn_Cant_menos10.UseVisualStyleBackColor = true;
            this.Btn_Cant_menos10.Click += new System.EventHandler(this.Btn_Cant_menos10_Click);
            // 
            // Btn_Cant_menos1
            // 
            this.Btn_Cant_menos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_menos1.Location = new System.Drawing.Point(509, 315);
            this.Btn_Cant_menos1.Name = "Btn_Cant_menos1";
            this.Btn_Cant_menos1.Size = new System.Drawing.Size(57, 35);
            this.Btn_Cant_menos1.TabIndex = 3;
            this.Btn_Cant_menos1.Text = "-1";
            this.Btn_Cant_menos1.UseVisualStyleBackColor = true;
            this.Btn_Cant_menos1.Click += new System.EventHandler(this.Btn_Cant_menos1_Click);
            // 
            // Btn_Cant_mas1
            // 
            this.Btn_Cant_mas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_mas1.Location = new System.Drawing.Point(572, 316);
            this.Btn_Cant_mas1.Name = "Btn_Cant_mas1";
            this.Btn_Cant_mas1.Size = new System.Drawing.Size(57, 35);
            this.Btn_Cant_mas1.TabIndex = 4;
            this.Btn_Cant_mas1.Text = "+1";
            this.Btn_Cant_mas1.UseVisualStyleBackColor = true;
            this.Btn_Cant_mas1.Click += new System.EventHandler(this.Btn_Cant_mas1_Click);
            // 
            // Btn_Cant_mas10
            // 
            this.Btn_Cant_mas10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_mas10.Location = new System.Drawing.Point(635, 315);
            this.Btn_Cant_mas10.Name = "Btn_Cant_mas10";
            this.Btn_Cant_mas10.Size = new System.Drawing.Size(57, 35);
            this.Btn_Cant_mas10.TabIndex = 5;
            this.Btn_Cant_mas10.Text = "+10";
            this.Btn_Cant_mas10.UseVisualStyleBackColor = true;
            this.Btn_Cant_mas10.Click += new System.EventHandler(this.Btn_Cant_mas10_Click);
            // 
            // Btn_Completar
            // 
            this.Btn_Completar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Completar.Location = new System.Drawing.Point(669, 403);
            this.Btn_Completar.Name = "Btn_Completar";
            this.Btn_Completar.Size = new System.Drawing.Size(119, 35);
            this.Btn_Completar.TabIndex = 6;
            this.Btn_Completar.Text = "Completar";
            this.Btn_Completar.UseVisualStyleBackColor = true;
            this.Btn_Completar.Click += new System.EventHandler(this.Btn_Completar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(12, 403);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(119, 35);
            this.Btn_Salir.TabIndex = 7;
            this.Btn_Salir.Text = "Cancelar";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // ComboBox_Proveedor
            // 
            this.ComboBox_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Proveedor.FormattingEnabled = true;
            this.ComboBox_Proveedor.Location = new System.Drawing.Point(132, 15);
            this.ComboBox_Proveedor.Name = "ComboBox_Proveedor";
            this.ComboBox_Proveedor.Size = new System.Drawing.Size(213, 28);
            this.ComboBox_Proveedor.TabIndex = 8;
            this.ComboBox_Proveedor.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Proveedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bodega";
            // 
            // ComboBox_Bodega
            // 
            this.ComboBox_Bodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Bodega.FormattingEnabled = true;
            this.ComboBox_Bodega.Location = new System.Drawing.Point(132, 64);
            this.ComboBox_Bodega.Name = "ComboBox_Bodega";
            this.ComboBox_Bodega.Size = new System.Drawing.Size(213, 28);
            this.ComboBox_Bodega.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Empleado";
            // 
            // Txt_Empleado
            // 
            this.Txt_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Empleado.Location = new System.Drawing.Point(132, 117);
            this.Txt_Empleado.Name = "Txt_Empleado";
            this.Txt_Empleado.ReadOnly = true;
            this.Txt_Empleado.Size = new System.Drawing.Size(213, 26);
            this.Txt_Empleado.TabIndex = 14;
            this.Txt_Empleado.Text = "xx.xxx.xxx-x";
            // 
            // VentanaTransaccionEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_Empleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox_Bodega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_Proveedor);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Completar);
            this.Controls.Add(this.Btn_Cant_mas10);
            this.Controls.Add(this.Btn_Cant_mas1);
            this.Controls.Add(this.Btn_Cant_menos1);
            this.Controls.Add(this.Btn_Cant_menos10);
            this.Controls.Add(this.Btn_Cant_0);
            this.Controls.Add(this.DataGridView_ProductosCantidad);
            this.Name = "VentanaTransaccionEntrada";
            this.Text = "SGA Persia Transaccion Entrada de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ProductosCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_ProductosCantidad;
        private System.Windows.Forms.Button Btn_Cant_0;
        private System.Windows.Forms.Button Btn_Cant_menos10;
        private System.Windows.Forms.Button Btn_Cant_menos1;
        private System.Windows.Forms.Button Btn_Cant_mas1;
        private System.Windows.Forms.Button Btn_Cant_mas10;
        private System.Windows.Forms.Button Btn_Completar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.ComboBox ComboBox_Proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_Bodega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Empleado;
    }
}