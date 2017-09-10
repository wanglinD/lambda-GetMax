using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合扩展方法1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(4);
            list.Add(9);
            list.Add(15);
            list.Add(25);
/*
            //获取集合中大于7的数
            foreach (int item in list.Where(a => a > 7))
            {
                Console.WriteLine(item);
            }
*/
            //获取集合中大于7的数中最的的数
            int m = list.Where(i => i > 7).Max();
            Console.WriteLine(m);
            Console.ReadKey();









            //where对数据按照lambda表达式进行过滤
            //获得集合里>10的数,Where 是asp.net自带的方法
            //IEnumerable<int> data = list.Where(i => i > 10);

            //遍历这个集合，把集合里的每个元素乘以2
            //IEnumerable<int> data = list.Select(w => w*2);

            //foreach (int item in data)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();

            //select则是对集合中的数据进行逐条处理，生成一个新的集合,集合长度和原始集合一样
            //IEnumerable<string> data = list.Select(w => "你好" + w);//(int w){return "你好"+w;}
            //foreach(string s in data)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.ReadKey();


            //int max = list.Max();
            //int min = list.Min();
            //int sum = list.Sum();
            //double avg = list.Average();
            //Console.WriteLine(max + "," + min + "," + sum + "," + avg);


            Person[] persons = new Person[] {new Person(8,"baidu"),
            new Person(52,"QQ"),new Person(27,"sina")};
            //年龄之和
            //int sum = persons.Sum(p => p.Age);
            //调用自己写的方法MySum
            // int sum = persons.MySum(p => p.Age);
            //int sum = persons.MySum(p => 5);
            //int sun = persons.MySum(p => p.Name.Length);
            //int sum = persons.Sum(p =>p.Name.Length);
            // int Max = persons.Max(p => p.Name.Length);
            //int max = persons.Max(p => p.Age);
            //Console.WriteLine(max);

            //foreach(int item in list.OrderBy(i => i))
            //{
            //    Console.WriteLine(item);
            //}

            List<Person> ps = persons.OrderBy(p => p.Age).ToList();
            Person[] ps2 = persons.OrderBy(p => p.Age).ToArray();
            List<Person> ps3 = persons.ToList();
            Person[] ps4 = ps3.ToArray();
            Console.ReadKey();

        }
    }
    class Person
    {
        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return "age=" + this.Age + ",Name=" + this.Name;
        }
    }
}
