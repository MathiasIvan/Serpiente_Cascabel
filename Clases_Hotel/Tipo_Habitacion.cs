using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Hotel
{
    public class Tipo_Habitacion
    {
        public string ID_TipoHabitacion { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }


        public static List<Tipo_Habitacion> listaTipoHabitaciones = new List<Tipo_Habitacion>();


        public static List<Tipo_Habitacion> ObtenerTipoHabitaciones()
        {
            return listaTipoHabitaciones;
        }


        public static void AgregarTipoHabitacion(Tipo_Habitacion th)
        {
            listaTipoHabitaciones.Add(th);
        }


        public static void ActualizarTipoHabitacion(Tipo_Habitacion th, int indice)
        {

            Tipo_Habitacion.listaTipoHabitaciones[indice] = th;
        }


        public static void EliminarTipoHabitacion(Tipo_Habitacion th)
        {
            listaTipoHabitaciones.Remove(th);
        }


    }
}
