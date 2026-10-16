using static LINQ.DataSources.Source;
using LINQ.DataSources;
using LINQ.Models;

namespace Linq_Assi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // َQ1
            var res1 = ProductList.Where(p => p.Category == "Seafood");
            foreach (var p in res1)
            {
                Console.WriteLine(p.ProductName + " " + p.UnitPrice);
            }

            Console.WriteLine();

            // Q2
            var res2 = ProductList.Select(p => p.ProductName);
            foreach (var name in res2){
                Console.WriteLine(name);
            }

            Console.WriteLine();

            // Q3
            var res3 = ProductList.OrderBy(p => p.UnitPrice);
            foreach (var p in res3)
            {
                Console.WriteLine(p.ProductName + " " + p.UnitPrice);
            }

            Console.WriteLine();

            // Q4
            var res4 = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            foreach (var p in res4)
                Console.WriteLine(p);

            Console.WriteLine();
        }
    }
}
