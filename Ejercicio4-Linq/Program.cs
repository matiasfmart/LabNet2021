using Ejercicio3_Linq.Logic;
using Ejercicio4_Linq.Data;
using Ejercicio4_Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio3_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersLogic customers = new CustomersLogic();
            ProductsLogic products = new ProductsLogic();

            /*-----------------punto1, devolver objeto costumer--------------------*/
            Console.WriteLine("1- Query para devolver objeto Costumer");
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
            Console.WriteLine();

            foreach (var item in customers.CustomerObjet())
            {
                Console.WriteLine($"ID: {item.CustomerID} - Nombre: {item.ContactName} - Ciudad: {item.City}");
            }
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();


            Console.WriteLine();
            /*-----------------punto2, devolver productos sin stock--------------------*/
            Console.WriteLine("2- Query para devolver todos los productos sin stock");
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
            Console.WriteLine();

            foreach (var item in products.OutOfStock())
            {
                Console.WriteLine($"ID: {item.ProductID} - Producto: {item.ProductName}");
            }
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();


            Console.WriteLine();
            /*-----------------punto3, devolver todos los productos que tienen stock y que cuestan más de 3 por unidad--------------------*/
            Console.WriteLine("3- Query para devolver todos los productos en stock que cuestan mas de 3");
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
            Console.WriteLine();

            foreach (var item in products.InStock())
            {
                Console.WriteLine($"ID: {item.ProductID} - Producto: {item.ProductName}");
            }
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();


            Console.WriteLine();
            /*-----------------punto4, devolver todos los customers de Washington--------------------*/
            Console.WriteLine("4- Query para devolver todos los customers de Washington");
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
            Console.WriteLine();

            foreach (var item in customers.CustFromW())
            {
                Console.WriteLine($"ID: {item.CustomerID} - Nombre: {item.ContactName}");
            }
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();


            Console.WriteLine();
            /*-----------------punto5, devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789--------------------*/
            Console.WriteLine("5- Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789");
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
            Console.WriteLine();

            var firstElement = products.FirstElement();
            try
            {
                Console.WriteLine($"ID: {firstElement.ProductID} - Producto: {firstElement.ProductName}");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Nulo");
            }

            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();


            Console.WriteLine();
            /*-----------------punto6, devolver los nombres de los Customers. Mostrarlos en Mayuscula y en Minuscula--------------------*/
            Console.WriteLine("4- Query para devolver los nombres de los Customers. Mostrarlos en Mayuscula y en Minuscula");
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
            Console.WriteLine();

            foreach (var item in customers.NamesCustomers())
            {
                Console.WriteLine($"ID: {item.CustomerID} - Nombre en MAYUSCULAS: {item.ContactName.ToUpper()} - Nombre en minusculas: {item.ContactName.ToLower()}");
            }
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();

            /*-----------------punto7, devolver Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1/1/1997--------------------*/
            Console.WriteLine("4- Query para devolver Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1/1/1997");
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
            Console.WriteLine();

            customers.CustomersJoinOrders();

            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();

            /*-----------------punto8, devolver los primeros 3 Customers de Washington--------------------*/
            Console.WriteLine("4- Query para devolver los primeros 3 Customers de Washington");
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
            Console.WriteLine();

            foreach (var item in customers.CostumersFirstRegion())
            {
                Console.WriteLine($"ID: {item.CustomerID} - Nombre: {item.ContactName}");
            }
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();

            /*-----------------9.Query para devolver lista de productos ordenados por nombre----------------*/
            Console.WriteLine("9. Query para devolver lista de productos ordenados por nombre");
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
            Console.WriteLine();

            foreach (var item in products.ProductOrderByName())
            {
                Console.WriteLine($"ID: {item.ProductID} - Producto: {item.ProductName}");
            }
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();

            /*-----------------10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.----------------*/
            Console.WriteLine("10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
            Console.WriteLine();

            foreach (var item in products.ProductOrderByDesc())
            {
                Console.WriteLine($"ID: {item.ProductID} - Producto: {item.ProductName}");
            }
            Console.WriteLine("Presiona enter para continuar");
            Console.ReadLine();
        }
    }
}
