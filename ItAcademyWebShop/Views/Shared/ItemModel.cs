using ItAcademyWebShop.Items.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace ItAcademyWebShop.Views.Shared
{
    public class ItemModel : PageModel
    {
        private IDataBroker _repository;
        public string ActiveCategory { get; set; }

        public ItemModel(IDataBroker repository)
        {
            _repository = repository;
        }

        public List<ICategory> GetMenuItems()
        {
            return _repository.GetCategory().ToList();
        }

        public List<IItem> GetCategoryItems()
        {
            if (ActiveCategory == "")
            {
                ActiveCategory = _repository.GetCategory().FirstOrDefault()?.CategoryName ?? "";
            }

            return _repository.GetItemsByCategory(ActiveCategory).ToList();
        }
    }
}
