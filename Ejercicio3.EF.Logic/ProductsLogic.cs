using Ejercicio6.MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.MVC.Logic
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

        public void Update(Products toUpDate) //Se modifican los datos
        {
            var productUpDate = context.Products.Find(toUpDate.ProductID);

            productUpDate.ProductName = toUpDate.ProductName;
            productUpDate.UnitPrice = toUpDate.UnitPrice;

            context.SaveChanges();
        }
    }
}
