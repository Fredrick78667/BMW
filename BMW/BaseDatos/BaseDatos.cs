using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMW.Clases;

namespace BMW.BaseDatos
{
    public static class BaseDeDatos
    {

        public static List<Comprador> BaseDeDatosComprador = new List<Comprador>();

        public static Comprador BuscarPorCedula(string cedula)
        {
            return BaseDeDatosComprador.FirstOrDefault(c => c.cedula == cedula);
        }

        public static void ImprimirCompradores()
        {
            foreach (var comprador in BaseDeDatosComprador)
            {
                comprador.imprimir();
            }
        }
    }
}
