using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2.Clases
{
    public class Pasaje
    {

        public Pasaje(string destino, float precio)
        {
            Destino = destino; 
            Precio = precio;

        }
        
        public string Destino { get; set; }
        public float Precio { get; set; }


    }

}
       

