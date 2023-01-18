using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public abstract class Vehiculo
    {
        protected Vehiculo(string patente, float velocidadMaxima)
        {
            Patente = patente;
            VelocidadMaxima = velocidadMaxima;
        }

        public string Patente { get; set; }
        public float VelocidadMaxima { get; set; }

        public abstract string Acelerar();
        public abstract string Frenar();

        public override string ToString()
        {
            return $"Patente: {Patente}" +
                $"\nVelocidad Máxima: {VelocidadMaxima}";
        }
    }
}
