using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合扩展方法1
{
   static class MyEx
    {
        public static int MySum<T>(this IEnumerable<T> data,Func<T,int> func)
        {
            int sum  = 0;
            foreach(T item in data)
            {
                sum = sum + func(item);
            }
            return sum;
        }
    }
}
