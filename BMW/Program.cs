using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMW.Clases;

namespace BMW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MostrarMenu();
        }

        static void MostrarMenu()
        {
            while (true)
            {
                Console.WriteLine("====== CRUD DE COMPRADORES BMW ======");
                Console.WriteLine("1. Registrar comprador");
                Console.WriteLine("2. Buscar comprador");
                Console.WriteLine("3. Mostrar todos");
                Console.WriteLine("4. Actualizar comprador");
                Console.WriteLine("5. Eliminar comprador");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": CrearComprador(); break;
                    case "2": LeerComprador(); break;
                    case "3": MostrarTodos(); break;
                    case "4": ActualizarComprador(); break;
                    case "5": EliminarComprador(); break;
                    case "6": return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadLine(); break;
                }
            }
        }

        static void CrearComprador()
        {
            Console.Clear();
            Console.Write("Cédula: ");
            string cedula = Console.ReadLine();
            Console.Write("Nombres: ");
            string nombres = Console.ReadLine();
            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();
            Console.Write("Vehículo comprado: ");
            string vehiculo = Console.ReadLine();

            var comprador = new Comprador(cedula, nombres, apellidos, vehiculo);
            Console.WriteLine("¡Comprador registrado con éxito!");
            Console.ReadLine();
        }

        static void LeerComprador()
        {
            Console.Clear();
            Console.Write("Ingrese la cédula: ");
            string cedula = Console.ReadLine();
            var comprador = BaseDatos.BaseDeDatos.BuscarPorCedula(cedula);
            if (comprador != null)
                comprador.imprimir();
            else
                Console.WriteLine("Comprador no encontrado.");
            Console.ReadLine();
        }

        static void MostrarTodos()
        {
            Console.Clear();
            BaseDatos.BaseDeDatos.ImprimirCompradores();
            Console.ReadLine();
        }

        static void ActualizarComprador()
        {
            Console.Clear();
            Console.Write("Cédula del comprador a actualizar: ");
            string cedula = Console.ReadLine();
            var comprador = BaseDatos.BaseDeDatos.BuscarPorCedula(cedula);
            if (comprador != null)
            {
                comprador.imprimir();
                Console.Write("Nuevos nombres: ");
                comprador.setNombres(Console.ReadLine());
                Console.Write("Nuevos apellidos: ");
                comprador.setApellidos(Console.ReadLine());
                Console.Write("Nuevo vehículo comprado: ");
                comprador.setVehiculo(Console.ReadLine());
                Console.WriteLine("¡Actualización exitosa!");
            }
            else Console.WriteLine("Comprador no encontrado.");
            Console.ReadLine();
        }

        static void EliminarComprador()
        {
            Console.Clear();
            Console.Write("Cédula del comprador a eliminar: ");
            string cedula = Console.ReadLine();
            var comprador = BaseDatos.BaseDeDatos.BuscarPorCedula(cedula);
            if (comprador != null)
            {
                Console.Write($"¿Eliminar a {comprador.getNombreCompleto()}? (S/N): ");
                if (Console.ReadLine().ToUpper() == "S")
                {
                    BaseDatos.BaseDeDatos.BaseDeDatosComprador.Remove(comprador);
                    Console.WriteLine("¡Comprador eliminado!");
                }
                else Console.WriteLine("Cancelado.");
            }
            else Console.WriteLine("Comprador no encontrado.");
            Console.ReadLine();
        }
    }
}
    

