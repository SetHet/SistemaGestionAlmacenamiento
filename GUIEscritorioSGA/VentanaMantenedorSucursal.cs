using GUIEscritorioSGA.ServiceSucursal;
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
    public partial class VentanaMantenedorSucursal : Form
    {
        public VentanaMantenedorSucursal()
        {
            InitializeComponent();
            AuxServiceSucursal = new ServiceSucursal.WebServiceSucursalSoapClient();
            TerminarGuardado();
        }
        private bool enGuardado;
        private int posicionLista;
        private ServiceSucursal.WebServiceSucursalSoapClient auxServiceSucursal;
        private ServiceSucursal.MDSucursal auxSucursal;
        private List<ServiceSucursal.MDSucursal> auxListaSucursal;

        public bool EnGuardado { get => enGuardado; set => enGuardado = value; }
        public int PosicionLista { get => posicionLista; set => posicionLista = value; }
        public WebServiceSucursalSoapClient AuxServiceSucursal { get => auxServiceSucursal; set => auxServiceSucursal = value; }
        public MDSucursal AuxSucursal { get => auxSucursal; set => auxSucursal = value; }
        public List<MDSucursal> AuxListaSucursal { get => auxListaSucursal; set => auxListaSucursal = value; }

        private void ComenzarGuardado()
        {
            EnGuardado = true;
            Txt_NombreSucursal.Clear();
            txt_DireccionSucursal.Clear();
            Txt_IdSucursal.Text = "ID automatico";
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
            AuxListaSucursal = auxServiceSucursal.BuscarAll().ToList();
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            if (PosicionLista >= AuxListaSucursal.Count)
            {
                PosicionLista = AuxListaSucursal.Count - 1;
            }
            if (PosicionLista < 0)
            {
                PosicionLista = 0;
            }

            if (AuxListaSucursal.Count > 0)
            {
                Txt_Actual.Text = (PosicionLista + 1) + " / " + AuxListaSucursal.Count;
                Txt_IdSucursal.Text = AuxListaSucursal[PosicionLista].IdSucursal.ToString();
                Txt_NombreSucursal.Text = AuxListaSucursal[PosicionLista].Nombre;
                txt_DireccionSucursal.Text = AuxListaSucursal[PosicionLista].Direccion;
            }
            else
            {
                Txt_Actual.Text = "0 / 0";
                Txt_IdSucursal.Clear();
                Txt_NombreSucursal.Clear();
                txt_DireccionSucursal.Clear();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void Txt_Actual_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            PosicionLista += 1;
            ActualizarPantalla();
        }

        private void Btn_Ultimo_Click(object sender, EventArgs e)
        {
            PosicionLista = auxListaSucursal.Count - 1;
            ActualizarPantalla();
        }

        private void txtIdSucursal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccionSucursal_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (EnGuardado)
            {
                if (Txt_NombreSucursal.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar un nombre de Sucursal Correcto", "Sistema");
                    return;
                }
                if (txt_DireccionSucursal.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar una direccion de Sucursal Correcto", "Sistema");
                    return;
                }

                auxServiceSucursal.InsertWithValues(Txt_NombreSucursal.Text, txt_DireccionSucursal.Text);
                TerminarGuardado();
            }
            else
            {
                ComenzarGuardado();
            }
        }

        private void txt_DireccionSucursal_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (auxListaSucursal.Count > 0)
            {
                bool resultado = auxServiceSucursal.Delete(int.Parse(Txt_IdSucursal.Text));
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (Txt_NombreSucursal.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar un nombre de tipo valido.", "Sistema");
                return;
            }
            if (txt_DireccionSucursal.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar una direccion valida.", "Sistema");
                return;
            }
            if (auxListaSucursal.Count > 0)
            {
                bool resultado = auxServiceSucursal.UpdateWithValues(int.Parse(Txt_IdSucursal.Text), Txt_NombreSucursal.Text, txt_DireccionSucursal.Text);
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

        private void BtnListar_Click(object sender, EventArgs e)
        {
            VentanaListaSucursal auxListaSucursal = new VentanaListaSucursal();
            auxListaSucursal.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
    }
}
