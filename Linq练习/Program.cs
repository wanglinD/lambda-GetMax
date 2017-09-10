using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Master m1 = new Master { Id = 1, Name = "wl" };
            Master m2 = new Master { Id = 2, Name = "比尔盖茨" };
            Master m3 = new Master { Id = 3, Name = "周星驰" };
            Master[] masters = { m1, m2, m3 };

            Dog d1 = new Dog { Id = 1, MasterId = 3, Name = "旺财" };
            Dog d2 = new Dog { Id = 2, MasterId = 3, Name = "汪汪" };
            Dog d3 = new Dog { Id = 3, MasterId = 1, Name = "京巴" };
            Dog d4 = new Dog { Id = 4, MasterId = 2, Name = "泰迪" };
            Dog d5 = new Dog { Id = 5, MasterId = 1, Name = "中华田园" };
            Dog[] dogs = { d1, d2, d3, d4, d5 };
            ////左集合        需要链接的集合 //右集合 左表的字段  ，右表的字段
            //var result = dogs.Where(d => d.Id > 1).Join(masters, d => d.MasterId, m => m.Id,
            //    (d, m) => new { DogName = d.Name, mastersName = m.Name });
            ////d.Id=m.Id 查询结果放到这个集合里
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.DogName + "," + item.mastersName);
            //}

            //Linq
            //var items = dogs.Where(d => d.Id > 1).Select(d =>
            //new { DogName = d.Name, DId = d.Id });


            //var items = dogs.Where(d => d.Id > 1).Select(d =>
            //   new { DogName = d.Name, DId = d.Id });
            //Linq 写法
            var items = from d in dogs
                        where d.Id > 1
                        select new { DogName = d.Name, DId = d.Id };
            foreach (var item in items)
            {
                Console.WriteLine(item.DogName + "," + item.DId);
            }
            Console.ReadKey();
        }
    }
        class Master
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return "Id=" + Id + ",Name" + Name;
            }
        }

        class Dog
        {
            public long Id { get; set; }
            public long MasterId { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return "Id=" + Id + ",MasterId=" + MasterId + ",Name=" + Name;
            }


        }
    
    }
