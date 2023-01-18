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

        public static int Editar(Avion avion)
        {
            return DacAvion.Update(avion);
        }

        public static int Eliminar(int id)
        {
            return DacAvion.Delete(id);
        }

        public static Avion TraerUno(int id)
        {
            return DacAvion.SelectById(id);
        }
    }
}
