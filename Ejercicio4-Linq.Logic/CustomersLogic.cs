using Ejercicio4_Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_Linq.Logic
{
    public class CustomersLogic : BaseLogic
    {
        /*-----------------punto1, Query para devolver objeto costumer--------------------*/
        public List<Customers> CustomerObjet()
        {
            var query = from customer in context.Customers
                         select customer;
            return query.ToList();
        }

        /*-----------------4. Query para devolver todos los customers de Washington------------------*/
        public List<Customers> CustFromW()
        {
            var query = from customer in context.Customers
                        where customer.Region == "WA"
                        select customer;
            return query.ToList();
        }

        /*-----------------6. Query para devolver los nombres de los Customers. Mostrarlos en Mayuscula y en Minuscula------------------*/
        public List<Customers> NamesCustomers()
        {
            var query = from customer in context.Customers
                        select customer;
            return query.ToList();
        }

        /*-----------------7. Query para devolver Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1/1/1997.------------------*/
        public void CustomersJoinOrders()
        {
            DateTime maxOrder = new DateTime(1997,1,1);

            var query = context.Orders.Join(
                context.Customers,
                o => o.CustomerID,
                c => c.CustomerID,
                (o, c) => new
                {
                    c.CustomerID,
                    c.ContactName,
                    c.Region,
                    o.OrderDate
                })
                .Where(c => c.Region == "WA" && c.OrderDate > maxOrder);

            foreach (var item in query)
            {
                Console.WriteLine($"ID: {item.CustomerID} - Nombre: {item.ContactName} - Region: {item.Region} - OrderDate: {item.OrderDate}");
            }
        }

        /*-----------------8. Query para devolver los primeros 3 Customers de Washington------------------*/
        public List<Customers> CostumersFirstRegion()
        {
            var query = context.Customers.Where(c => c.Region == "WA")
                                         .Take(3)
                                         .ToList();
            return query;
        }
    }
}
