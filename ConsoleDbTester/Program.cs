using AppLogic.DtoCreate;
using AppLogic.Management;
using DataAccess;
using Domain.InterfacesRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDbTester
{
    class Program
    {
        static void Main(string[] args)
        {

            Context context = new Context();
            var item = context.BeerBottles.Find(34);
            context.BeerBottles.Remove(item);
            context.SaveChanges();
            ////BeerShopDb context = new BeerShopDb();

            //var collection = context.StockPositions.ToList();
            //for(int i = 0; i < collection.Count; i++)
            //{
            //    Console.WriteLine($"{collection[i].BeerBottle.BeerEntity.TradeMark.Name} " +
            //                      $"{collection[i].BeerBottle.BeerEntity.Name}, " +
            //                      $"{collection[i].BeerBottle.BeerEntity.BeerKind.Name} - " +
            //                      $"{collection[i].BeerBottle.Capacity.Cap}l - " +
            //                      $"{collection[i].BottleCount} шт.");
            //    if(collection[i].BottleCount == 0)
            //    {
            //        collection[i].BottleCount = 7;
            //        context.SaveChanges();
            //        Console.WriteLine("Добавлено кол-во");
            //    }
            //    Console.WriteLine();
            //}

            //foreach (var item in collection)
            //{
            //    Console.WriteLine($"{item.BeerBottle.BeerEntity.TradeMark.Name} {item.BeerBottle.BeerEntity.Name}, {item.BeerBottle.BeerEntity.BeerKind.Name} - {item.BeerBottle.Capacity.Cap}l - {item.BottleCount} шт.");
            //}
            //BeerBottleManager manager = new BeerBottleManager();
            //var collection = BeerBottleManager.GetAll();
            //foreach (var item in collection)
            //{
            //    Console.WriteLine($"{item.BeerEntity.TradeMark.Name} {item.BeerEntity.Name} {item.BeerEntity.BeerKind.Name} {item.Capacity.Cap} {item.Price}");
            //}

            //Console.WriteLine("Добавление нового объекта");

            //var bb = BeerBottleManager.Add(new CreateBeerBottle { Price = 37, BeerEntityId = 5, CapacityId = 3, DateOfSpill = DateTime.Now });

            //BeerBottleManager manager = new BeerBottleManager();
            //var collection = manager.GetAll();
            //foreach (var item in collection)
            //{
            //    Console.WriteLine($"{item.ID} {item.BeerEntity.TradeMark.Name} {item.BeerEntity.Name} {item.BeerEntity.BeerKind.Name} {item.Capacity.Cap} {item.Price}");
            //}

           
            //Console.WriteLine(collection.Count);
            //Console.WriteLine($"Удаление {(manager.Remove(35)).BeerEntity.Name}");
            //Console.WriteLine();
            //collection = manager.GetAll();
            //foreach (var item in collection)
            //{
            //    Console.WriteLine($"{item.BeerEntity.TradeMark.Name} {item.BeerEntity.Name} {item.BeerEntity.BeerKind.Name} {item.Capacity.Cap} {item.Price}");
            //}

            //BeerEntityManager manager = new BeerEntityManager();
            //var collection = manager.GetAll();
            //foreach (var item in collection)
            //{
            //    Console.WriteLine($"{item.Name} {item.TradeMark.Name}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Добавление нового объекта");
            //Console.WriteLine();

            //Console.WriteLine((manager.Add(new CreateBeerEntity { Name = "Просто Пиво", Alcohol = 5, BeerKindId = 1, Breadness = 3, TradeMarkId = 3 })).TradeMark.Name);



            Console.ReadLine();
        }
    }
}
