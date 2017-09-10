using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托的组合
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDel d1 = F1;//MyDel d1 = new MyDel(F1);
            MyDel d2 = F2;
            MyDel d3 = F3;
            //委托的组合
            MyDel d4 = d1 + d2 + d3;
            MyDel d5 = new MyDel(F1) + new MyDel(F2) + new MyDel(F3);

            d4(6);//此时会依次调用F1，F2，F3 的方法
        }

        static void F1(int i)
        {
            Console.WriteLine("我是F1" + i * 2);
        }
        static void F2(int i)
        {
            Console.WriteLine("我是F2" + i * 3);
        }
        static void F3(int i)
        {
            Console.WriteLine("我是F3" + i * 4);
        }
    }
    delegate void MyDel(int i);
}
