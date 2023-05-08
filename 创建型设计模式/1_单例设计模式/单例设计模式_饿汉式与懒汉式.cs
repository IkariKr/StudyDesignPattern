using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudyDesignPattern.创建型设计模式._1_单利设计模式_饿汉式
{
    public class SingleHungry
    {
        //1.构造函数私有化
        private SingleHungry()
        {

        }

        //2.创建一个唯一的对象
        //private 迪米特原则
        //static 保证内存唯一
        // readonly ：不允许修改
        private static readonly SingleHungry _singleHungry = new SingleHungry();

        //3.Create a method , implement the ability to provide class
        //unique object externally
        public static SingleHungry GetSingleHungry()
        {
            return _singleHungry;
        }

    }
}

namespace StudyDesignPattern.创建型设计模式._1_单利设计模式_懒汉式
{
    public class LazyManSingle
    {
        //标记位
        private static bool isOK = false;


        //1.构造函数私有化
        private LazyManSingle()
        {
            lock (o)
            {
                ////如果if被执行，说明有反射来获取对象
                //if(_lazy != null)
                //{
                //    //直接抛出异常
                //    throw new Exception("不要用反射来执行构造函数");
                //}


                //允许在GetInstance之前，首次反射来调用构造函数
                if (isOK == false)
                {
                    isOK = true;
                }
                else
                {
                    throw new Exception("不要多次调用反射执行构造函数");
                }
            }
        }

        // 2.创建一个唯一的对象
        // private 迪米特原则
        // static 保证内存唯一
        // volatile : 不稳定的，不确定的，容易改变的
        // 用volatile标记的成员，可以避免指令重排
        private volatile static LazyManSingle _lazy;

        private static object o = new object();

        // 3.Create a method , implement the ability to provide class
        // unique object externally
        // unsafe multi-thread
        // lock C#提供的一个语法糖
        // Monitor.Enter() Monitor.Exit();互斥锁，用来解决多线程的安全问题。
        // 不加双重锁，会消耗系统资源
        public static LazyManSingle GetLazyManSingle()
        {
            if(_lazy == null)
            {
                lock (o)
                {
                    if (_lazy == null)
                    {
                        _lazy = new LazyManSingle();
                        Console.WriteLine("我被初始化了");
                    }
                }
            }

            return _lazy;
        }
    }
}
