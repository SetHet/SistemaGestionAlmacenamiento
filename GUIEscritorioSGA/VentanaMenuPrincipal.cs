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
    public partial class VentanaMenuPrincipal : Form
    {
        public VentanaMenuPrincipal()
        {
            InitializeComponent();
            this.Disposed += (object sender, EventArgs e) => VentanaLogin.Instancia.Mostrar();
            Txt_Saludo.Text = $"Bienvenido {EmpleadoLogueado.Empleado.Nombre} {EmpleadoLogueado.Empleado.Apellido}";
        }
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMantenedorTipoProducto ventanaMantenedorTipoProducto = new VentanaMantenedorTipoProducto();
            ventanaMantenedorTipoProducto.ShowDialog();
        }

        private void entradaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaTransaccionEntrada ventanaTransaccionEntrada = new VentanaTransaccionEntrada();
            ventanaTransaccionEntrada.ShowDialog();
        }
    }
}
