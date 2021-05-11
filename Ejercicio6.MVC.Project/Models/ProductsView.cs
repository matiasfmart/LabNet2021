using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ejercicio6.MVC.Project.Models
{
    public class ProductsView
    {
        public int Id { get; set; }

        [StringLength(40)]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}