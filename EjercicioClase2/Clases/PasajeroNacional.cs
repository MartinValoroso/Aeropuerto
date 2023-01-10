using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2.Clases
{
    public class PasajeroNacional : Pasajero
    {
        public string Dni { get; set; }
        public PasajeroNacional (string nombre, string apellido, string dni) : base(nombre, apellido)
        {
            Dni = dni;

        }


    }
}
