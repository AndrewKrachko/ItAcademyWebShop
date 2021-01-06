using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItAcademyWebShop.Items.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItAcademyWebShop.Views.Shared
{
    public class _LayoutModel : PageModel
    {
        private IRepository _repository;

        public List<ICategory> GetMenuItems ()
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
