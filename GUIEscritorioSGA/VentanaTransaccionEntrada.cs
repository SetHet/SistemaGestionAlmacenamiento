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
    public partial class VentanaTransaccionEntrada : Form
    {
        public VentanaTransaccionEntrada()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void Btn_Completar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_0_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_menos10_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_menos1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_mas1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cant_mas10_Click(object sender, EventArgs e)
        {

        }
    }
}
