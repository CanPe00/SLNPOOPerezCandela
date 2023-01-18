using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Datos
{
    public static class DacLineaAerea
    {
        public static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<LineaAerea> SelectAll()
        {
            return context.LineaAereas.ToList();
        }

        public static int Insert(LineaAerea lineaAerea)
        {
            context.LineaAereas.Add(lineaAerea);
            return context.SaveChanges();
        }
    }
}
