using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUIEscritorioSGA
{
    public partial class VentanaMantenedorTipoProducto : Form
    {
        public VentanaMantenedorTipoProducto()
        {
            InitializeComponent();
            TerminarGuardado();
        }

        private bool enGuardado;

        public bool EnGuardado { get => enGuardado; set => enGuardado = value; }

        private void ComenzarGuardado()
        {
            EnGuardado = true;
            Txt_Nombre.Clear();
            
            Txt_ID.Text = "ID automatico";
            Btn_Nuevo.Text = "Guardar";
            Btn_Salir.Text = "Cancelar";
            Btn_Eliminar.Enabled = false;
            Btn_Actualizar.Enabled = false;
            Btn_Anterior.Enabled = false;
            Btn_Primero.Enabled = false;
            Btn_Siguiente.Enabled = false;
            Btn_Ultimo.Enabled = false;
        }

        private void TerminarGuardado()
        {
            EnGuardado = false;
            Actualizar();

            Btn_Nuevo.Text = "Nuevo";
            Btn_Salir.Text = "Salir";
            Btn_Eliminar.Enabled = true;
            Btn_Actualizar.Enabled = true;
            Btn_Anterior.Enabled = true;
            Btn_Primero.Enabled = true;
            Btn_Siguiente.Enabled = true;
            Btn_Ultimo.Enabled = true;
        }

        private void Actualizar()
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (EnGuardado)
            {
                TerminarGuardado();
            }
            else
            {
                this.Dispose();
                GC.Collect();
                this.Close();
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            if (EnGuardado)
            {
                //
            }
            else
            {
                ComenzarGuardado();
            }
        }

        private void Btn_Listar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ultimo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Primero_Click(object sender, EventArgs e)
        {

        }
    }
}
