using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ClientesBL
    {
        ContextoClientes _contextoclientes;
       // Contexto _contexto;
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contextoclientes = new ContextoClientes();
            ListaClientes = new BindingList<Cliente>();


        }
        public BindingList<Cliente> ObtenerClientes()
        {
            _contextoclientes.Cliente.Load();
            ListaClientes = _contextoclientes.Cliente.Local.ToBindingList();


            return ListaClientes;
        }

        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if (cliente.IdCliente == 0)
            {
                cliente.IdCliente = ListaClientes.Max(item => item.IdCliente) + 1;
            }
            return resultado;
        }

        public void AgregarClientes()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }

        public bool EliminarClientes(int IdCliente)
        {
            foreach (var clientes in ListaClientes)
            {
                if (clientes.IdCliente == IdCliente)
                {
                    ListaClientes.Remove(clientes);
                    return true;
                }
            }
            return false;
        }
        public static implicit operator ClientesBL(ProductosBL v)
        {
            throw new NotImplementedException();
        }

        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            

            if (string.IsNullOrEmpty(cliente.Apellido ) == true )
            {
                resultado.Mensaje = "ingrese un apellido";
                resultado.Exitoso = false;

            }

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool activo { get; set; }
    }

   
    
}
