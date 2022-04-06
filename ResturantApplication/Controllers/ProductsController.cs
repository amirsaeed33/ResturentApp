using ResturantApplication.Models;
using ResturantApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResturantApplication.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Products
        public ActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }


        [HttpGet]
        public JsonResult GetItemUnitPrice(int Id)
        {
            int ItemUnitPrice = _context.Items.Single(i => i.Id == Id).ItemPrice; 
            return Json(ItemUnitPrice, JsonRequestBehavior.AllowGet);
        }


        public ActionResult New()
        {
            var items = _context.Items.ToList();
            var paymentType = _context.PaymentTypes.ToList();
            var viewModel = new ProductViewModel
            {
                Items = items,
                PaymentTypes = paymentType

            };

            return View("New", viewModel);
        }

        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }


        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (product.Id == 0)
                _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index", "Products");
        }

        public ActionResult Save()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }


        public ActionResult Delete()
        {
            return View();
        }

    }
}