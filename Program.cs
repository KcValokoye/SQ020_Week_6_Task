using System;
using System.Collections.Generic;
using System.Linq;

namespace SQ20.Net_Week6_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> states = new List<string>
            {
                "Abia", "Adamawa", "Akwa Ibom", "Anambra",
                "Bauchi", "Bayelsa", "Benue", "Borno",
                "Cross River", "Delta", "Ebonyi", "Edo",
                "Ekiti", "Enugu", "Gombe", "Imo",
                "Jigawa", "Kaduna", "Kano", "Katsina",
                "Kebbi", "Kogi", "Kwara", "Lagos",
                "Nasarawa", "Niger", "Ogun", "Ondo",
                "Osun", "Oyo", "Plateau", "Rivers",
                "Sokoto", "Taraba", "Yobe", "Zamfara"
            };

            //StateCounter.CountStates(states);
            var stateCounter = new StateCounter();
            stateCounter.CountStates(states);
            List<Item> itemlist = new List<Item>
            {
                new Item { ItemId = 1, ItemDes = "Bag" },
                new Item { ItemId = 2, ItemDes = "Pen" },
                new Item { ItemId = 3, ItemDes = "Book" },
                new Item { ItemId = 4, ItemDes = "Shoe" },
                new Item { ItemId = 5, ItemDes = "Pin" }
            };

            List<Sales> saleslist = new List<Sales> {
                new Sales{ InvNo=1, ItemId = 3, Qty = 10 },
                new Sales{ InvNo=2, ItemId = 2, Qty = 20 },
                new Sales{ InvNo=3, ItemId = 3, Qty = 500 },
                new Sales{ InvNo=4, ItemId = 4, Qty = 20 },
                new Sales{ InvNo=5, ItemId = 3, Qty = 100 },
                new Sales{ InvNo=6, ItemId = 1, Qty = 50 }
            };

            var result = InventoryHelper.GenerateDistinctInnerJoin(itemlist, saleslist);

            Console.WriteLine("Item ID\tItem Name\tQuantity");
            Console.WriteLine("---------------------------------------");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.ItemId}\t{item.ItemDes}\t{item.Qty}");
            }

            int groupSize = 3;
            var groupedStates = states.Select((state, index) => new { state, index })
                                      .GroupBy(x => x.index / groupSize)
                                      .Select(grp => string.Join(", ", grp.Select(x => x.state)));

            Console.WriteLine("A Group of states in set of 3:");
            Console.WriteLine("============================");
            foreach (var group in groupedStates)
            {
                Console.WriteLine(group);
                Console.WriteLine("----------------------------------------------------------------");
            }
        }
    }
}
