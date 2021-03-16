using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_first
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ShopAdoEntities sp = new ShopAdoEntities())
            {
                //var category = sp.Category;
                //foreach (var cat in category)
                //    Console.WriteLine(cat.CategoryName);
                //Category categ = new Category
                //{
                //    CategoryId = 8,
                //    CategoryName = "LG"

                //};
                //sp.Category.Add(categ);
                //sp.SaveChanges();
                //Category cat = sp.Category.FirstOrDefault(x => x.CategoryId == 5);
                //if(cat!=null)
                //{
                //    cat.CategoryName = "Orey";
                //}
                //sp.SaveChanges();
                //var categ = sp.Category.Where(x => x.CategoryName.ToLower().Contains("video"));
                //sp.Category.RemoveRange(categ);
                //sp.SaveChanges();
            }
            using (ShopAdoEntities shop = new ShopAdoEntities())
            {
                //var good = shop.Good;
                //foreach (var goods in good)
                //    Console.WriteLine(goods.GoodName);
                //Good go = new Good
                //{
                //    GoodId = 1,
                //    GoodName = "Acer",
                //    Price = 345,
                //    GoodCount = 7895


                //};
                //Good goo = new Good
                //{
                //    GoodId = 4,
                //    GoodName = "Lenovo",
                //    Price = 35,
                //    GoodCount = 105463


                //};
                //Good goodd = new Good
                //{
                //    GoodId = 12,
                //    GoodName = "Apple",
                //    Price = 25,
                //    GoodCount = 68463


                //};
                //shop.Good.Add(go);
                //shop.Good.Add(goo);
                //shop.Good.Add(goodd);
                //shop.SaveChanges();
                //Good g = shop.Good.FirstOrDefault(x => x.GoodName == "tyui");
                //if (g != null)
                //{
                //    g.GoodName = "Toshiba";
                //    g.Price = 1234;
                //    g.GoodCount = 1234;
                //}
                //shop.SaveChanges();
                //var categ = shop.Good.Where(x => x.GoodName.ToLower().Contains("video"));
                //shop.Good.RemoveRange(categ);
                //shop.SaveChanges();
            }
            using (ShopAdoEntities shops = new ShopAdoEntities())
            {
                //var manuf = shops.Manufacturer;
                //foreach (var manufs in manuf)
                //    Console.WriteLine(manufs.ManufacturerName);
                //Manufacturer m = new Manufacturer
                //{

                //    ManufacturerName="Tokio"


                //};
                //Manufacturer ma = new Manufacturer
                //{

                //    ManufacturerName = "China"


                //};
                //Manufacturer man = new Manufacturer
                //{

                //    ManufacturerName = "Ukraine"


                //};
                //shops.Manufacturer.Add(m);
                //shops.Manufacturer.Add(ma);
                //shops.Manufacturer.Add(man);
                //shops.SaveChanges();
                //Manufacturer m = shops.Manufacturer.FirstOrDefault(x => x.ManufacturerName == "HP");
                //if (m != null)
                //{
                //    m.ManufacturerName = "Toshiba";

                //}
                //shops.SaveChanges();
                var man = shops.Manufacturer.Where(x => x.ManufacturerName.ToLower().Contains("China"));
                shops.Manufacturer.RemoveRange(man);
                shops.SaveChanges();
            }
        }
    }
}
