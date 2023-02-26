using csharp_example;
using System.IO;
using System.Text;

class Program
{
    public static void InitializeData(FoodItems foodItems)
    {
        //https://www.csharp-examples.net/filestream-open-file/
        //https://www.csharp-examples.net/read-text-file/

        //https://bytes.com/topic/c-sharp/insights/920520-how-can-i-get-current-directory-project-folder
        var dirname = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\files\";

        Directory.SetCurrentDirectory(dirname);

        foreach (var v in File.ReadLines(@"FoodItemlist.txt", Encoding.UTF8))
        {
            string[] infoList = v.Split(",");
            if (infoList[0] != "Name")
            {
                Food food = new Food();
                food.Name = infoList[0].Trim();
                food.Amount = Int32.Parse(infoList[1]);
                food.Price = infoList[2].Trim();
                int centPrice = Int32.Parse(infoList[2].Substring(2).Replace(".", ""));
                food.CentPrice = centPrice;
                foodItems.FoodItemList.Add(food);
            }
            //Console.WriteLine(v);
        }
        foreach (Food f in foodItems.FoodItemList)
        {
            Console.WriteLine(f.Name);
            Console.WriteLine(f.Amount);
            Console.WriteLine(f.Price);
            Console.WriteLine(f.CentPrice);
        }
    }

    public static void Main()
    {
        FoodItems foodItems = new FoodItems();

        InitializeData(foodItems);
    }
}
