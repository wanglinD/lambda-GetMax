using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWhere
{
   static class JiHeExt
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> data,Func<T,bool> func)
        {
            List<T> resultList = new List<T>();
            foreach(T item in data)
            {
                if(func(item))//判断遍历到的这条数据是否满足条件func
                {
                    resultList.Add(item);
                }
            }
            return resultList;

        }
    }
}
