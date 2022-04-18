using ResturantApplication.InventoryAppservices2;
using ResturantApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ResturantApplication.Controllers
{
    public class CashiersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly InventoryAppservice2 _InventoryAppservice2;

        public CashiersController()
        {
            _context = new ApplicationDbContext();
            _InventoryAppservice2 = new InventoryAppservice2();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET: Items
        public async Task<ActionResult> CashierIndex()
        {

            var employeePositions = await _InventoryAppservice2.GetCashiers();
            return View(employeePositions);
        }


        public async Task<ActionResult> NewCashier(int id = -1)
        {
            ViewBag.Heading = "Add New Cashier";
            var data = new Cashier();
            if (id > 0)
            {
                ViewBag.Heading = "Update Cashier";
                data = await _InventoryAppservice2.GetCashiers(id);
            }
            return View(data);
        }

        public async Task<ActionResult> Details(int id)
        {
            var cashier = await _InventoryAppservice2.GetCashiers(id);
            if (cashier == null)
            {
                return HttpNotFound();
            }
            return View(cashier);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Save(Cashier cashier)
        {
            if (!ModelState.IsValid)
            {
                var cashierInDb = new Cashier
                {
                    FullName = cashier.FullName,
                    BirthDate = cashier.BirthDate,
                    Gender = cashier.Gender,
                    PhoneNumber = cashier.PhoneNumber,
                    EmailAddress = cashier.EmailAddress,
                    Position = cashier.Position,
                    ComputerLiterate = true,
                    IsDeleted = false,

                };
                return View("NewCashier", cashierInDb);
            }
            if (cashier.Id == 0)
            {
                cashier.ComputerLiterate = true;
                _context.Cashiers.Add(cashier);
            }
            else
            {
                var cashierInDb = _context.Cashiers.SingleOrDefault(e => e.Id == cashier.Id);
                cashierInDb.FullName = cashier.FullName;
                cashierInDb.BirthDate = cashier.BirthDate;
                cashierInDb.Gender = cashier.Gender;
                cashierInDb.PhoneNumber = cashier.PhoneNumber;
                cashierInDb.EmailAddress = cashier.EmailAddress;
                cashierInDb.Position = cashier.Position;
                cashierInDb.ComputerLiterate = true;

            }
            _context.SaveChanges();

            return RedirectToAction("CashierIndex", "Cashier");
        }


        [HttpPost]
        public ActionResult Edit(int id)
        {
            var cashierInDb = _context.Cashiers.SingleOrDefault(i => i.Id == id);

            if (cashierInDb == null)
                return HttpNotFound();

            var cashier = new Cashier
            {

                FullName = cashierInDb.FullName,
                BirthDate = cashierInDb.BirthDate,
                Gender = cashierInDb.Gender,
                PhoneNumber = cashierInDb.PhoneNumber,
                EmailAddress = cashierInDb.EmailAddress,
                Position = cashierInDb.Position,
                ComputerLiterate = true,
                IsDeleted = false,


            };
            return View("NewCashier", cashierInDb);
        }


        public async Task<ActionResult> Delete(int id)
        {
            if (id > 0)
            {
                var cashierInDb = _context.Cashiers.Single(i => i.Id == id);

                cashierInDb.IsDeleted = true;

                _context.SaveChanges();
            }
            return RedirectToAction("CashierIndex", "Cashier");
        }



    }
}