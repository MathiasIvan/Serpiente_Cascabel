using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Hotel
{
    public class Reserva
    {
        public int ID_Reserva { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public Habitacion ID_Habitacion { get; set; }
        public Cliente ID_Cliente { get; set; }
        public Registrador ID_Registrador { get; set; }
        public double CostoTotal { get; set; }
        public string Observacion { get; set; }


        public override string ToString()
        {
            return Observacion;
        }


        public static List<Reserva> listareserva = new List<Reserva>();


        public static List<Reserva> ObtenerReservas()
        {
            return listareserva;
        }


        public static void AgregarReserva(Reserva rs)
        {
            listareserva.Add(rs);
        }


        public static void ActualizarReserva(Reserva rs, int indice)
        {

            Reserva.listareserva[indice] = rs;
        }


        public static void EliminarReserva(Reserva rs)
        {
            listareserva.Remove(rs);
        }

    }
}

