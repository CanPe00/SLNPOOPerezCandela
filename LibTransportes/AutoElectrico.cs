using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class AutoElectrico : Vehiculo
    {
        public AutoElectrico(string patente, float velocidadMaxima, int consumo) : base(patente, velocidadMaxima)
        {
            Consumo = consumo;
        }

        public int Consumo { get; set; }
        
        public override string Acelerar()
        {
            return "Auto eléctrico acelera";
        }

        public override string Frenar()
        {
            return "Auto eléctrico frena";
        }

        public override string ToString()
        {
            return base.ToString() + $"\nConsumo: {Consumo}";
        }
    }
}
