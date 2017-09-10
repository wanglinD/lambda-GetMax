using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    class Person
    {
        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
                if(value%12==0)
                {
                    //if(OnBenMingNian!=null)
                    //{
                    //    OnBenMingNian();//调用添加的组合的方法
                    //}

                   if(this._OnBenMingNian!=null)
                    {
                        this._OnBenMingNian();
                    }
                }
            }
        }
        //这里加上event就是事件，不加event就是委托
        //简写
        //public event Action OnBenMingNian;//委托类型 事件的名字

        //麻烦的写法
        private Action _OnBenMingNian;
        public event Action OnBenMingNian
        {
            add
            {

                this._OnBenMingNian += value;
            }
            remove
            {
                this._OnBenMingNian -= value;
            }
        }
    }
}
