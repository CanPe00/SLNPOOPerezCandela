using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Remolque
    {
        public int CantRuedas { get; set; }
        public float Peso { get; set; }

        public Remolque(int cantRuedas, float peso)
        {
            CantRuedas = cantRuedas;
            Peso = peso;
        }

        public override string ToString()
        {
            return $" Cantidad de ruedas: {CantRuedas}" +
                $" - Peso: {Peso}";
        }
    }
}
