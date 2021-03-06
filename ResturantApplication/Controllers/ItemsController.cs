using ResturantApplication.Models;
using ResturantApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResturantApplication.InventoryAppservices2;
using System.Threading.Tasks;

namespace ResturantApplication.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly InventoryAppservice _InventoryAppservice;

        public ItemsController()
        {
            _context = new ApplicationDbContext();
            _InventoryAppservice = new InventoryAppservice();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Items
        public async Task<ActionResult> ItemsIndex()
        {

            var items =await _InventoryAppservice.GetItemList();
            return View(items);
        }


        public async Task<ActionResult> NewItems(int id=-1)
        {
            ViewBag.Heading = "Add New Product";
            var data = new Items();
            if (id > 0)
            {
                ViewBag.Heading = "Update product";
                data = await _InventoryAppservice.GetItemById(id);
            }
           return View(data);
        }
      
        public async Task<ActionResult> Details(int id)
        {
            var items = await _InventoryAppservice.GetItemById(id);
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
                    MinQty = items.MinQty,
                    IsActive = true,
                    IsDeleted = false,

                };
                return View("NewItems", itemInDb);
            }
            if (items.Id == 0)
            {
                items.IsActive = true;
                _context.Items.Add(items);
            }
            else
            {
                var itemInDb = _context.Items.Single(i => i.Id == items.Id);
                itemInDb.ItemPrice = items.ItemPrice;
                itemInDb.MinQty = items.MinQty;
                itemInDb.IsActive = true;
                itemInDb.IsDeleted = false;
            }
            _context.SaveChanges();

            return RedirectToAction("ItemsIndex", "Items");

        }

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


        public async Task<ActionResult> Delete(int id)
        {
            if (id > 0)
            {
                var itemInDb = _context.Items.Single(i => i.Id == id);
               
                itemInDb.IsDeleted = true;
                
                _context.SaveChanges();
            }
            return RedirectToAction("ItemsIndex", "Items");
        }



    }
}
