using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Hotel
{
    public class Habitacion
    {
        public int ID_Habitacion { get; set; }
        public string Numero { get; set; }
        public Estado_Habitacion ID_EstadoHabitacion { get; set; }
        public Tipo_Habitacion ID_TipoHabitacion { get; set; }
        public double Costo { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }


        public static List<Habitacion> listaHabitaciones = new List<Habitacion>();


        public static List<Habitacion> ObtenerHabitaciones()
        {
            return listaHabitaciones;
        }


        public static void AgregarHabitacion(Habitacion h)
        {
            listaHabitaciones.Add(h);
        }


        public static void ActualizarHabitacion(Habitacion h, int indice)
        {
            Habitacion.listaHabitaciones[indice] = h;
        }


        public static void EliminarHabitacion(Habitacion h)
        {
            listaHabitaciones.Remove(h);
        }

    }
}

