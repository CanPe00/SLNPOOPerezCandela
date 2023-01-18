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

        //Editar(Avion)

        public static int Update(Avion avion)
        {
            Avion avionOriginal = context.Aviones.Find(avion.IdAvion);
            avionOriginal.Denominación = avion.Denominación;
            avionOriginal.LineaAereaId= avion.LineaAereaId;
            avionOriginal.Capacidad= avion.Capacidad;
            return context.SaveChanges();

        }

        public static int Delete(int Id)
        {
            Avion avionOriginal = context.Aviones.Find(Id);
            if (avionOriginal != null)
            {
                context.Aviones.Remove(avionOriginal);
                return context.SaveChanges() ;
            }
            return 0;
        }

        public static Avion SelectById(int id) {
            return context.Aviones.Find(id);
        }
        
    }
}
