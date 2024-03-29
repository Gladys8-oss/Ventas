﻿using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Salon_de_belleza.Todos_los_formularios
{
    public partial class FormProductos : Form
    {

        ProductosBL _productos;

        public FormProductos() 
        {
            InitializeComponent();

            _productos = new ProductosBL();
            ListaProductosBindingSource.DataSource = _productos.ObtenerProductos();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void productoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void seguridadBlBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void seguridadBlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            ListaProductosBindingSource.EndEdit();
            var producto = (Producto)ListaProductosBindingSource.Current;

            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                ListaProductosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            ListaProductosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);

        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }
    

        
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            {
                if (idTextBox.Text != "")

                {
                    var resultado = MessageBox.Show("Desea eliminar este Registro?", "Eliminar", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(idTextBox.Text);
                        Eliminar(id);
                    }
                        
                }
            }
            
        }

        private void Eliminar(int id)
        {
            
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                ListaProductosBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
