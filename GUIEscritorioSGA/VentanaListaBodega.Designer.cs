namespace GUIEscritorioSGA
{
    partial class VentanaListaBodega
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
            this.DataGridView_ListaBodega = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Location = new System.Drawing.Point(427, 407);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(92, 35);
            this.Btn_Actualizar.TabIndex = 5;
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
            this.Btn_Salir.TabIndex = 4;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // DataGridView_ListaBodega
            // 
            this.DataGridView_ListaBodega.AllowUserToAddRows = false;
            this.DataGridView_ListaBodega.AllowUserToDeleteRows = false;
            this.DataGridView_ListaBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ListaBodega.Location = new System.Drawing.Point(183, 8);
            this.DataGridView_ListaBodega.Name = "DataGridView_ListaBodega";
            this.DataGridView_ListaBodega.ReadOnly = true;
            this.DataGridView_ListaBodega.Size = new System.Drawing.Size(434, 380);
            this.DataGridView_ListaBodega.TabIndex = 3;
            this.DataGridView_ListaBodega.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ListaBodega_CellContentClick);
            // 
            // VentanaListaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.DataGridView_ListaBodega);
            this.Name = "VentanaListaBodega";
            this.Text = "SGA Persia Lista de Bodegas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaBodega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.DataGridView DataGridView_ListaBodega;
    }
}