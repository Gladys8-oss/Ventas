using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BL.Rentas.CitasBL;

namespace Sistema_de_Salon_de_belleza.Todos_los_formularios
{
    public partial class Form9Calendario : Form
    {
        CitasBL _citas;
        public Form9Calendario()
        {
            InitializeComponent();
            _citas = new CitasBL();
            listaCitasBindingSource.DataSource = _citas.ObtenerCitas();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void Form9Calendario_Load(object sender, EventArgs e)
        {


            label1.Text = DateTime.Now.ToLongDateString();
            label9.Visible = false;
            label18.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "09-08-2021" && citas.Estatus == "Anulada")
            {
                label9.Visible = true;
            } else if (citas.Fecha_Cita == "10-08-2021" && citas.Estatus == "Programada")

            {
                label18.Visible = true;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            /*  var citas = (CitasBL.Citas)listaCitasBindingSource.Current;
            var form8Agenda = new Form8Agenda();
            form8Agenda.ShowDialog();
             var resultado = _citas.GuardarCitas(citas);
             if (resultado.Exitoso ==true)
             { 
                 label9.Enabled = true;
             }*/
        }

        private void label9_Click(object sender, EventArgs e)
        {

            var citas = (Citas)listaCitasBindingSource.Current;
           
            if (citas.Fecha_Cita == "09-08-2021" && citas.Estatus == "Anulada" )
             {
                label40.Visible = true;
               MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
               citas.Servicio + " Empleado: "+ citas.Empleado + " Estatus: " + citas.Estatus);
             }
               else
                {
                  MessageBox.Show("aun no hay citas registradas");
                 }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "10-08-2021" && citas.Estatus == "Programada")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "03-08-2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "04-08-2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "05-08-2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "06-08-2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "07/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "08/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "02/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "10-08-2021" && citas.Estatus == "Programada")
            {
                label41.Visible = true;
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "11/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "12/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "13/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "14/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "16/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "16/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "17/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "18/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "19/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "20/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "21/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "22/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "23/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "24/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "25/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label34_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "26/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label35_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "27/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "28/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label37_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "29/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label38_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "30/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void label39_Click(object sender, EventArgs e)
        {
            var citas = (Citas)listaCitasBindingSource.Current;
            if (citas.Fecha_Cita == "32/08/2021")
            {
                MessageBox.Show("Cliente: " + citas.Cliente + " Hora: " + citas.Hora + " Servicio: " +
                citas.Servicio + " Empleado: " + citas.Empleado + " Estatus: " + citas.Estatus);
            }
            else
            {
                MessageBox.Show("aun no hay citas registradas");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var buscar = "09/08/2021";

            if (string.IsNullOrEmpty(buscar) == true)
            {
                listaCitasBindingSource.DataSource = _citas.ObtenerCitas();
            }
            else
            {
                listaCitasBindingSource.DataSource = _citas.ObtenerCitas(buscar);
            }

            listaCitasBindingSource.ResetBindings(false);
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }
    }
    
}
