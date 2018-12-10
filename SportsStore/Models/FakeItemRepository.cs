using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeItemRepository : IItemRepository {
        public IQueryable<Item> Products => new List<Item> {

            new Item { Description = "Football", SellingPrice = 25},
            new Item { Description = "Surf Board", SellingPrice = 179},
            new Item { Description = "Surf Board", SellingPrice = 95},

            }.AsQueryable<Item>();
    }
}


