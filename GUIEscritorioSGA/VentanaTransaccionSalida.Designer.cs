namespace GUIEscritorioSGA
{
    partial class VentanaTransaccionSalida
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
            this.Btn_Completar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Cant_max = new System.Windows.Forms.Button();
            this.Btn_Cant_mas10 = new System.Windows.Forms.Button();
            this.Btn_Cant_mas1 = new System.Windows.Forms.Button();
            this.Btn_Cant_menos1 = new System.Windows.Forms.Button();
            this.Btn_Cant_menos10 = new System.Windows.Forms.Button();
            this.Btn_Cant_0 = new System.Windows.Forms.Button();
            this.DataGridView_ProductosCantidad = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_Sucursal = new System.Windows.Forms.ComboBox();
            this.Txt_Empleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_Bodega = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ProductosCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Completar
            // 
            this.Btn_Completar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Completar.Location = new System.Drawing.Point(681, 405);
            this.Btn_Completar.Name = "Btn_Completar";
            this.Btn_Completar.Size = new System.Drawing.Size(107, 33);
            this.Btn_Completar.TabIndex = 0;
            this.Btn_Completar.Text = "Completar";
            this.Btn_Completar.UseVisualStyleBackColor = true;
            this.Btn_Completar.Click += new System.EventHandler(this.Btn_Completar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(12, 405);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(113, 33);
            this.Btn_Cancelar.TabIndex = 1;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Cant_max
            // 
            this.Btn_Cant_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_max.Location = new System.Drawing.Point(732, 321);
            this.Btn_Cant_max.Name = "Btn_Cant_max";
            this.Btn_Cant_max.Size = new System.Drawing.Size(56, 33);
            this.Btn_Cant_max.TabIndex = 2;
            this.Btn_Cant_max.Text = "Max";
            this.Btn_Cant_max.UseVisualStyleBackColor = true;
            this.Btn_Cant_max.Click += new System.EventHandler(this.Btn_Cant_max_Click);
            // 
            // Btn_Cant_mas10
            // 
            this.Btn_Cant_mas10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_mas10.Location = new System.Drawing.Point(670, 321);
            this.Btn_Cant_mas10.Name = "Btn_Cant_mas10";
            this.Btn_Cant_mas10.Size = new System.Drawing.Size(56, 33);
            this.Btn_Cant_mas10.TabIndex = 3;
            this.Btn_Cant_mas10.Text = "+10";
            this.Btn_Cant_mas10.UseVisualStyleBackColor = true;
            this.Btn_Cant_mas10.Click += new System.EventHandler(this.Btn_Cant_mas10_Click);
            // 
            // Btn_Cant_mas1
            // 
            this.Btn_Cant_mas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_mas1.Location = new System.Drawing.Point(608, 321);
            this.Btn_Cant_mas1.Name = "Btn_Cant_mas1";
            this.Btn_Cant_mas1.Size = new System.Drawing.Size(56, 33);
            this.Btn_Cant_mas1.TabIndex = 4;
            this.Btn_Cant_mas1.Text = "+1";
            this.Btn_Cant_mas1.UseVisualStyleBackColor = true;
            this.Btn_Cant_mas1.Click += new System.EventHandler(this.Btn_Cant_mas1_Click);
            // 
            // Btn_Cant_menos1
            // 
            this.Btn_Cant_menos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_menos1.Location = new System.Drawing.Point(546, 321);
            this.Btn_Cant_menos1.Name = "Btn_Cant_menos1";
            this.Btn_Cant_menos1.Size = new System.Drawing.Size(56, 33);
            this.Btn_Cant_menos1.TabIndex = 5;
            this.Btn_Cant_menos1.Text = "-1";
            this.Btn_Cant_menos1.UseVisualStyleBackColor = true;
            this.Btn_Cant_menos1.Click += new System.EventHandler(this.Btn_Cant_menos1_Click);
            // 
            // Btn_Cant_menos10
            // 
            this.Btn_Cant_menos10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_menos10.Location = new System.Drawing.Point(484, 321);
            this.Btn_Cant_menos10.Name = "Btn_Cant_menos10";
            this.Btn_Cant_menos10.Size = new System.Drawing.Size(56, 33);
            this.Btn_Cant_menos10.TabIndex = 6;
            this.Btn_Cant_menos10.Text = "-10";
            this.Btn_Cant_menos10.UseVisualStyleBackColor = true;
            this.Btn_Cant_menos10.Click += new System.EventHandler(this.Btn_Cant_menos10_Click);
            // 
            // Btn_Cant_0
            // 
            this.Btn_Cant_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cant_0.Location = new System.Drawing.Point(422, 321);
            this.Btn_Cant_0.Name = "Btn_Cant_0";
            this.Btn_Cant_0.Size = new System.Drawing.Size(56, 33);
            this.Btn_Cant_0.TabIndex = 7;
            this.Btn_Cant_0.Text = "0";
            this.Btn_Cant_0.UseVisualStyleBackColor = true;
            this.Btn_Cant_0.Click += new System.EventHandler(this.Btn_Cant_0_Click);
            // 
            // DataGridView_ProductosCantidad
            // 
            this.DataGridView_ProductosCantidad.AllowUserToAddRows = false;
            this.DataGridView_ProductosCantidad.AllowUserToDeleteRows = false;
            this.DataGridView_ProductosCantidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView_ProductosCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ProductosCantidad.Location = new System.Drawing.Point(422, 13);
            this.DataGridView_ProductosCantidad.MultiSelect = false;
            this.DataGridView_ProductosCantidad.Name = "DataGridView_ProductosCantidad";
            this.DataGridView_ProductosCantidad.ReadOnly = true;
            this.DataGridView_ProductosCantidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_ProductosCantidad.Size = new System.Drawing.Size(366, 302);
            this.DataGridView_ProductosCantidad.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sucursal";
            // 
            // ComboBox_Sucursal
            // 
            this.ComboBox_Sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Sucursal.FormattingEnabled = true;
            this.ComboBox_Sucursal.Location = new System.Drawing.Point(139, 68);
            this.ComboBox_Sucursal.Name = "ComboBox_Sucursal";
            this.ComboBox_Sucursal.Size = new System.Drawing.Size(234, 28);
            this.ComboBox_Sucursal.TabIndex = 10;
            // 
            // Txt_Empleado
            // 
            this.Txt_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Empleado.Location = new System.Drawing.Point(139, 186);
            this.Txt_Empleado.Name = "Txt_Empleado";
            this.Txt_Empleado.ReadOnly = true;
            this.Txt_Empleado.Size = new System.Drawing.Size(234, 26);
            this.Txt_Empleado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bodega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Empleado";
            // 
            // ComboBox_Bodega
            // 
            this.ComboBox_Bodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Bodega.FormattingEnabled = true;
            this.ComboBox_Bodega.Location = new System.Drawing.Point(139, 127);
            this.ComboBox_Bodega.Name = "ComboBox_Bodega";
            this.ComboBox_Bodega.Size = new System.Drawing.Size(234, 28);
            this.ComboBox_Bodega.TabIndex = 14;
            this.ComboBox_Bodega.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Bodega_SelectedIndexChanged);
            // 
            // VentanaTransaccionSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBox_Bodega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Empleado);
            this.Controls.Add(this.ComboBox_Sucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView_ProductosCantidad);
            this.Controls.Add(this.Btn_Cant_0);
            this.Controls.Add(this.Btn_Cant_menos10);
            this.Controls.Add(this.Btn_Cant_menos1);
            this.Controls.Add(this.Btn_Cant_mas1);
            this.Controls.Add(this.Btn_Cant_mas10);
            this.Controls.Add(this.Btn_Cant_max);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Completar);
            this.Name = "VentanaTransaccionSalida";
            this.Text = "VentanaTransaccionSalida";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ProductosCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Completar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Cant_max;
        private System.Windows.Forms.Button Btn_Cant_mas10;
        private System.Windows.Forms.Button Btn_Cant_mas1;
        private System.Windows.Forms.Button Btn_Cant_menos1;
        private System.Windows.Forms.Button Btn_Cant_menos10;
        private System.Windows.Forms.Button Btn_Cant_0;
        private System.Windows.Forms.DataGridView DataGridView_ProductosCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_Sucursal;
        private System.Windows.Forms.TextBox Txt_Empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_Bodega;
    }
}