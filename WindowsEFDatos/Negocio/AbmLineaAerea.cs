using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Datos;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Negocio
{
    public static class AbmLineaAerea
    {
        public static List<LineaAerea> Listar()
        {
            return DacLineaAerea.SelectAll();
        }

        public static int Insertar(LineaAerea lineaAerea)
        {
            return DacLineaAerea.Insert(lineaAerea);
        }
    }
}
