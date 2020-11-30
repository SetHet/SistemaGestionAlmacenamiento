using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUIEscritorioSGA.ServiceProveedor;

namespace GUIEscritorioSGA
{
    public partial class VentanaMantenedorProveedor : Form
    {
        public VentanaMantenedorProveedor()
        {
            InitializeComponent();
            
            AuxServiceProveedor = new ServiceProveedor.WebServiceProveedorSoapClient();
            TerminarGuardado();
        }

        private bool enGuardado;
        private int posicionLista;
        private ServiceProveedor.WebServiceProveedorSoapClient auxServiceProveedor;
        private ServiceProveedor.MDProveedor auxProveedor;
        private List<ServiceProveedor.MDProveedor> auxListaProveedor;

        public bool EnGuardado { get => enGuardado; set => enGuardado = value; }
        public int PosicionLista { get => posicionLista; set => posicionLista = value; }
        public WebServiceProveedorSoapClient AuxServiceProveedor { get => auxServiceProveedor; set => auxServiceProveedor = value; }
        public MDProveedor AuxProveedor { get => auxProveedor; set => auxProveedor = value; }
        public List<MDProveedor> AuxListaProveedor { get => auxListaProveedor; set => auxListaProveedor = value; }

        private void ComenzarGuardado()
        {
            EnGuardado = true;
            Txt_NombreProveedor.Clear();
            txt_DireccionProveedor.Clear();
            Txt_IdProveedor.Text = "ID automatico";
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
            AuxListaProveedor = auxServiceProveedor.BuscarAll().ToList();
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            if (PosicionLista >= AuxListaProveedor.Count)
            {
                PosicionLista = AuxListaProveedor.Count - 1;
            }
            if (PosicionLista < 0)
            {
                PosicionLista = 0;
            }

            if (AuxListaProveedor.Count > 0)
            {
                Txt_Actual.Text = (PosicionLista + 1) + " / " + AuxListaProveedor.Count;
                Txt_IdProveedor.Text = AuxListaProveedor[PosicionLista].IdProveedor.ToString();
                Txt_NombreProveedor.Text = AuxListaProveedor[PosicionLista].Nombre;
                txt_DireccionProveedor.Text = AuxListaProveedor[PosicionLista].Direccion;
            }
            else
            {
                Txt_Actual.Text = "0 / 0";
                Txt_IdProveedor.Clear();
                Txt_NombreProveedor.Clear();
                txt_DireccionProveedor.Clear();
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
                if (Txt_NombreProveedor.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar un nombre de Proveedor Correcto", "Sistema");
                    return;
                }
                if (txt_DireccionProveedor.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar una direccion de Proveedor Correcto", "Sistema");
                    return;
                }


                auxServiceProveedor.InsertWithValues(Txt_NombreProveedor.Text, txt_DireccionProveedor.Text);
                TerminarGuardado();
                MessageBox.Show("Elementos guardados correctamente", "Sistema");
            }
            else
            {
                ComenzarGuardado();
            }
        }

        private void Btn_Listar_Click(object sender, EventArgs e)
        {
         //   VentanaListaProveedor auxListaProveedor = new VentanaListaProveedor();
          //  auxListaProveedor.ShowDialog();
        }

     

        

        private void Btn_Ultimo_Click(object sender, EventArgs e)
        {
            PosicionLista = auxListaProveedor.Count - 1;
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





        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Txt_IdProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NombreProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (auxListaProveedor.Count > 0)
            {
                bool resultado = auxServiceProveedor.Delete(int.Parse(Txt_IdProveedor.Text));
                if (resultado == false)
                {
                    MessageBox.Show("No se puede eliminar el elemento.", "Sistema");
                }
                else
                {
                   
                    ActualizarLista();
                    MessageBox.Show("Elementos eliminados correctamente","Sistema");
                }
            }
            else
            {
                MessageBox.Show("No hay elementos que Eliminar.", "Sistema");
            }
        }

        private void Btn_Listar_Click_1(object sender, EventArgs e)
        {
            VentanaListaProveedor auxListaProveedor = new VentanaListaProveedor();
            auxListaProveedor.ShowDialog();
        }

        private void Btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            if (Txt_NombreProveedor.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar un nombre de proveedor valido.", "Sistema");
                return;
            }
            if (txt_DireccionProveedor.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar una direccion valida.", "Sistema");
                return;
            }
            if (auxListaProveedor.Count > 0)
            {
                bool resultado = auxServiceProveedor.UpdateWithValues(int.Parse(Txt_IdProveedor.Text), Txt_NombreProveedor.Text, txt_DireccionProveedor.Text);
                if (resultado == false)
                {
                    MessageBox.Show("No se puede actualizar el elemento.", "Sistema");
                }
                else
                {
                    ActualizarLista();
                    MessageBox.Show("Elementos actualizados correctamente", "Sistema");
                }
            }
            else
            {
                MessageBox.Show("No hay elementos que Actualizar.", "Sistema");
            }
        }

        private void Btn_Salir_Click_1(object sender, EventArgs e)
        {
            if(EnGuardado)
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

        private void Btn_Primero_Click_1(object sender, EventArgs e)
        {
            PosicionLista = 0;
            ActualizarPantalla();
        }

        private void Btn_Anterior_Click_1(object sender, EventArgs e)
        {
            PosicionLista -= 1;
            ActualizarPantalla();
        }

        private void Btn_Siguiente_Click_1(object sender, EventArgs e)
        {
            PosicionLista += 1;
            ActualizarPantalla();
        }

        private void Btn_Ultimo_Click_1(object sender, EventArgs e)
        {
            PosicionLista = auxListaProveedor.Count - 1;
            ActualizarPantalla();
        }
    }
}
