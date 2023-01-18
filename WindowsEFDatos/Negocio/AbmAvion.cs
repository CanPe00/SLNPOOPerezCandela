using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Datos;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.DAC
{
    public static class AbmAvion
    {

        public static List<Avion> Listar()
        {
            return DacAvion.SelectAll();
        }

        public static int Insertar(Avion avion)
        {
            return DacAvion.Insert(avion);
        }
    }
}
