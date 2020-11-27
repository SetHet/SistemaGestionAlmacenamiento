namespace GUIEscritorioSGA
{
    partial class VentanaMantenedorBodega
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
            this.txt_DireccionBodega = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Txt_IdBodega = new System.Windows.Forms.TextBox();
            this.Txt_NombreBodega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_DireccionBodega
            // 
            this.txt_DireccionBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DireccionBodega.Location = new System.Drawing.Point(404, 176);
            this.txt_DireccionBodega.Name = "txt_DireccionBodega";
            this.txt_DireccionBodega.ReadOnly = true;
            this.txt_DireccionBodega.Size = new System.Drawing.Size(186, 26);
            this.txt_DireccionBodega.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID Bodega";
            // 
            // Txt_Actual
            // 
            this.Txt_Actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Actual.Location = new System.Drawing.Point(353, 347);
            this.Txt_Actual.Name = "Txt_Actual";
            this.Txt_Actual.ReadOnly = true;
            this.Txt_Actual.Size = new System.Drawing.Size(95, 26);
            this.Txt_Actual.TabIndex = 40;
            this.Txt_Actual.Text = "0 / 0";
            this.Txt_Actual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Ultimo
            // 
            this.Btn_Ultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ultimo.Location = new System.Drawing.Point(597, 342);
            this.Btn_Ultimo.Name = "Btn_Ultimo";
            this.Btn_Ultimo.Size = new System.Drawing.Size(95, 36);
            this.Btn_Ultimo.TabIndex = 39;
            this.Btn_Ultimo.Text = ">>";
            this.Btn_Ultimo.UseVisualStyleBackColor = true;
            // 
            // Btn_Siguiente
            // 
            this.Btn_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Siguiente.Location = new System.Drawing.Point(475, 342);
            this.Btn_Siguiente.Name = "Btn_Siguiente";
            this.Btn_Siguiente.Size = new System.Drawing.Size(95, 36);
            this.Btn_Siguiente.TabIndex = 38;
            this.Btn_Siguiente.Text = ">";
            this.Btn_Siguiente.UseVisualStyleBackColor = true;
            // 
            // Btn_Anterior
            // 
            this.Btn_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Anterior.Location = new System.Drawing.Point(231, 342);
            this.Btn_Anterior.Name = "Btn_Anterior";
            this.Btn_Anterior.Size = new System.Drawing.Size(95, 36);
            this.Btn_Anterior.TabIndex = 37;
            this.Btn_Anterior.Text = "<";
            this.Btn_Anterior.UseVisualStyleBackColor = true;
            // 
            // Btn_Primero
            // 
            this.Btn_Primero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Primero.Location = new System.Drawing.Point(109, 342);
            this.Btn_Primero.Name = "Btn_Primero";
            this.Btn_Primero.Size = new System.Drawing.Size(95, 36);
            this.Btn_Primero.TabIndex = 36;
            this.Btn_Primero.Text = "<<";
            this.Btn_Primero.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(597, 279);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(95, 36);
            this.Btn_Salir.TabIndex = 35;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Btn_Listar
            // 
            this.Btn_Listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Listar.Location = new System.Drawing.Point(475, 279);
            this.Btn_Listar.Name = "Btn_Listar";
            this.Btn_Listar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Listar.TabIndex = 34;
            this.Btn_Listar.Text = "Listar";
            this.Btn_Listar.UseVisualStyleBackColor = true;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Location = new System.Drawing.Point(353, 279);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Actualizar.TabIndex = 33;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(231, 279);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(95, 36);
            this.Btn_Eliminar.TabIndex = 32;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.Location = new System.Drawing.Point(109, 279);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(95, 36);
            this.Btn_Nuevo.TabIndex = 31;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // Txt_IdBodega
            // 
            this.Txt_IdBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdBodega.Location = new System.Drawing.Point(404, 73);
            this.Txt_IdBodega.Name = "Txt_IdBodega";
            this.Txt_IdBodega.ReadOnly = true;
            this.Txt_IdBodega.Size = new System.Drawing.Size(186, 26);
            this.Txt_IdBodega.TabIndex = 30;
            // 
            // Txt_NombreBodega
            // 
            this.Txt_NombreBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreBodega.Location = new System.Drawing.Point(404, 124);
            this.Txt_NombreBodega.Name = "Txt_NombreBodega";
            this.Txt_NombreBodega.ReadOnly = true;
            this.Txt_NombreBodega.Size = new System.Drawing.Size(186, 26);
            this.Txt_NombreBodega.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre Bodega";
            // 
            // VentanaMantenedorBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_DireccionBodega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.Txt_IdBodega);
            this.Controls.Add(this.Txt_NombreBodega);
            this.Controls.Add(this.label2);
            this.Name = "VentanaMantenedorBodega";
            this.Text = "VentanaMantenedorBodega";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DireccionBodega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox Txt_IdBodega;
        private System.Windows.Forms.TextBox Txt_NombreBodega;
        private System.Windows.Forms.Label label2;
    }
}