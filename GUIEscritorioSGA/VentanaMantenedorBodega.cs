using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUIEscritorioSGA.ServiceBodega;

namespace GUIEscritorioSGA
{
    public partial class VentanaMantenedorBodega : Form
    {
        public VentanaMantenedorBodega()
        {
            InitializeComponent();
            AuxServiceBodega = new ServiceBodega.WebServiceBodegaSoapClient();
            TerminarGuardado();
        }
        private bool enGuardado;
        private int posicionLista;
        private ServiceBodega.WebServiceBodegaSoapClient auxServiceBodega;
        private ServiceBodega.MDBodega auxBodega;
        private List<ServiceBodega.MDBodega> auxListaBodega;

        public bool EnGuardado { get => enGuardado; set => enGuardado = value; }
        public int PosicionLista { get => posicionLista; set => posicionLista = value; }
        public WebServiceBodegaSoapClient AuxServiceBodega { get => auxServiceBodega; set => auxServiceBodega = value; }
        public MDBodega AuxBodega { get => auxBodega; set => auxBodega = value; }
        public List<MDBodega> AuxListaBodega { get => auxListaBodega; set => auxListaBodega = value; }

        private void ComenzarGuardado()
        {
            EnGuardado = true;
            Txt_NombreBodega.Clear();
            txt_DireccionBodega.Clear();
            Txt_IdBodega.Text = "ID automatico";
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
            AuxListaBodega = auxServiceBodega.BuscarAll().ToList();
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            if (PosicionLista >= AuxListaBodega.Count)
            {
                PosicionLista = AuxListaBodega.Count - 1;
            }
            if (PosicionLista < 0)
            {
                PosicionLista = 0;
            }

            if (AuxListaBodega.Count > 0)
            {
                Txt_Actual.Text = (PosicionLista + 1) + " / " + AuxListaBodega.Count;
                Txt_IdBodega.Text = AuxListaBodega[PosicionLista].IdBodega.ToString();
                Txt_NombreBodega.Text = AuxListaBodega[PosicionLista].Nombre;
                txt_DireccionBodega.Text = AuxListaBodega[PosicionLista].Direccion;
            }
            else
            {
                Txt_Actual.Text = "0 / 0";
                Txt_IdBodega.Clear();
                Txt_NombreBodega.Clear();
                txt_DireccionBodega.Clear();
            }
        }

       

        private void Txt_IdBodega_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NombreBodega_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click_1(object sender, EventArgs e)
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

        private void Btn_Nuevo_Click_1(object sender, EventArgs e)
        {
            if (EnGuardado)
            {
                if (Txt_NombreBodega.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar un nombre de Bodega Correcto", "Sistema");
                    return;
                }
                if (txt_DireccionBodega.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar una direccion de Bodega Correcto", "Sistema");
                    return;
                }

                auxServiceBodega.InsertWithValues(Txt_NombreBodega.Text,txt_DireccionBodega.Text);
                TerminarGuardado();
            }
            else
            {
                ComenzarGuardado();
            }
        }

        private void Btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (auxListaBodega.Count > 0)
            {
                bool resultado = auxServiceBodega.Delete(int.Parse(Txt_IdBodega.Text));
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

        private void Btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            if (Txt_NombreBodega.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar un nombre de tipo valido.", "Sistema");
                return;
            }
            if (txt_DireccionBodega.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar una direccion valida.", "Sistema");
                return;
            }
            if (auxListaBodega.Count > 0)
            {
                bool resultado = auxServiceBodega.UpdateWithValues(int.Parse(Txt_IdBodega.Text), Txt_NombreBodega.Text , txt_DireccionBodega.Text);
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

        private void Btn_Listar_Click_1(object sender, EventArgs e)
        {
            VentanaListaBodega auxListaBodega = new VentanaListaBodega();
            auxListaBodega.ShowDialog();
        }

        private void Btn_Siguiente_Click_1(object sender, EventArgs e)
        {
            PosicionLista += 1;
            ActualizarPantalla();
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

        private void Btn_Ultimo_Click_1(object sender, EventArgs e)
        {
            PosicionLista = auxListaBodega.Count - 1;
            ActualizarPantalla();
        }

        private void Txt_NombreBodega_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
