using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;


namespace FinalExam.Controllers
{
    public class ItemController : Controller
    {
        private IItemRepository repository;
   
        
        public ItemController(IItemRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() 
            => View(repository.Items);
    }
}
