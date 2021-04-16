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
            Random aleatorio = new Random();
            int pasajerosAuto;
            int pasajerosAvion;

            List<Transporte> transportes = new List<Transporte>();

            for (int i = 0; i < 5; i++)
            {
                pasajerosAuto = aleatorio.Next(1, 6);
                pasajerosAvion = aleatorio.Next(1, 200);

                Avion avion = new Avion();
                Automovil auto = new Automovil();

                avion.Pasajeros = pasajerosAvion;
                auto.Pasajeros = pasajerosAuto;

                transportes.Add(auto);
                transportes.Add(avion);
            }

            int nro = 1;
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
