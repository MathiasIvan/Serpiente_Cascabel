using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Hotel
{
    public class Gastos
    {
        public enum Servicios
        {
            Bebidas,
            Desayuno,
            Almuerzo,
            Cena
        }


            public string ID_Gasto { get; set; }
            public Reserva ID_Reserva_Gasto { get; set; }
            public Servicios Servicio { get; set; }
            public DateTime FechaGasto { get; set; }
            public string Cantidad { get; set; }
            public double CostoTotalGasto { get; set; }


            public override string ToString()
            {
                return ID_Gasto;
            }

            public static List<Gastos> listagastos = new List<Gastos>();


            public static List<Gastos> ObtenerGastos()
            {
                return listagastos;
            }


            public static void AgregarGasto(Gastos g)
            {
                listagastos.Add(g);
            }


            public static void ActualizarGasto(Gastos g, int indice)
            {

                Gastos.listagastos[indice] = g;
            }


            public static void EliminarGasto(Gastos g)
            {
                listagastos.Remove(g);
            }


        }
    }

