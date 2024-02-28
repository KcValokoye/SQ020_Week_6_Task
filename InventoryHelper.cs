using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ20.Net_Week6_Task
{
    public class InventoryHelper
    {
        public static IEnumerable<ItemSales> GenerateDistinctInnerJoin(List<Item> itemlist, List<Sales> saleslist)
        {
            return from item in itemlist
                join sale in saleslist on item.ItemId equals sale.ItemId
                select new ItemSales { ItemId = item.ItemId, ItemDes = item.ItemDes, Qty = sale.Qty };
        }
    }
}