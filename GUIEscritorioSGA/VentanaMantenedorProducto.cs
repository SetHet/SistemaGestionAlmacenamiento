﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUIEscritorioSGA.ServiceProducto;
using GUIEscritorioSGA.ServiceTipoProducto;

namespace GUIEscritorioSGA
{
    public partial class VentanaMantenedorProducto : Form
    {
        public VentanaMantenedorProducto()
        {
            InitializeComponent();
            AuxServiceProducto = new ServiceProducto.WebServiceProductoSoapClient();
            AuxServiceTipoProducto = new ServiceTipoProducto.WebServiceTipoProductoSoapClient();
            CargarTiposProductos();
            TerminarGuardado();
        }
        private bool enGuardado;
        private int posicionLista;
        private ServiceProducto.WebServiceProductoSoapClient auxServiceProducto;
        private ServiceProducto.MDProducto auxProducto;
        private List<ServiceProducto.MDProducto> auxListaProducto;
        private ServiceTipoProducto.WebServiceTipoProductoSoapClient auxServiceTipoProducto;
        private List<ServiceTipoProducto.MDTipoProducto> listaTipoProducto;
        private List<string> listaTipoProductoString;

        public bool EnGuardado { get => enGuardado; set => enGuardado = value; }
        public int PosicionLista { get => posicionLista; set => posicionLista = value; }
        public WebServiceProductoSoapClient AuxServiceProducto { get => auxServiceProducto; set => auxServiceProducto = value; }
        public MDProducto AuxProducto { get => auxProducto; set => auxProducto = value; }
        public List<MDProducto> AuxListaProducto { get => auxListaProducto; set => auxListaProducto = value; }
        public WebServiceTipoProductoSoapClient AuxServiceTipoProducto { get => auxServiceTipoProducto; set => auxServiceTipoProducto = value; }
        public List<MDTipoProducto> ListaTipoProducto { get => listaTipoProducto; set => listaTipoProducto = value; }
        public List<string> ListaTipoProductoString { get => listaTipoProductoString; set => listaTipoProductoString = value; }

        private void CargarTiposProductos()
        {
            ListaTipoProducto = AuxServiceTipoProducto.BuscarAll().ToList();
            ListaTipoProductoString = new List<string>();

            foreach (var tipoProducto in ListaTipoProducto)
            {
                ListaTipoProductoString.Add(tipoProducto.NombreTipo);
            }

            if (ListaTipoProducto.Count <= 0)
            {
                MessageBox.Show("No se puede agregar productos sin tener algun tipo producto ingresado en el sistema.", "Sistema");
                return;
            }
            else
            {
                Cm_IDTipo.DataSource = ListaTipoProductoString;
            }
        }

        private void ComenzarGuardado()
        {
            EnGuardado = true;
            Txt_NombreProducto.Clear();
            Txt_Descripcion .Clear();
            Cm_IDTipo.SelectedIndex = 0;
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

        private int SearchIndexTipoProducto(int id_tipo)
        {
            int index = 0;
            foreach (var tipoProducto in ListaTipoProducto)
            {
                if (tipoProducto.IdTipoProducto == id_tipo)
                {
                    return index;
                }
                
                else
                {
                    
                    
                }
                index++;
            }
            return -1;
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
                Cm_IDTipo.SelectedIndex = SearchIndexTipoProducto(AuxListaProducto[PosicionLista].IdTipoProducto);
                Txt_NombreProducto.Text = AuxListaProducto[PosicionLista].Nombre;
                Txt_Descripcion.Text = AuxListaProducto[PosicionLista].Descripcion;
            }
            else
            {
                Txt_Actual.Text = "0 / 0";
                Txt_IDProducto.Clear();
                
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
            if (ListaTipoProducto.Count <= 0)
            {
                MessageBox.Show("No se puede agregar productos sin tener algun tipo producto ingresado en el sistema.", "Sistema");
                return;
            }

            if (EnGuardado)
            {
                if (Txt_NombreProducto.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar un nombre de Producto Correcto", "Sistema");
                    return;
                }
                if (Txt_Descripcion.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ingresar una descripcion de Producto Correcto", "Sistema");
                    return;
                }

                bool resultadoGuardado = auxServiceProducto.InsertWithValues(ListaTipoProducto[Cm_IDTipo.SelectedIndex].IdTipoProducto, Txt_NombreProducto.Text, Txt_Descripcion.Text);
                if (resultadoGuardado)
                {
                    
                    TerminarGuardado();
                    MessageBox.Show("Nuevo producto guardado." ,"Sistema");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el nuevo producto.", "Sistema");
                }

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
                    MessageBox.Show("No se puede eliminar el producto.", "Sistema");
                }
                else
                {
                    ActualizarLista();
                    MessageBox.Show("Producto eliminado.", "Sistema");
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
                MessageBox.Show("Para actualizar se necesita ingresar un nombre de producto valido.", "Sistema");
                return;
            }

            if (Txt_Descripcion .Text.Equals(string.Empty))
            {
                MessageBox.Show("Para actualizar se necesita ingresar una descripcion valida.", "Sistema");
                return;
            }
            if (auxListaProducto.Count > 0)
            {
                bool resultado = auxServiceProducto.UpdateWithValues( int.Parse(Txt_IDProducto.Text), ListaTipoProducto[Cm_IDTipo.SelectedIndex].IdTipoProducto, Txt_NombreProducto.Text, Txt_Descripcion.Text);
                if (resultado == false)
                {
                    MessageBox.Show("No se puede actualizar el producto.", "Sistema");
                }
                else
                {
                    ActualizarLista();
                    MessageBox.Show("Producto actualizado.", "Sistema");
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
            if (enGuardado)
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
            PosicionLista = auxListaProducto.Count - 1;
            ActualizarPantalla();
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
