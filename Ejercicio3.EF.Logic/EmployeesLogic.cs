using Ejercicio3.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.EF.Logic
{
    public class EmployeesLogic : BaseLogic, ABMInterface<Employees>
    {
        public void Add(Employees toAdd) //Se agrega un nuevo elemento
        {
            context.Employees.Add(toAdd);
            context.SaveChanges();
        }

        public void Delete(int toDelete) //Mediante ID se elimina el elemento seleccionado
        {
            var empToDelete = context.Employees.Find(toDelete);
            context.Employees.Remove(empToDelete);
            context.SaveChanges();
        }

        public List<Employees> GetAll() //Se traen todos los datos
        {
            return context.Employees.ToList();
        }

        public void Update(int toUpDate) //Se modifican los datos
        {
            int caseSwitch;
            var empUpdate = context.Employees.Find(toUpDate);


            do
            {
                Console.WriteLine("¿Que desea modificar? Seleccione" + //Consulto que campo desea modificar ya que son muchos campos los que son relevantes en esta tabla
                    "\n1. Nombre y Apellido" +
                    "\n2. Domicilio" +
                    "\n3. Telefono" +
                    "\n\n0. Para salir");

                caseSwitch = int.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.Write("Ingrese nuevo nombre: ");
                        empUpdate.FirstName = Console.ReadLine();

                        Console.Write("Ingrese nuevo apellido: ");
                        empUpdate.LastName = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Ingrese los datos del nuevo domicilio");
                        Console.Write("Calle y numero: ");
                        empUpdate.Address = Console.ReadLine();

                        Console.Write("Ciudad: ");
                        empUpdate.City = Console.ReadLine();

                        Console.Write("Codigo postal: ");
                        empUpdate.PostalCode = Console.ReadLine();

                        Console.Write("Provincia: ");
                        empUpdate.Region = Console.ReadLine();

                        Console.Write("Pais: ");
                        empUpdate.Country = Console.ReadLine();

                        break;

                    case 3:
                        Console.Write("Ingrese nuevo telefono de contacto: ");
                        empUpdate.HomePhone = Console.ReadLine();
                        break;
                }
            } while (caseSwitch != 0);

            context.SaveChanges();
        }
    }
}
