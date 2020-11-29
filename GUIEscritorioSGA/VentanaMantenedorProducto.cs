using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUIEscritorioSGA.ServiceProducto;

namespace GUIEscritorioSGA
{
    public partial class VentanaMantenedorProducto : Form
    {
        public VentanaMantenedorProducto()
        {
            InitializeComponent();
            AuxServiceProducto = new ServiceProducto.WebServiceProductoSoapClient();
            TerminarGuardado();
        }
        private bool enGuardado;
        private int posicionLista;
        private ServiceProducto.WebServiceProductoSoapClient auxServiceProducto;
        private ServiceProducto.MDProducto auxProducto;
        private List<ServiceProducto.MDProducto> auxListaProducto;

        public bool EnGuardado { get => enGuardado; set => enGuardado = value; }
        public int PosicionLista { get => posicionLista; set => posicionLista = value; }
        public WebServiceProductoSoapClient AuxServiceProducto { get => auxServiceProducto; set => auxServiceProducto = value; }
        public MDProducto AuxProducto { get => auxProducto; set => auxProducto = value; }
        public List<MDProducto> AuxListaProducto { get => auxListaProducto; set => auxListaProducto = value; }

        private void ComenzarGuardado()
        {
            EnGuardado = true;
            Txt_NombreProducto.Clear();
            Txt_Descripcion .Clear();
            Txt_IdTipoProducto.Text = "ID automatico";
            Txt_IDProducto.Text = "ID automatico";
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
            ActualizarLista();

            Btn_Nuevo.Text = "Nuevo";
            Btn_Salir.Text = "Salir";
            Btn_Eliminar.Enabled = true;
            Btn_Actualizar.Enabled = true;
            Btn_Anterior.Enabled = true;
            Btn_Primero.Enabled = true;
            Btn_Siguiente.Enabled = true;
            Btn_Ultimo.Enabled = true;
        }

        private void ActualizarLista()
        {
            AuxListaProducto = auxServiceProducto.BuscarAll().ToList();
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            if (PosicionLista >= AuxListaProducto.Count)
            {
                PosicionLista = AuxListaProducto.Count - 1;
            }
            if (PosicionLista < 0)
            {
                PosicionLista = 0;
            }

            if (AuxListaProducto.Count > 0)
            {
                Txt_Actual.Text = (PosicionLista + 1) + " / " + AuxListaProducto.Count;
                Txt_IDProducto.Text = AuxListaProducto[PosicionLista].IdProducto.ToString();
                Txt_IdTipoProducto.Text = AuxListaProducto[PosicionLista].IdProducto.ToString();
                Txt_NombreProducto.Text = AuxListaProducto[PosicionLista].Nombre;
                Txt_Descripcion.Text = AuxListaProducto[PosicionLista].Descripcion;
            }
            else
            {
                Txt_Actual.Text = "0 / 0";
                Txt_IDProducto.Clear();
                Txt_IdTipoProducto.Clear();
                Txt_NombreProducto.Clear();
                Txt_Descripcion.Clear();
            }
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            if (EnGuardado)
            {
                if (Txt_NombreProducto.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar un nombre de Producto Correcto", "Sistema");
                    return;
                }
                if (Txt_Descripcion.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar una direccion de Producto Correcto", "Sistema");
                    return;
                }

                auxServiceProducto.InsertWithValues(int.Parse(Txt_IdTipoProducto.Text), Txt_NombreProducto.Text, Txt_Descripcion.Text);
                TerminarGuardado();
            }
            else
            {
                ComenzarGuardado();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (auxListaProducto.Count > 0)
            {
                bool resultado = auxServiceProducto.Delete(int.Parse(Txt_IDProducto.Text));
                if (resultado == false)
                {
                    MessageBox.Show("No se puede eliminar el elemento.", "Sistema");
                }
                else
                {
                    ActualizarLista();
                }
            }
            else
            {
                MessageBox.Show("No hay elementos que Eliminar.", "Sistema");
            }
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            
            if (Txt_NombreProducto.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar un nombre de tipo valido.", "Sistema");
                return;
            }

            if (Txt_Descripcion .Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar una direccion valida.", "Sistema");
                return;
            }
            if (auxListaProducto.Count > 0)
            {
                bool resultado = auxServiceProducto.UpdateWithValues( int.Parse(Txt_IDProducto.Text), int.Parse(Txt_IdTipoProducto.Text), Txt_NombreProducto.Text, Txt_Descripcion.Text);
                if (resultado == false)
                {
                    MessageBox.Show("No se puede actualizar el elemento.", "Sistema");
                }
                else
                {
                    ActualizarLista();
                }
            }
            else
            {
                MessageBox.Show("No hay elementos que Actualizar.", "Sistema");
            }
        }

        private void Btn_Listar_Click(object sender, EventArgs e)
        {
            VentanaListaProducto auxListaProducto = new VentanaListaProducto();
            auxListaProducto.ShowDialog();
        }

        private void Btn_Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Primero_Click(object sender, EventArgs e)
        {
            PosicionLista = 0;
            ActualizarPantalla();
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            PosicionLista -= 1;
            ActualizarPantalla();
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            PosicionLista += 1;
            ActualizarPantalla();
        }

        private void Btn_Ultimo_Click(object sender, EventArgs e)
        {
            PosicionLista = auxListaProducto.Count - 1;
            ActualizarPantalla();
        }
    }
}
