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

        private void salidaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaTransaccionSalida ventanaTransaccionSalida = new VentanaTransaccionSalida();
            ventanaTransaccionSalida.ShowDialog();
        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMantenedorBodega ventanaMantenedorBodega = new VentanaMantenedorBodega();
            ventanaMantenedorBodega.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMantenedorProveedor ventanaMantenedorProveedor = new VentanaMantenedorProveedor();
            ventanaMantenedorProveedor.ShowDialog();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMantenedorSucursal ventanaMantenedorSucursal = new VentanaMantenedorSucursal();
            ventanaMantenedorSucursal.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMantenedorProducto ventanaMantenedorProducto = new VentanaMantenedorProducto();
            ventanaMantenedorProducto.ShowDialog();

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMantenedorEmpleado ventanaMantenedorEmpleado = new VentanaMantenedorEmpleado();
            ventanaMantenedorEmpleado.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaInformeMoreStock ventanaInformeMoreStock = new VentanaInformeMoreStock();
            ventanaInformeMoreStock.ShowDialog();
        }

        private void entradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaInformeMoreEntrada ventanaInformeMoreEntrada = new VentanaInformeMoreEntrada();
            ventanaInformeMoreEntrada.ShowDialog();
        }

        private void salidaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaInformeMoreSalida ventanaInformeMoreSalida = new VentanaInformeMoreSalida();
            ventanaInformeMoreSalida.ShowDialog();
        }

        private void stockTipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaInformeStockTipoProducto ventanaInformeStockTipoProducto = new VentanaInformeStockTipoProducto();
            ventanaInformeStockTipoProducto.ShowDialog();
        }
    }
}
