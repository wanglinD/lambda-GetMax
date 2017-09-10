using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 高级集合扩展方法
{
    class Program
    {
        static void Main(string[] args)
        {
            var s0 = new Person { Name = "tom", Age = 3, Gender = true, Salary = 7000 };
            var s1 = new Person { Name = "jerry", Age = 8, Gender = true, Salary = 6000 };
            var s2 = new Person { Name = "jim", Age = 3, Gender = true, Salary = 6000 };
            var s3 = new Person { Name = "lily", Age = 5, Gender = true, Salary = 6000 };
            var s4 = new Person { Name = "lucy", Age = 6, Gender = true, Salary = 6000 };
            var s5 = new Person { Name = "kimi", Age = 5, Gender = true, Salary = 5000 };

            List<Person> list = new List<Person>();
            list.Add(s0);
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            list.Add(s4);
            list.Add(s5);


            Teacher t1 = new Teacher { Name = "rpeng张老师" };
            t1.Students.Add(s1);
            t1.Students.Add(s2);

            Teacher t2 = new Teacher { Name = "rpeng刘老师" };
            t1.Students.Add(s2);
            t1.Students.Add(s3);
            t1.Students.Add(s5);

            Teacher[] teacher = { t1, t2 };


            // Skip()  跳过前n条数据，用来分页获取数据
            //Skip(2).Take(1) 跳过2个，取1一个
            /*   var list1 = list.Skip(2).Take(1);
               foreach(var p1 in list1)
               {
                   Console.WriteLine(p1);
               }
               Console.ReadKey();*/

            //Except   Union   Intersect
            /*  int[] nums1 = { 3, 5, 6, 8, 9 };
              int[] nums2 = { 3, 8, 9, 4 };
              var nums3 = nums1.Except(nums2);//Except 去除nums1中与nums2相同的元素，得到一个新的集合

              var nums4 = nums1.Union(nums2);//合并两个集合

              var nums5 = nums1.Intersect(nums2);//求两个集合的交集
              foreach(int i in nums4)
              {
                  Console.WriteLine(i);
              }
              Console.ReadKey();
              */


            //根据年龄来分组   
            //以年龄为key int类型
            /*  IEnumerable<IGrouping<int,Person>> items=
                     list.GroupBy(g => g.Age);

                 foreach(IGrouping<int,Person> item in items)
                 {
                     Console.WriteLine("Key=" + item.Key);
                     foreach(Person p in item)
                     {
                         Console.WriteLine(p);
                     }
                 }
     */


            //根据性别来分组
            /*
                        IEnumerable<IGrouping<bool, Person>> itmes = list.GroupBy(g => g.Gender);


                        foreach (IGrouping<bool, Person> item in itmes)
                        {
                            Console.WriteLine("Key=" + item.Key);
                            foreach (Person p in item)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        */


            //用var 类型推断
            /*   var items = list.GroupBy(g => g.Age);
               foreach(var item in items)
               {
                   Console.WriteLine("Key=" + item.Key + ",avg="+item.Average(p=>p.Salary)+"最高工资"+item.Max(p=>p.Salary));
               }
               */

            //SelectMany
            IEnumerable<Person> students = teacher.SelectMany(t => t.Students);
            foreach (Person p in students)
            {
                Console.WriteLine(p);
            }



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
                         //左集合        需要链接的集合 //右集合 左表的字段  ，右表的字段
            var result = dogs.Where(d => d.Id > 1).Join(masters, d => d.MasterId, m => m.Id,
                (d, m) => new { DogName = d.Name, mastersName = m.Name });
            //d.Id=m.Id 查询结果放到这个集合里
            foreach(var item in result)
            {
                Console.WriteLine(item.DogName + "," + item.mastersName);
            }
            Console.ReadKey();

        }
    }
    //学生
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return string.Format("Name={0},Age={1},Gender={2}.Salary={3}", Name, Age, Gender, Salary);
        }
    }
    //老师
    public class Teacher
    {
        public Teacher()
        {
            this.Students = new List<Person>();
        }
        public string Name { get; set; }
        public List<Person> Students { get; set; }
    }

    //join
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
