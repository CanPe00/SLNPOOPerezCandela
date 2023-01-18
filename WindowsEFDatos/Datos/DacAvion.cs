using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Datos
{
    public static class DacAvion
    {
        public static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<Avion> SelectAll()
        {
            return context.Aviones.ToList();
        }

        public static int Insert(Avion avion)
        {
            context.Aviones.Add(avion);
            return context.SaveChanges();
        }
    }
}
