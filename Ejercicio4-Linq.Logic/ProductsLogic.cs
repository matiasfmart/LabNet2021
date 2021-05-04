using Ejercicio4_Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Linq.Logic
{
    public class ProductsLogic : BaseLogic
    {
        /*-----------------punto2, Query para devolver todos los productos sin stock--------------------*/
        public List<Products> OutOfStock()
        {
            var query = from products in context.Products
                        where products.UnitsInStock == 0
                        select products;
            return query.ToList();
        }

        /*-----------------3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad--------------------*/
        public List<Products> InStock()
        {
            var query = from products in context.Products
                        where products.UnitsInStock != 0 && products.UnitPrice > 3
                        select products;
            return query.ToList();
        }

        /*-----------------5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789--------------------*/
        public Products FirstElement()
        {
            var query = (from products in context.Products
                            where products.ProductID == 789
                            select products).FirstOrDefault();
            return query;
        }

        /*-----------------9.Query para devolver lista de productos ordenados por nombre----------------*/
        public List<Products> ProductOrderByName()
        {
            var query = context.Products.OrderBy(p => p.ProductName);
            return query.ToList();
        }

        /*-----------------10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.----------------*/
        public List<Products> ProductOrderByDesc()
        {
            var query = context.Products.OrderByDescending(p => p.UnitsInStock);
            return query.ToList();
        }
    }
}
