using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas 
{
   public  class ProductosBL
    {
        Contexto _contexto;
       // Contexto _contexto;
        public BindingList<Producto> ListaProductos { get; set;  }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProductos = new BindingList<Producto>();
        }
        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();


            return ListaProductos;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if (producto.Id == 0 )
            {
                producto.Id = ListaProductos.Max(item => item.Id) + 1;
            }

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgrearProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int Id)
        {
            foreach (var productos in ListaProductos)
            {
                if (productos.Id  == Id)
                {
                    ListaProductos.Remove(productos);
                    return true;
                } 
            }
            return false;
        }
        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            if (producto.Existencia <0)
            {
                resultado.Mensaje = "La existencia debe de ser mayor a cero";
                resultado.Exitoso = false;

            }

            if (producto.Precio < 0)
            {
                resultado.Mensaje = "La precio debe de ser mayor a cero";
                resultado.Exitoso = false;

            }
            return resultado;
        }
    }
public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

