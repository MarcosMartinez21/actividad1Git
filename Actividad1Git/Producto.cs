using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad1Git
{ 
    public class Producto
    {

        private string _nombre;
        private int _precio;

        public Producto(string nombre, int precio)
        {
            _nombre = nombre;
            _precio = precio;
        }

        public string GetNombre(string nombre) 
        {
            return _nombre;
        }

        public void SetNombre(string nombre) 
        {
            _nombre = nombre;
        }

        public int GetPrecio()
        {
            return _precio;
        }

        public void SetPrecio(int precio)
        { 
            _precio = precio;
        }

        public string MostrarDatos()
        {
            return $"Nombre:{_nombre}\n" +
                $"Precio:{_precio}";
        }

    }
}
