using ResturantApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ResturantApplication.InventoryAppservices2
{
    public class InventoryAppservice2
    {
        private readonly ApplicationDbContext _context;
        public InventoryAppservice2()
        {
            _context = new ApplicationDbContext();
        }
        public async Task<Cashier> GetCashiers(int Id)
        {
            return _context.Cashiers.AsNoTracking()
                .Where(c => c.Id == Id).FirstOrDefault();

        }
        public async Task<List<Cashier>> GetCashiers()
        {
            return _context.Cashiers.Where(c => !c.IsDeleted).ToList();
        }

        internal Task GetCashiersList()
        {
            throw new NotImplementedException();
        }
    }
}