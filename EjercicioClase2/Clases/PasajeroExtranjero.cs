using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2.Clases
{
    public class PasajeroExtranjero : Pasajero
    {
        public string Pasaporte { get; set; }
        public PasajeroExtranjero(string nombre, string apellido, string Pasaporte) : base(nombre, apellido)
        {
            this.Pasaporte = Pasaporte;

        }


    }
}