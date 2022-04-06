using ResturantApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResturantApplication.ViewModel
{
    public class ItemsViewModel
    {
        public List<Product> Product { get; set; }



        public int? Id { get; set; }

        [Required(ErrorMessage = "Please Enter Item Name.")]
        public string Names { get; set; }

        [Required(ErrorMessage = "Please Enter The Item Price.")]
        public int? ItemPrice { get; set; }



        //public IEnumerable<ItemsViewModel> ItemsViewModels { get; set; }
        //public IEnumerable<Items> Items { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Items";
                return "NewItems Items";
            }
        }
        public ItemsViewModel()
        {
            Id = 0;
        }

        public ItemsViewModel(Items items)
        {
            Id = items.Id;
            Names = items.Names;
            ItemPrice = items.ItemPrice;
        }
       



    }
}