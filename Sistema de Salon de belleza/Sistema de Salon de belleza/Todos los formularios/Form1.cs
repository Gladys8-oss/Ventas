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

namespace Sistema_de_Salon_de_belleza
{
    public partial class Form1 : Form
    {
        SeguridadBl _seguridad;
        public Form1()
        {
            InitializeComponent();
            _seguridad = new SeguridadBl();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            TextBox2.UseSystemPasswordChar = false;
            else
                TextBox2.UseSystemPasswordChar = true;
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;


            usuario = TextBox1.Text;
            contrasena = TextBox2.Text;

            Button2.Enabled = false;
            Button2.Text = "Verificando...";
            Application.DoEvents();

            var usuarioDB = _seguridad.Automatizar(usuario,contrasena);

            if (usuarioDB != null)
            {
                Program.UsuarioLogueado = usuarioDB;
                this.Close();
            }else
            {
                MessageBox.Show("--- Usuario y contraseña incorrectos ---");
            }


            Button2.Enabled = true;
            Button2.Text = "Aceptar";
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBox1.Text != "")
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    TextBox2.Focus();
                }
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBox2.Text != "")
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Button2.PerformClick();
                }
            }
        }
    }
}
