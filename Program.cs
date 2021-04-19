using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio2_exceptions.Model;

namespace ejercicio2_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //punto 1
            Console.WriteLine("Comenzemos con el primer punto\n");
            Console.WriteLine("Ingrese un numero para dividir por cero (si, te pido un numero para decirte que no se puede dividir por cero xd)");

            divisionxcero(int.Parse(Console.ReadLine())); //envio el dato al metodo

            //punto 2
            Console.WriteLine("\nAhora toca el segundo!\n");
            divisiones();

            //punto 3
            Console.WriteLine("Presiona cualquier tecla y vamos con el tercer punto!");
            Console.ReadLine();
            
            try
            {
                Logic.exceptionLogic(); //utilice el modificador static para no instanciar la clase, ver en clase Logic.
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Hola! vine a excepcionar xD\nExcepción usó: {e.GetType()}! \nCause el daño: {e.Message}\n");
            }
            finally
            {
                /*Utilizo finally para avisar que se termino la operacion como esta especificado en la consigna*/
                Console.WriteLine("Terminamos la tercer consigna, pongame 10 :D");    
                Console.ReadLine();
                Console.WriteLine("Na, mentira... falta el ultimo punto");
            }

            Console.WriteLine("Ingresa un mensaje personalizado para colocar en la 'caja de texto' de la exception personalizada");

            try
            {
                throw new CustomException($"{Console.ReadLine()}"); //instancio exception personalizada
            }
            catch (Exception e)
            {
                Console.WriteLine("esta es la caja de texto :v\n");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("|                                                                                               |");
                Console.WriteLine($"|         {e.Message}                                                      |");
                Console.WriteLine("|                                                                                               |");
                Console.WriteLine("-------------------------------------------------------------------------------------------------\n");
            }
            finally
            {
                Console.WriteLine("\nTerminamos todo el ejercicio 2, ahora si, pongame 10 :D");
            }

            Console.ReadLine();

            void divisiones()
            {
                try
                {
                    Console.WriteLine("Ingrese el numero a dividir");
                    int nroUno = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el numero divisor");
                    int nroDos = int.Parse(Console.ReadLine());

                    float resultado = nroUno / nroDos;

                    Console.WriteLine($"{nroUno}/{nroDos}={resultado}");    //muestro el resultado en caso de que sea valido
                }
                catch (DivideByZeroException e) //excepcion de division por cero
                {
                    Console.WriteLine($"\nSolo Chuck Norris divide por cero!\n{e.Message}");    
                }   
                catch (FormatException e)   //excepcion de error de formato (tipo de dato erroneo)
                {
                    Console.WriteLine($"\nSeguro Ingreso una letra o no ingreso nada!\n{e.Message}");   
                }
                finally
                {
                    Console.WriteLine("\nProceso terminado\n");
                }
            }

             void divisionxcero(int valor)
             {
                try
                {
                    int divisionCero = valor / 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Quien te dijo que se puede dividir por cero? xD error: {e.Message}");
                }
                finally
                {
                    Console.WriteLine("Proceso terminado");
                }
             }
        }
    }
}
