using ItAcademyWebShop.Items.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItAcademyWebShop.Views.Shared
{
    public class ItemModel : PageModel
    {
        private IRepository _repository;
        public string ActiveCategory { get; set; }

        public ItemModel(IRepository repository)
        {
            _repository = repository;
        }

        public List<ICategory> GetMenuItems()
        {
            return _repository.GetCategories().ToList();
        }

        public List<IItem> GetCategoryItems()
        {
            if (ActiveCategory == "")
            {
                ActiveCategory = _repository.GetCategories().FirstOrDefault()?.CategoryName ?? "";
            }

            return _repository.GetCategoryItems(ActiveCategory).ToList();
        }
    }
}
