using ItAcademyWebShop.Items.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace ItAcademyWebShop.Views.Shared
{
    public class _LayoutModel : PageModel
    {
        private IRepository _repository;

        public List<ICategory> GetMenuItems()
        {
            return _repository.GetCategories().ToList();
        }

        public _LayoutModel(IRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
        }

    }
}
