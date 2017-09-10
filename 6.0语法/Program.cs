using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._0语法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            //Console.WriteLine(p1.Age);

            //nameof 用法
            string s1 = nameof(p1);


            Console.WriteLine(s1);

            Console.ReadKey();
        }
    }
    class Person
    {
        /*  public int Age; 
          public Person()
          {
              this.Age = 6;
          }
          */
          //c#6.0语法
        public int Age { get; set; } = 5;

        public void SayHello()
        {
            Console.WriteLine("我"+Age+"岁了。");
        }
    }
}
