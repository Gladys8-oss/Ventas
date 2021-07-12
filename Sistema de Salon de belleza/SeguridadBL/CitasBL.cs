using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas 
{
   
    public class CitasBL
    {
        Contexto _contexto;
        public BindingList<Citas> ListaCitas { get; set; } 

        public CitasBL()
        {
            _contexto = new Contexto();
            ListaCitas = new BindingList<Citas>();
            
        }
        public BindingList<Citas> ObtenerCitas()
        {
          //  _contexto.Citas.Load();
          //  ListaCitas = _contexto.Citas.Local.ToBindingList();
            
            return ListaCitas;
        }

        public Resultado GuardarCitas(Citas citas)
        {
            var resultado = Validar(citas);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if (citas.IdCita == 0)
            {
                citas.IdCita = ListaCitas.Max(item => item.IdCita) + 1;
            }
            return resultado;
        }

        public void AgregarCitas()
        {
            var nuevaCita = new Citas();
            ListaCitas.Add(nuevaCita);
        }

        public bool EliminarCitas(int IdCita)
        {
            foreach (var citas in ListaCitas)
            {
                if (citas.IdCita == IdCita)
                {
                    ListaCitas.Remove(citas);
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Citas citas)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            

            if (string.IsNullOrEmpty(citas.Cliente) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del cliente";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(citas.Empleado) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del empleado";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(citas.Servicio) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del servicio que desea el cliente";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(citas.Fecha_Cita) == true)
            {
                resultado.Mensaje = "Ingrese la fecha de la cita";
                resultado.Exitoso = false;
            }
            return resultado;
        }

        public class Citas
        {
            public int IdCita { get; set; }
            public string Fecha_Cita { get; set; }
            public string Hora { get; set; }
            public string Cliente { get; set; }
            public string Empleado { get; set; }
            public string Servicio { get; set; }
            public string Estatus { get; set; }
        }
    }

   
}
