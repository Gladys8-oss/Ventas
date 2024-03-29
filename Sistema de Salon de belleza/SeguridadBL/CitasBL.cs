﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Rentas.EmpleadosBL;

namespace BL.Rentas 
{
   
    public class CitasBL
    {
        Contexto _contexto;
        EmpleadosBL _empleados;

        public BindingList<Citas> ListaCitas { get; set; } 
        public BindingList<Empleados> ListaEpleados { get; set; }

        public CitasBL()
        {
            _contexto = new Contexto();
            ListaCitas = new BindingList<Citas>();

            _empleados = new EmpleadosBL();
            ListaEpleados = new BindingList<Empleados>();

        }
        public BindingList<Citas> ObtenerCitas()
        {
            _contexto.Citas.Load();
            ListaCitas = _contexto.Citas.Local.ToBindingList();
            
            return ListaCitas;
        }

        public BindingList<Citas> ObtenerCitas(string buscar)
        {
            var query = _contexto.Citas
            .Where(p => p.Fecha_Cita.ToLower()
            .Contains(buscar.ToLower()) == true)
            .ToList();

            var resultado = new BindingList<Citas>(query);

            return resultado;
        }
        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarCitas(Citas citas)
        {
            var resultado = Validar(citas);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCitas()
        {
            var nuevaCita = new Citas();
            ListaCitas.Add(nuevaCita);
        }

        public bool EliminarCitas(int Id) 
        {
            foreach (var citas in ListaCitas)
            {
                if (citas.Id == Id)
                {
                    ListaCitas.Remove(citas);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Citas citas)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;


            if (string.IsNullOrEmpty(citas.Fecha_Cita) == true)
            {
                resultado.Mensaje = "Ingrese la fecha de la cita";
                resultado.Exitoso = false;
            }
            return resultado;
        }

        public class Citas
        {
            public int Id { get; set; }
            public string Fecha_Cita { get; set; }
            public string Hora { get; set; }
            public string Cliente { get; set; }
            public string Empleado { get; set; }
            public string Servicio { get; set; }
            public string Estatus { get; set; }
        }
    }

   
}
