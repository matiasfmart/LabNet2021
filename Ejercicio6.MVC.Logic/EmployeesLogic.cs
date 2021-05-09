using Ejercicio6.MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.MVC.Logic
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

        public void Update(Employees toUpDate) //Se modifican los datos
        {
            var employeeUpDate = context.Employees.Find(toUpDate.EmployeeID);

            employeeUpDate.FirstName = toUpDate.FirstName;
            employeeUpDate.LastName = toUpDate.LastName;

            context.SaveChanges();
        }
    }
}
