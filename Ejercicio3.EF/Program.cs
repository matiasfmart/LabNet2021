using Ejercicio6.MVC.Entities;
using Ejercicio6.MVC.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.MVC.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Defino las variables y clases*/
            int menuSelect;
            int idToDelete;
            int idToUpDate;
            ProductsLogic productLogic = new ProductsLogic();
            TerritoriesLogic territoryLogic = new TerritoriesLogic();
            EmployeesLogic employeeLogic = new EmployeesLogic();

            Console.WriteLine("Selecciona un elemento para realizar una consulta" + //Consulto al usuario que desea consultar
                "\n1.Products" +
                "\n2.Territories" +
                "\n3.Employees");
            menuSelect = int.Parse(Console.ReadLine());

            switch (menuSelect)
            {
                case 1:
                    foreach (Products product in productLogic.GetAll())
                    {
                        Console.WriteLine($"ID: {product.ProductID} - {product.ProductName} - Precio: {product.UnitPrice} - En Stock: {product.UnitsInStock}");
                    }
                    break;
                case 2:
                    foreach (Territories territory in territoryLogic.GetAll())
                    {
                        Console.WriteLine($"ID: {territory.TerritoryID} - Descripcion: {territory.TerritoryDescription}");
                    }
                    break;
                case 3:
                    foreach (Employees employee in employeeLogic.GetAll())
                    {
                        Console.WriteLine($"ID: {employee.EmployeeID} - {employee.FirstName} {employee.LastName} - Contacto: {employee.HomePhone}");
                    }
                    break;
            }

            Console.WriteLine("\nSelecciona un elemento para realizar un Insert" + //Consulto al usuario que desea insertar
                "\n1.Productos" +
                "\n2.Territorios" +
                "\n3.Empleados");
            menuSelect = int.Parse(Console.ReadLine());

            switch (menuSelect)
            {
                case 1:
                    Console.WriteLine("Ingrese el ID del nuevo producto");
                    int idNewProduct = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del nuevo producto");
                    string nameNewProduct = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio");
                    decimal precioNewProduct = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese las unidades en stock");
                    short stockNewProduct = short.Parse(Console.ReadLine());

                    productLogic.Add(new Products
                    {
                        ProductID = idNewProduct,
                        ProductName = nameNewProduct,
                        UnitPrice = precioNewProduct,
                        UnitsInStock = stockNewProduct
                    });
                    Console.WriteLine("Se agrego el producto correctamente");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el ID del nuevo territorio");
                    string idNewTerritory = Console.ReadLine();
                    Console.WriteLine("Ingrese la descripcion del nuevo territorio");
                    string descriptionNewTerritory = Console.ReadLine();
                    Console.WriteLine("Ingrese el ID de la region del territorio");
                    int idRegionNewTerritory = int.Parse(Console.ReadLine());

                    territoryLogic.Add(new Territories
                    {
                        TerritoryID = idNewTerritory,
                        TerritoryDescription = descriptionNewTerritory,
                        RegionID = idRegionNewTerritory
                    });
                    Console.WriteLine("Se agrego el territorio correctamente");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el ID del nuevo empleado");
                    int idNewEmployee = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del nuevo empleado");
                    string firstNameNewEmp = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido del nuevo empleado");
                    string lastNameNewEmp = Console.ReadLine();

                    employeeLogic.Add(new Employees
                    {
                        EmployeeID = idNewEmployee,
                        FirstName = firstNameNewEmp,
                        LastName = lastNameNewEmp
                    });
                    Console.WriteLine("Se agrego el empleado correctamente");
                    break;
            }

            Console.WriteLine("\nSelecciona un elemento para realizar un UpDate" + //Consulto al usuario que desea modificar
                "\n1.Productos" +
                "\n2.Territorios" +
                "\n3.Empleados");
            menuSelect = int.Parse(Console.ReadLine());

            switch (menuSelect)
            {
                case 1:
                    Console.WriteLine("Ingrese el ID del producto a modificar");
                    idToUpDate = int.Parse(Console.ReadLine());

                    productLogic.Update(idToUpDate);
                    Console.WriteLine("Se modifico el producto correctamente");

                    break;
                case 2:
                    Console.WriteLine("Ingrese el ID del territorio a modificar");
                    idToUpDate = int.Parse(Console.ReadLine());

                    territoryLogic.Update(idToUpDate);
                    Console.WriteLine("Se modifico el territorio correctamente");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el ID del empleado a modificar");
                    idToUpDate = int.Parse(Console.ReadLine());

                    employeeLogic.Update(idToUpDate);
                    Console.WriteLine("Se modifico el empleado correctamente");
                    break;
            }

            Console.WriteLine("\nSelecciona un elemento para realizar un Delete" + //Consulto al usuario que desea eliminar
                "\n1.Productos" +
                "\n2.Territorios" +
                "\n3.Empleados");
            menuSelect = int.Parse(Console.ReadLine());

            switch (menuSelect)
            {
                case 1:
                    Console.WriteLine("Ingrese el ID del producto a eliminar");
                    idToDelete = int.Parse(Console.ReadLine());

                    productLogic.Delete(idToDelete);
                    Console.WriteLine("Se elimino el producto correctamente");

                    break;
                case 2:
                    Console.WriteLine("Ingrese el ID del territorio a eliminar");
                    idToDelete = int.Parse(Console.ReadLine());

                    territoryLogic.Delete(idToDelete);
                    Console.WriteLine("Se elimino el territorio correctamente");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el ID del emploeado a eliminar");
                    idToDelete = int.Parse(Console.ReadLine());

                    employeeLogic.Delete(idToDelete);
                    Console.WriteLine("Se elimino el empleado correctamente");
                    break;
            }
        }
    }
}
