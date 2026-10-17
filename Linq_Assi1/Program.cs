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

            // Q5
            var res5 = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments");
            foreach (var p in res5)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            // Q6
            var stockResult = ProductList.Select(p => new{
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"});
            foreach (var item in stockResult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Q7
            var numbered = ProductList.Select((p, i) => new { Number = i + 1, p.ProductName });
            foreach (var item in numbered)
            {
                Console.WriteLine(item.Number + ". " + item.ProductName);
            }

            Console.WriteLine();

            // Q8
            var SrtPr = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            foreach (var p in SrtPr)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            // 9
            var beverages = ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock);
            foreach (var p in beverages)
            {
                Console.WriteLine(p.ProductName + " " + p.UnitsInStock);
            }

            Console.WriteLine();

            // 10
            var orders1997 = from c in CustomerList
                             from o in c.Orders
                             where o.OrderDate.Year >= 1997
                             select new { c.CustomerID, o.OrderDate };
            foreach (var item in orders1997)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // 11
            var positions = ProductList.Select((p, i) => new { Position = i + 1, p.ProductName });
            foreach (var item in positions)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // 12
            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var SrtWds = Arr.OrderBy(w => w.Length).ThenBy(w => w.ToLower());
            foreach (var w in SrtWds)
            
                Console.WriteLine(w);
            

            Console.WriteLine();

            // 13
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var SecLetter = digits.Where(d => d[1] == 'i');
            var R = SecLetter.Reverse();
            foreach (var d in R)
            {
                Console.WriteLine(d);
            }

        }
    }
}
