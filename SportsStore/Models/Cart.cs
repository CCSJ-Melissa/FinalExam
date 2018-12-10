using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Item item, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Item.ItemID == item.ItemID)
                .FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Item = item,
                    Quantity = quantity
                });
            } else {
                line.Quantity += quantity;
            }
          }
        public virtual void RemoveLine(Item item) =>
            lineCollection.RemoveAll(l => l.Item.ItemID == item.ItemID);
        public virtual decimal ComputeTotalValue() =>
            lineCollection.Sum(e => e.Item.SellingPrice * e.Quantity);
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<CartLine> Lines => lineCollection;
        }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
    }

