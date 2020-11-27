using GUIEscritorioSGA.ServiceTipoProducto;
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
            AuxServiceTipoProducto = new ServiceTipoProducto.WebServiceTipoProductoSoapClient();
            TerminarGuardado();
        }

        private bool enGuardado;
        private int posicionLista;
        private ServiceTipoProducto.WebServiceTipoProductoSoapClient auxServiceTipoProducto;
        private ServiceTipoProducto.MDTipoProducto auxTipoProducto;
        private List<ServiceTipoProducto.MDTipoProducto> auxListaTiposProductos;

        public bool EnGuardado { get => enGuardado; set => enGuardado = value; }
        public int PosicionLista { get => posicionLista; set => posicionLista = value; }
        public WebServiceTipoProductoSoapClient AuxServiceTipoProducto { get => auxServiceTipoProducto; set => auxServiceTipoProducto = value; }
        public MDTipoProducto AuxTipoProducto { get => auxTipoProducto; set => auxTipoProducto = value; }
        public List<MDTipoProducto> AuxListaTiposProductos { get => auxListaTiposProductos; set => auxListaTiposProductos = value; }

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
            AuxListaTiposProductos = auxServiceTipoProducto.BuscarAll().ToList();
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            if (PosicionLista >= AuxListaTiposProductos.Count)
            {
                PosicionLista = AuxListaTiposProductos.Count - 1;
            }
            if (PosicionLista < 0)
            {
                PosicionLista = 0;
            }

            if (AuxListaTiposProductos.Count > 0)
            {
                Txt_Actual.Text = (PosicionLista + 1) + " / " + AuxListaTiposProductos.Count;
                Txt_ID.Text = AuxListaTiposProductos[PosicionLista].IdTipoProducto.ToString();
                Txt_Nombre.Text = AuxListaTiposProductos[PosicionLista].NombreTipo;
            }
            else
            {
                Txt_Actual.Text = "0 / 0";
                Txt_ID.Clear();
                Txt_Nombre.Clear();
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

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            if (EnGuardado)
            {
                if (Txt_Nombre.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar un nombre de Tipo de Producto Correcto", "Sistema");
                    return;
                }

                auxServiceTipoProducto.InsertWithValues(Txt_Nombre.Text);
                TerminarGuardado();
            }
            else
            {
                ComenzarGuardado();
            }
        }

        private void Btn_Listar_Click(object sender, EventArgs e)
        {
            VentanaListaTipoProducto auxListaTipoProductos = new VentanaListaTipoProducto();
            auxListaTipoProductos.ShowDialog();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (Txt_Nombre.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar un nombre de tipo valido.", "Sistema");
                return;
            }
            if (auxListaTiposProductos.Count > 0)
            {
                bool resultado = auxServiceTipoProducto.UpdateWithValues(int.Parse(Txt_ID.Text), Txt_Nombre.Text);
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

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (auxListaTiposProductos.Count > 0) {
                bool resultado = auxServiceTipoProducto.Delete(int.Parse(Txt_ID.Text));
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

        private void Btn_Ultimo_Click(object sender, EventArgs e)
        {
            PosicionLista = auxListaTiposProductos.Count - 1;
            ActualizarPantalla();
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            PosicionLista += 1;
            ActualizarPantalla();
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            PosicionLista -= 1;
            ActualizarPantalla();
        }

        private void Btn_Primero_Click(object sender, EventArgs e)
        {
            PosicionLista = 0;
            ActualizarPantalla();
        }
    }
}
