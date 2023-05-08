using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.创建型设计模式._1_单例设计模式_静态内部类
{
    public class HungryClass
    {
        public static HungryClass GetSingleHungry()
        {
            return InnerClass.hungryClass;
        }


        //在类的内部，写一个静态类
        //内部静态类：不会跟着外部类（HungryClass）加载到内存中，只有在调用的时候才创建
        //仍然会被反射获取而破坏
        public static class InnerClass
        {
            public static readonly HungryClass hungryClass = new HungryClass();
        }


    }
}
