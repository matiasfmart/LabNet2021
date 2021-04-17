using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio1_poo.Model;

namespace ejercicio1_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random(); //instancio clase random para enviar a los objetos transportes
            int pasajerosAuto; 
            int pasajerosAvion;

            List<Transporte> transportes = new List<Transporte>();  //declaro lista de objetos del tipo transporte

            /* Mediante un for instancio los objetos avion y automoviles y asigno a las variables de los pasajeros un num aleatorio */
            for (int i = 0; i < 5; i++)
            {
                pasajerosAuto = aleatorio.Next(1, 6);   //asigno un numero aleatorio entre 1-6 ya que es la cantidad de pasajeros que entran en un auto estandar
                pasajerosAvion = aleatorio.Next(1, 200);    //asigno entre 1-200 ya que es de manera estandar los pasajeros en un avion

                Avion avion = new Avion();
                Automovil auto = new Automovil();

                avion.Pasajeros = pasajerosAvion;
                auto.Pasajeros = pasajerosAuto;
                /* agrego los objetos a la lista */
                transportes.Add(auto);
                transportes.Add(avion);
            }

            int nro = 1; //variable para mostrar el nro del transporte a mostrar
            
            /* mediante for muestro los datos primero de los aviones y luego de los autos como esta especificado en la consigna */
            for (int i = 0; i < transportes.Count; i++)
            {
                if (transportes[i] is Avion)
                {
                    Console.WriteLine($"Avion{nro}: {transportes[i].Pasajeros} pasajeros.");
                    nro++;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("-------------------");

            nro = 1;
            for (int i = 0; i < transportes.Count; i++)
            {
                if (transportes[i] is Automovil)
                {
                    Console.WriteLine($"Auto{nro}: {transportes[i].Pasajeros} pasajeros.");
                    nro++;
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
