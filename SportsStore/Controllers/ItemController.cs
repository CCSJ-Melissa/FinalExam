using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace FinalExam.Controllers
{
    public class ItemController : Controller
    {
        private IItemRepository repository;
        public int PageSize = 4;
        
        public ItemController(IItemRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string description, int productPage = 1) 
            => View( new ItemsListViewModel{
                Items = repository.Items
                .Where(p => description == null || p.Description == description)
                .OrderBy(p => p.ItemID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = description == null ?
                        repository.Items.Count() :
                        repository.Items.Where(e =>
                            e.Description == description).Count()
                },
                CurrentCategory = description
                });
    }
}
