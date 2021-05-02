using Ejercicio3.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.EF.Logic
{
    public class ProductsLogic : BaseLogic, ABMInterface<Products>
    {
        public void Add(Products toAdd) //Se agrega nuevo elemento
        {
            context.Products.Add(toAdd);
            context.SaveChanges();
        }

        public void Delete(int toDelete) //Se elimina el elemento indicado por ID
        {
            var territoryDelete = context.Products.Find(toDelete);
            context.Products.Remove(territoryDelete);
            context.SaveChanges();
        }

        public List<Products> GetAll() //Se traen todos los datos
        {
            return context.Products.ToList();
        }

        public void Update(int toUpDate) //Se modifican los datos
        {
            int caseSwitch;
            var productUpDate = context.Products.Find(toUpDate);


            do
            {
                Console.WriteLine("¿Que desea modificar? Seleccione" +
                    "\n1. Nombre del producto" +
                    "\n2. Precio" +
                    "\n3. Stock" +
                    "\n4. Discontinuidad" +
                    "\n\n0. Para salir");

                caseSwitch = int.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.Write("Ingrese nuevo nombre: ");
                        productUpDate.ProductName = Console.ReadLine();

                        break;

                    case 2:
                        Console.Write("Ingrese el nuevo precio: $");
                        productUpDate.UnitPrice = decimal.Parse(Console.ReadLine());

                        break;

                    case 3:
                        Console.Write("Ingrese nuevo stock: ");
                        productUpDate.UnitsInStock = short.Parse(Console.ReadLine());
                        break;
                    case 4:
                        if (productUpDate.Discontinued == true)
                        {
                            productUpDate.Discontinued = false;
                            Console.WriteLine("El producto paso a estar en estado de continuidad");
                        }
                        else
                        {
                            productUpDate.Discontinued = true;
                            Console.WriteLine("El producto paso a estar en estado de discontinuidad");
                        }
                        break;
                }
            } while (caseSwitch != 0);

            context.SaveChanges();
        }
    }
}
