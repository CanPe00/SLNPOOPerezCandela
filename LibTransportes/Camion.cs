using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Camion : Vehiculo
    {
        public Camion(string patente, float velocidadMaxima, float cargaMax, Remolque remolque) : base(patente, velocidadMaxima)
        {
            CargaMax = cargaMax;
            Remolque = remolque;
        }

        public float CargaMax { get; set; }
        public Remolque Remolque { get; set; }

        public void QuitarRemolque()
        {
            Remolque = null;
        }

        public override string Acelerar()
        {
            return "Camión Acelera";
        }

        public override string Frenar()
        {
            return "Camión frena";
        }

        public override string ToString()
        {
            if (Remolque != null)
            {
                return base.ToString() +
               $"\nCarga Max: {CargaMax}" +
               $"\nRemolque: {Remolque.ToString()}";
            }
            else
            {
                return base.ToString() +
               $"\nCarga Max: {CargaMax}" + $"\nRemolque: -";
            }      
        }
    }
}
