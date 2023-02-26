using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_example
{
    internal class FoodItems
    {
        public List<Food> FoodItemList { get; set;}

        public FoodItems() { 
            FoodItemList = new List<Food>();
        }
    }
}
