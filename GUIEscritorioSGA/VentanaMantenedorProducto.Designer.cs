namespace GUIEscritorioSGA
{
    partial class VentanaMantenedorProducto
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
            this.components = new System.ComponentModel.Container();
            this.Txt_Actual = new System.Windows.Forms.TextBox();
            this.Btn_Ultimo = new System.Windows.Forms.Button();
            this.Btn_Siguiente = new System.Windows.Forms.Button();
            this.Btn_Anterior = new System.Windows.Forms.Button();
            this.Btn_Primero = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Listar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Txt_IDProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Cm_IDTipo = new System.Windows.Forms.ComboBox();
            this.buscarResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarAllResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.buscarResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAllResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Actual
            // 
            this.Txt_Actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Actual.Location = new System.Drawing.Point(355, 330);
            this.Txt_Actual.Name = "Txt_Actual";
            this.Txt_Actual.ReadOnly = true;
            this.Txt_Actual.Size = new System.Drawing.Size(95, 26);
            this.Txt_Actual.TabIndex = 28;
            this.Txt_Actual.Text = "0 / 0";
            this.Txt_Actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Ultimo
            // 
            this.Btn_Ultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ultimo.Location = new System.Drawing.Point(599, 325);
            this.Btn_Ultimo.Name = "Btn_Ultimo";
            this.Btn_Ultimo.Size = new System.Drawing.Size(95, 36);
            this.Btn_Ultimo.TabIndex = 27;
            this.Btn_Ultimo.Text = ">>";
            this.Btn_Ultimo.UseVisualStyleBackColor = true;
            this.Btn_Ultimo.Click += new System.EventHandler(this.Btn_Ultimo_Click);
            // 
            // Btn_Siguiente
            // 
            this.Btn_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Siguiente.Location = new System.Drawing.Point(477, 325);
            this.Btn_Siguiente.Name = "Btn_Siguiente";
            this.Btn_Siguiente.Size = new System.Drawing.Size(95, 36);
            this.Btn_Siguiente.TabIndex = 26;
            this.Btn_Siguiente.Text = ">";
            this.Btn_Siguiente.UseVisualStyleBackColor = true;
            this.Btn_Siguiente.Click += new System.EventHandler(this.Btn_Siguiente_Click);
            // 
            // Btn_Anterior
            // 
            this.Btn_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Anterior.Location = new System.Drawing.Point(233, 325);
            this.Btn_Anterior.Name = "Btn_Anterior";
            this.Btn_Anterior.Size = new System.Drawing.Size(95, 36);
            this.Btn_Anterior.TabIndex = 25;
            this.Btn_Anterior.Text = "<";
            this.Btn_Anterior.UseVisualStyleBackColor = true;
            this.Btn_Anterior.Click += new System.EventHandler(this.Btn_Anterior_Click);
            // 
            // Btn_Primero
            // 
            this.Btn_Primero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Primero.Location = new System.Drawing.Point(111, 325);
            this.Btn_Primero.Name = "Btn_Primero";
            this.Btn_Primero.Size = new System.Drawing.Size(95, 36);
            this.Btn_Primero.TabIndex = 24;
            this.Btn_Primero.Text = "<<";
            this.Btn_Primero.UseVisualStyleBackColor = true;
            this.Btn_Primero.Click += new System.EventHandler(this.Btn_Primero_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(599, 262);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(95, 36);
            this.Btn_Salir.TabIndex = 23;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click_1);
            // 
            // Btn_Listar
            // 
            this.Btn_Listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Listar.Location = new System.Drawing.Point(477, 262);
            this.Btn_Listar.Name = "Btn_Listar";
            this.Btn_Listar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Listar.TabIndex = 22;
            this.Btn_Listar.Text = "Listar";
            this.Btn_Listar.UseVisualStyleBackColor = true;
            this.Btn_Listar.Click += new System.EventHandler(this.Btn_Listar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Location = new System.Drawing.Point(355, 262);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Actualizar.TabIndex = 21;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(233, 262);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Eliminar.TabIndex = 20;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.Location = new System.Drawing.Point(111, 262);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(95, 36);
            this.Btn_Nuevo.TabIndex = 19;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Txt_IDProducto
            // 
            this.Txt_IDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IDProducto.Location = new System.Drawing.Point(386, 36);
            this.Txt_IDProducto.Name = "Txt_IDProducto";
            this.Txt_IDProducto.ReadOnly = true;
            this.Txt_IDProducto.Size = new System.Drawing.Size(186, 26);
            this.Txt_IDProducto.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID Tipo Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Descripcion";
            // 
            // Txt_NombreProducto
            // 
            this.Txt_NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreProducto.Location = new System.Drawing.Point(386, 135);
            this.Txt_NombreProducto.MaxLength = 50;
            this.Txt_NombreProducto.Multiline = true;
            this.Txt_NombreProducto.Name = "Txt_NombreProducto";
            this.Txt_NombreProducto.Size = new System.Drawing.Size(186, 26);
            this.Txt_NombreProducto.TabIndex = 31;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.Location = new System.Drawing.Point(386, 178);
            this.Txt_Descripcion.MaxLength = 500;
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(186, 26);
            this.Txt_Descripcion.TabIndex = 32;
            // 
            // Cm_IDTipo
            // 
            this.Cm_IDTipo.DataSource = this.buscarResponseBindingSource;
            this.Cm_IDTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cm_IDTipo.FormattingEnabled = true;
            this.Cm_IDTipo.Location = new System.Drawing.Point(386, 87);
            this.Cm_IDTipo.Name = "Cm_IDTipo";
            this.Cm_IDTipo.Size = new System.Drawing.Size(186, 28);
            this.Cm_IDTipo.TabIndex = 33;
            this.Cm_IDTipo.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            // 
            // buscarResponseBindingSource
            // 
            this.buscarResponseBindingSource.DataSource = typeof(GUIEscritorioSGA.ServiceTipoProducto.BuscarResponse);
            // 
            // buscarAllResponseBindingSource
            // 
            this.buscarAllResponseBindingSource.DataSource = typeof(GUIEscritorioSGA.ServiceTipoProducto.BuscarAllResponse);
            // 
            // VentanaMantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cm_IDTipo);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Txt_NombreProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Actual);
            this.Controls.Add(this.Btn_Ultimo);
            this.Controls.Add(this.Btn_Siguiente);
            this.Controls.Add(this.Btn_Anterior);
            this.Controls.Add(this.Btn_Primero);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Listar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Txt_IDProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaMantenedorProducto";
            this.Text = "SGA Persia Mantenedor de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.buscarResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarAllResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Actual;
        private System.Windows.Forms.Button Btn_Ultimo;
        private System.Windows.Forms.Button Btn_Siguiente;
        private System.Windows.Forms.Button Btn_Anterior;
        private System.Windows.Forms.Button Btn_Primero;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Listar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.TextBox Txt_IDProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_NombreProducto;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.ComboBox Cm_IDTipo;
        private System.Windows.Forms.BindingSource buscarAllResponseBindingSource;
        private System.Windows.Forms.BindingSource buscarResponseBindingSource;
    }
}