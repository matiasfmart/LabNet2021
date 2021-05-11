using Ejercicio6.MVC.Entities;
using Ejercicio6.MVC.Logic;
using Ejercicio6.MVC.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio6.MVC.Project.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        ProductsLogic logic = new ProductsLogic();
        public ActionResult Index()
        {
            var logic = new ProductsLogic();
            List<Entities.Products> products = logic.GetAll();

            List<ProductsView> productsViews = products.Select(s => new ProductsView
            {
                Id = s.ProductID,
                ProductName = s.ProductName,
                Price = (decimal)s.UnitPrice
            }).ToList();

            return View(productsViews);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ProductsView productsView)
        {
            try
            {
                var productEntity = new Products { 
                    ProductName = productsView.ProductName,
                    UnitPrice = productsView.Price
                };

                logic.Add(productEntity);

                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult UpDate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpDate(ProductsView productsView)
        {
            try
            {
                var productEntity = new Products
                {
                    ProductID = productsView.Id,
                    ProductName = productsView.ProductName,
                    UnitPrice = productsView.Price
                };

                logic.Update(productEntity);

                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error");
            }
        }

    }
}