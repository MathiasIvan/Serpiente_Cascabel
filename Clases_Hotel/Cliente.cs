using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Hotel
{
    public enum Nacionalidades
    {
        Australia,
        España,
        Inglaterra,
        Costa_Rica,
        Portugal
    }


    public class Cliente: Persona
    {     
            public string ID_Cliente;
            public Nacionalidades Nacionalidad;
            

            public override string ToString()
            {
                return Nombre;
            }


            public static List<Cliente> listaClientes = new List<Cliente>();


            public static List<Cliente> ObtenerClientes()
            {
                return listaClientes;
            }


            public static void AgregarCliente(Cliente c)
            {
                listaClientes.Add(c);
            }


            public static void ActualizarCliente(Cliente c, int indice)
            {
                Cliente.listaClientes[indice] = c;
            }


            public static void EliminarCliente(Cliente c)
            {
                listaClientes.Remove(c);
            }

        }
    }

