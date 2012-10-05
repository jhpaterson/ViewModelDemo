using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelDemo.Models;
using ViewModelDemo.ViewModels;
using ViewModelDemo.Filters;
using AutoMapper;

namespace ViewModelDemo.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository repository = new ProductRepository();   // should really use Dependency Injection!!

        //
        // GET: /Product/

        public ActionResult Index()
        {
            IEnumerable<Product> products = repository.GetAllProducts();
            return View(products);
        }

        //
        // GET: /Product/Details/5

        [ProductDetailMap]
        public ActionResult Details(int id)
        {
            Product product = repository.GetProductByID(id);
            return View(product);
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            ViewBag.Categories = repository.GetAllCategories();
            return View();
        }

        //
        // POST: /Product/Create

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                repository.AddProduct(product);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Categories = repository.GetAllCategories();
                return View();
            }
        }

        //
        // GET: /Product/CreateVM

        public ActionResult CreateVM()
        {
            ProductViewModel pvm = new ProductViewModel
            {
                CategoryList = new SelectList(
                    repository.GetAllCategories(),
                    "categoryID",
                    "name")
            };
            return View(pvm);
        }

        //
        // POST: /Product/CreateVM

        [HttpPost]
        public ActionResult CreateVM(ProductViewModel pvm)
        {
            if (ModelState.IsValid)
            {
                repository.AddProduct(pvm.Product);
                return RedirectToAction("Index");
            }
            else
            {
                pvm = new ProductViewModel
                {
                    CategoryList = new SelectList(
                        repository.GetAllCategories(),
                        "categoryID",
                        "name")
                };
                return View(pvm);
            }
        }

        //
        // GET: /Product/CreateMVM

        public ActionResult CreateMVM()
        {
            MappedProductViewModel mpvm = 
                new MappedProductViewModel
            {
                CategoryList = new SelectList(
                    repository.GetAllCategories(),
                    "categoryID",
                    "name")
            };
            return View(mpvm);
        }

        //
        // POST: /Product/CreateMVM

        [HttpPost]
        public ActionResult CreateMVM(MappedProductViewModel mpvm)
        {
            if (ModelState.IsValid)
            {
                Product product = Mapper.Map<MappedProductViewModel,Product> (mpvm);
                repository.AddProduct(product);
                return RedirectToAction("Index");
            }
            else
            {
                mpvm = new MappedProductViewModel
                {
                    CategoryList = new SelectList(
                        repository.GetAllCategories(),
                        "categoryID",
                        "name")
                };
                return View(mpvm);
            }
        }

        //
        // GET: /Product/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Product/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Product/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
