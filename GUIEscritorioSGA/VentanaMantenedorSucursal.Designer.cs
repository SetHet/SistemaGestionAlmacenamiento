namespace GUIEscritorioSGA
{
    partial class VentanaMantenedorSucursal
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
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Listar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Primero = new System.Windows.Forms.Button();
            this.Btn_Anterior = new System.Windows.Forms.Button();
            this.Txt_Actual = new System.Windows.Forms.TextBox();
            this.Btn_Siguiente = new System.Windows.Forms.Button();
            this.Btn_Ultimo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_IdSucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_NombreSucursal = new System.Windows.Forms.TextBox();
            this.txt_DireccionSucursal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.Location = new System.Drawing.Point(88, 261);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(95, 36);
            this.Btn_Nuevo.TabIndex = 7;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(220, 261);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Eliminar.TabIndex = 8;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Location = new System.Drawing.Point(353, 261);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Actualizar.TabIndex = 9;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // Btn_Listar
            // 
            this.Btn_Listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Listar.Location = new System.Drawing.Point(475, 261);
            this.Btn_Listar.Name = "Btn_Listar";
            this.Btn_Listar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Listar.TabIndex = 10;
            this.Btn_Listar.Text = "Listar";
            this.Btn_Listar.UseVisualStyleBackColor = true;
            this.Btn_Listar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(613, 261);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(95, 36);
            this.Btn_Salir.TabIndex = 11;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Btn_Primero
            // 
            this.Btn_Primero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Primero.Location = new System.Drawing.Point(88, 336);
            this.Btn_Primero.Name = "Btn_Primero";
            this.Btn_Primero.Size = new System.Drawing.Size(95, 36);
            this.Btn_Primero.TabIndex = 12;
            this.Btn_Primero.Text = "<<";
            this.Btn_Primero.UseVisualStyleBackColor = true;
            this.Btn_Primero.Click += new System.EventHandler(this.Btn_Primero_Click);
            // 
            // Btn_Anterior
            // 
            this.Btn_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Anterior.Location = new System.Drawing.Point(220, 336);
            this.Btn_Anterior.Name = "Btn_Anterior";
            this.Btn_Anterior.Size = new System.Drawing.Size(95, 36);
            this.Btn_Anterior.TabIndex = 13;
            this.Btn_Anterior.Text = "<";
            this.Btn_Anterior.UseVisualStyleBackColor = true;
            this.Btn_Anterior.Click += new System.EventHandler(this.Btn_Anterior_Click);
            // 
            // Txt_Actual
            // 
            this.Txt_Actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Actual.Location = new System.Drawing.Point(353, 346);
            this.Txt_Actual.Name = "Txt_Actual";
            this.Txt_Actual.ReadOnly = true;
            this.Txt_Actual.Size = new System.Drawing.Size(95, 26);
            this.Txt_Actual.TabIndex = 15;
            this.Txt_Actual.Text = "0 / 0";
            this.Txt_Actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Actual.TextChanged += new System.EventHandler(this.Txt_Actual_TextChanged);
            // 
            // Btn_Siguiente
            // 
            this.Btn_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Siguiente.Location = new System.Drawing.Point(475, 336);
            this.Btn_Siguiente.Name = "Btn_Siguiente";
            this.Btn_Siguiente.Size = new System.Drawing.Size(95, 36);
            this.Btn_Siguiente.TabIndex = 16;
            this.Btn_Siguiente.Text = ">";
            this.Btn_Siguiente.UseVisualStyleBackColor = true;
            this.Btn_Siguiente.Click += new System.EventHandler(this.Btn_Siguiente_Click);
            // 
            // Btn_Ultimo
            // 
            this.Btn_Ultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ultimo.Location = new System.Drawing.Point(613, 336);
            this.Btn_Ultimo.Name = "Btn_Ultimo";
            this.Btn_Ultimo.Size = new System.Drawing.Size(95, 36);
            this.Btn_Ultimo.TabIndex = 17;
            this.Btn_Ultimo.Text = ">>";
            this.Btn_Ultimo.UseVisualStyleBackColor = true;
            this.Btn_Ultimo.Click += new System.EventHandler(this.Btn_Ultimo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID Sucursal";
            // 
            // Txt_IdSucursal
            // 
            this.Txt_IdSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdSucursal.Location = new System.Drawing.Point(409, 66);
            this.Txt_IdSucursal.Name = "Txt_IdSucursal";
            this.Txt_IdSucursal.ReadOnly = true;
            this.Txt_IdSucursal.Size = new System.Drawing.Size(186, 26);
            this.Txt_IdSucursal.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre Sucursal";
            // 
            // Txt_NombreSucursal
            // 
            this.Txt_NombreSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreSucursal.Location = new System.Drawing.Point(409, 110);
            this.Txt_NombreSucursal.Multiline = true;
            this.Txt_NombreSucursal.Name = "Txt_NombreSucursal";
            this.Txt_NombreSucursal.Size = new System.Drawing.Size(186, 27);
            this.Txt_NombreSucursal.TabIndex = 50;
            // 
            // txt_DireccionSucursal
            // 
            this.txt_DireccionSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DireccionSucursal.Location = new System.Drawing.Point(409, 162);
            this.txt_DireccionSucursal.Multiline = true;
            this.txt_DireccionSucursal.Name = "txt_DireccionSucursal";
            this.txt_DireccionSucursal.Size = new System.Drawing.Size(186, 27);
            this.txt_DireccionSucursal.TabIndex = 51;
            this.txt_DireccionSucursal.TextChanged += new System.EventHandler(this.txt_DireccionSucursal_TextChanged);
            // 
            // VentanaMantenedorSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_DireccionSucursal);
            this.Controls.Add(this.Txt_NombreSucursal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_IdSucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Ultimo);
            this.Controls.Add(this.Btn_Siguiente);
            this.Controls.Add(this.Txt_Actual);
            this.Controls.Add(this.Btn_Anterior);
            this.Controls.Add(this.Btn_Primero);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Listar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Name = "VentanaMantenedorSucursal";
            this.Text = "SGA Persia Mantenedor de Sucursales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Listar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Primero;
        private System.Windows.Forms.Button Btn_Anterior;
        private System.Windows.Forms.TextBox Txt_Actual;
        private System.Windows.Forms.Button Btn_Siguiente;
        private System.Windows.Forms.Button Btn_Ultimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_IdSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_NombreSucursal;
        private System.Windows.Forms.TextBox txt_DireccionSucursal;
    }
}