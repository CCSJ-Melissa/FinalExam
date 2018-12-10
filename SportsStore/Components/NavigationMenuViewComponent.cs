using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components {

    public class NavigationMenuViewComponent : ViewComponent {
        private IItemRepository repository;

        public NavigationMenuViewComponent(IItemRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke () { 
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Items
                .Select(x => x.Description)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
