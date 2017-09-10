using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            //找出大9的数
            //int[] nums = new int[] { 3, 5, 8, 10, 4 };
            //IEnumerable<int> r1 = nums.MyWhere(i => i > 9);
            //foreach(int item in r1)
            //{
            //    Console.WriteLine(item);
            //}

            //MyWhere的另外的使用例子
              
            string[] strs = new string[] { "tom", "jim", "sssss" };
            //打印出长度=3的数组成员
            foreach (string name in strs.MyWhere(s=>s.Length==3))
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
