﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUIEscritorioSGA
{
    public partial class VentanaLogin : Form
    {
        private static VentanaLogin instancia;

        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static VentanaLogin Instancia { get => instancia; set => instancia = value; }

        private void Btn_Acceder_Click(object sender, EventArgs e)
        {
            ServiceEmpleado.WebServiceEmpleadoSoapClient auxServiceEmpleado = new ServiceEmpleado.WebServiceEmpleadoSoapClient();
            ServiceEmpleado.MDEmpleado empleado;

            string rut = Txt_Rut.Text;
            string password = Txt_Pass.Text;

            empleado = auxServiceEmpleado.Login(rut, password);

            if (empleado != null)
            {
                EmpleadoLogueado.Empleado = empleado;
                VentanaMenuPrincipal vMenuPrincipal = new VentanaMenuPrincipal();
                vMenuPrincipal.Show();
                VentanaLogin.Instancia = this;
                Ocultar();
            }
            else
            {
                MessageBox.Show("Los datos de acceso son erroneos", "Sistema");
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Ocultar()
        {
            this.Visible = false;
        }

        public void Mostrar()
        {
            this.Visible = true;
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
