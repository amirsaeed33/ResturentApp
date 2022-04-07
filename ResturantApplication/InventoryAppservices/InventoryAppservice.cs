using ResturantApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ResturantApplication.InventoryAppservices
{
    public class InventoryAppservice
    {

        private readonly ApplicationDbContext _context;
        public InventoryAppservice()
        {
            _context = new ApplicationDbContext();
        }
        public async Task<Items> GetItemById(int Id)
        {
            return  _context.Items.AsNoTracking()                
                .Where(s => s.Id == Id).FirstOrDefault();
        } 
        public async Task<List<Items>> GetItemList()
        {
            return _context.Items.Where(s=>!s.IsDeleted).ToList();
        }
    }
}