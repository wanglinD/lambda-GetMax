using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda表达式改造GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 44, 35, 15 };
            //  int m = GetMax<int>(nums, compareInt); //原来的样子

            //lambda表达式推演
            //1：
            // Func<int, int, bool> f = delegate (int i1, int i2) { return i1 > i2; };
            // int m = GetMax<int>(nums, f);

            //2:
            //int m = GetMax<int>(nums, delegate (int i1, int i2) { return i1 > i2; });

            //3:
            //int m = GetMax<int>(nums, ( i1,  i2)=>{ return i1 > i2; });

            //4：
            int m = GetMax<int>(nums, (i1, i2) => i1 > i2);

            Console.WriteLine(m);

            // GetMax的另一个例子,判断哪个人的年龄大
            Person[] persons = new Person[] {new Person(8,"baidu"),
            new Person(52,"QQ"),new Person(27,"sina")};
            Person p = GetMax(persons, (p1, p2) => p1.Age > p2.Age);
            //delegate(Person p1,Person p2){return p1.Age>p2.Age;}
            Console.WriteLine(p);
            Console.ReadKey();
        }
        ////static bool compareInt(int i1,int i2)
        ////{
        ////    return i1 > i2;
        ////}
        static T GetMax<T>(T[] objs, Func<T, T, bool> compareFunc)
        {
            T max = objs[0];
            for (int i = 1; i < objs.Length; i++)
            {
                if (compareFunc(objs[i], max))//如果objs[i]>max
                {
                    max = objs[i];
                }
            }
            return max;
        }
    }
        class Person
        {
          public Person(int age,string name)
        {
            this.Age = age;
            this.Name=name;
        }
           public int Age { get; set; }
           public string Name { get; set; }
        public override string ToString()
        {
            return "age=" + this.Age + ",Name=" + this.Name;
        }
    }
}
