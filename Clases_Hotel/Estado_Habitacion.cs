using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Hotel
{
    public class Estado_Habitacion
    {
        public string ID_EstadoHabitacion { get; set; }
        public string Descripcion { get; set; }


        public override string ToString()
        {
            return Descripcion;
        }


        public static List<Estado_Habitacion> listaEstadoHabitacion = new List<Estado_Habitacion>();


        public static List<Estado_Habitacion> ObtenerEstadoHabitacion()
        {
            return listaEstadoHabitacion;
        }


        public static void AgregarEstadoHabitacion(Estado_Habitacion et)
        {
            listaEstadoHabitacion.Add(et);
        }


        public static void AcualizarEstadoHabitacion(Estado_Habitacion et, int indice)
        {

            Estado_Habitacion.listaEstadoHabitacion[indice] = et;
        }


        public static void EliminarEstadoHabitacion(Estado_Habitacion et)
        {
            listaEstadoHabitacion.Remove(et);
        }

    }
}

