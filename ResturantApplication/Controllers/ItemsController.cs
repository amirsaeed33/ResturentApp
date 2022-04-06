using ResturantApplication.Models;
using ResturantApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResturantApplication.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ItemsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Items
        public ActionResult ItemsIndex()
        {

            var items = _context.Items.ToList();
            return View(items);
        }


        public ActionResult NewItems()
        {
            return View();
        }
      
        public ActionResult Details(int id)
        {
            var items = _context.Items.SingleOrDefault(i => i.Id == id);
            if (items == null)
            {
                return HttpNotFound();
            }
            return View(items);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Save(Items items)
        {
            if (!ModelState.IsValid)
            {
                var itemInDb = new Items
                {
                    ItemPrice = items.ItemPrice,
                    Names = items.Names

                };
                return View("NewItems", itemInDb);
            }
            if (items.Id == 0)
            {
                _context.Items.Add(items);
            }
            else
            {
                var itemInDb = _context.Items.Single(i => i.Id == items.Id);
                itemInDb.Names = items.Names;
                itemInDb.ItemPrice = items.ItemPrice;
            }
            _context.SaveChanges();

            return RedirectToAction("ItemsIndex", "Items");






            //if (items.Id == 0)
            //    _context.Items.Add(items);
            //else
            //{
            //    var itemsInDB = _context.Items.Single(i =>i.Id == items.Id);

            //    itemsInDB.Names = items.Names;
            //    itemsInDB.ItemPrice = items.ItemPrice;

            //}
            //_context.SaveChanges();

            //return RedirectToAction("ItemsIndex", "Items");
        }

        //public ActionResult Save()
        //{
        //    return View();
        //}

        
        [HttpPost]
        public ActionResult Edit(int id)
        {
            var itemInDb = _context.Items.SingleOrDefault(i => i.Id == id);

            if (itemInDb == null)
                return HttpNotFound();

            var items = new Items
            {

                ItemPrice = itemInDb.ItemPrice,
                Names = itemInDb.Names

            };
            return View("NewItems", itemInDb);
        }


        public ActionResult Delete()
        {
            return View();
        }



    }
}
