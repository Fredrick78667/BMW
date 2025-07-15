using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMW.BaseDatos;

namespace BMW.Clases
{
    public class Comprador
    {

        private int id;
        public string cedula;
        private string nombres;
        private string apellidos;
        private string vehiculoComprado;
        private string nombres_completos;

        public Comprador(string cedula, string nombres, string apellidos, string vehiculoComprado)
        {
            int secuencial = BaseDeDatos.BaseDeDatosComprador.Count() + 1;
            this.id = secuencial;
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.vehiculoComprado = vehiculoComprado;
            this.nombres_completos = nombres + " " + apellidos;
            BaseDeDatos.BaseDeDatosComprador.Add(this);
        }

        public Comprador(int id, string cedula, string nombres, string apellidos, string vehiculoComprado, string nombres_completos)
        {
            this.id = id;
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.vehiculoComprado = vehiculoComprado;
            this.nombres_completos = nombres_completos;
        }

        public void setNombres(string nombres)
        {
            this.nombres = nombres;
            this.nombres_completos = nombres + " " + this.apellidos;
        }

        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
            this.nombres_completos = this.nombres + " " + apellidos;
        }

        public void setVehiculo(string vehiculo)
        {
            this.vehiculoComprado = vehiculo;
        }

        public string getNombreCompleto()
        {
            return this.nombres_completos;
        }

        public int getID()
        {
            return this.id;
        }

        public void imprimir()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Cédula: " + cedula);
            Console.WriteLine("Nombre completo: " + nombres_completos);
            Console.WriteLine("Vehículo Comprado: " + vehiculoComprado);
            Console.WriteLine("=====================================");
        }
    }
}

