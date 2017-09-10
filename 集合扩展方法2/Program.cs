using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合扩展方法2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = { };
            string[] str2 = {"hello"};
            string[] str3 = { "hello", "rupeng" };
            int[] nums = { };

              //First获取集合中的第一个元素，如果没有元素则抛异常
            List<int> list = new List<int>();
            string s = str1.First();
            int i = list.First();

            //FirstOrDefault 或取集合中的第一个元素，如果一个都没有则返回类型的默认值
            string s1 = str1.FirstOrDefault();//没有第一个元素返回null

            int i1 = nums.FirstOrDefault();//对于int 来说一个都没有返回 0
            //Console.WriteLine(s);
            //Console.ReadKey();


            //Single 获取集合中的唯一一个元素，如果没有元素，或者有不止一个元素则抛异常
            string s2 = str1.Single();//没有元素抛异常
            string s3 = str2.Single();//返回str2中的唯一一个元素。

            //SingleOrDefault 或取集合中的唯一一个元素，如果没有元素则返回null
            //如果有多个元素也抛异常
        }
    }
}
