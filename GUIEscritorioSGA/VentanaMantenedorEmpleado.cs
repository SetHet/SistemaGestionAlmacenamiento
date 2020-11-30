using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUIEscritorioSGA.ServiceEmpleado ;

namespace GUIEscritorioSGA
{
    public partial class VentanaMantenedorEmpleado : Form
    {
        public VentanaMantenedorEmpleado()
        {
            InitializeComponent();
            AuxServiceEmpleado = new ServiceEmpleado.WebServiceEmpleadoSoapClient();
            TerminarGuardado();
        }
        private bool enGuardado;
        private int posicionLista;
        private ServiceEmpleado.WebServiceEmpleadoSoapClient auxServiceEmpleado;
        private ServiceEmpleado.MDEmpleado auxEmpleado;
        private List<ServiceEmpleado.MDEmpleado> auxListaEmpleado;

        public bool EnGuardado { get => enGuardado; set => enGuardado = value; }
        public int PosicionLista { get => posicionLista; set => posicionLista = value; }
        public WebServiceEmpleadoSoapClient AuxServiceEmpleado { get => auxServiceEmpleado; set => auxServiceEmpleado = value; }
        public MDEmpleado AuxEmpleado { get => auxEmpleado; set => auxEmpleado = value; }
        public List<MDEmpleado> AuxListaEmpleado { get => auxListaEmpleado; set => auxListaEmpleado = value; }

        private void ComenzarGuardado()
        {
            EnGuardado = true;
            Txt_NombreEmpleado.Clear();
            Txt_RutEmpleado.Clear();
            Txt_ApellidoEmpleado.Clear();
            Txt_Contraseña.Clear();
            Btn_Nuevo.Text = "Guardar";
            Btn_Salir.Text = "Cancelar";
            Btn_Eliminar.Enabled = false;
            Btn_Actualizar.Enabled = false;
            Btn_Anterior.Enabled = false;
            Btn_Primero.Enabled = false;
            Btn_Siguiente.Enabled = false;
            Btn_Ultimo.Enabled = false;
            Txt_RutEmpleado.Enabled = true;
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
            Txt_RutEmpleado.Enabled = false;
        }

        private void ActualizarLista()
        {
            AuxListaEmpleado = auxServiceEmpleado.BuscarAll().ToList();
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            if (PosicionLista >= AuxListaEmpleado.Count)
            {
                PosicionLista = AuxListaEmpleado.Count - 1;
            }
            if (PosicionLista < 0)
            {
                PosicionLista = 0;
            }

            if (AuxListaEmpleado.Count > 0)
            {
                Txt_Actual.Text = (PosicionLista + 1) + " / " + AuxListaEmpleado.Count;
                Txt_RutEmpleado.Text = AuxListaEmpleado[PosicionLista].Rut;
                Txt_NombreEmpleado.Text = AuxListaEmpleado[PosicionLista].Nombre;
                Txt_ApellidoEmpleado.Text = AuxListaEmpleado[PosicionLista].Apellido;
                Txt_Contraseña.Text = AuxListaEmpleado[PosicionLista].Password;
            }
            else
            {
                Txt_Actual.Text = "0 / 0";
                Txt_RutEmpleado.Clear();
                Txt_NombreEmpleado.Clear();
                Txt_ApellidoEmpleado.Clear();
                Txt_Contraseña.Clear();
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_NombreEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            if (EnGuardado)
            {
                if (Txt_RutEmpleado.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar un rut de Empleado Correcto", "Sistema");
                    return;
                }
                if (Txt_NombreEmpleado.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar un nombre de Empleado Correcto", "Sistema");
                    return;
                }
                if (Txt_ApellidoEmpleado.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar un apellido de Empleado Correcto", "Sistema");
                    return;
                }
                if (Txt_Contraseña.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar una contraseña correcta", "Sistema");
                    return;
                }

                auxServiceEmpleado.InsertWithValues(Txt_RutEmpleado.Text, Txt_NombreEmpleado.Text, Txt_ApellidoEmpleado.Text,Txt_Contraseña.Text);
                TerminarGuardado();
            }
            else
            {
                ComenzarGuardado();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (auxListaEmpleado.Count > 0)
            {
                bool resultado = auxServiceEmpleado.Delete(Txt_RutEmpleado.Text);
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
            if (Txt_RutEmpleado.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar un rut valido.", "Sistema");
                return;
            }
            if (Txt_NombreEmpleado.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar un nombre  valido.", "Sistema");
                return;
            }
            if (Txt_ApellidoEmpleado.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar un apellido valido.", "Sistema");
                return;
            }
            if (Txt_Contraseña.Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar una contraseña valida.", "Sistema");
                return;
            }
            if (auxListaEmpleado.Count > 0)
            {
                bool resultado = auxServiceEmpleado.UpdateWithValues (Txt_RutEmpleado.Text, Txt_NombreEmpleado.Text, Txt_ApellidoEmpleado.Text,Txt_Contraseña.Text);
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
            VentanaListaEmpleado auxListaEmpleado = new VentanaListaEmpleado();
            auxListaEmpleado.ShowDialog();
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
            PosicionLista = auxListaEmpleado.Count - 1;
            ActualizarPantalla();
        }
    }
}
