using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.结构型设计模式._2_装饰器设计模式
{
    public class 装饰器设计模式
    {
        public void Main()
        {
            //创建奶茶对象
            MilkTea milkTea = new MilkTea();
            //创建两份布丁对象
            Buding buding1 = new Buding();
            Buding buding2 = new Buding();
            //创建珍珠对象
            ZhenZhu zhenZhu = new ZhenZhu();

            buding1.SetComponent(milkTea);
            buding2.SetComponent(buding1);
            zhenZhu.SetComponent(buding2);

            Console.WriteLine(zhenZhu.Cost());

        }
    }

    public abstract class Decorator : YinLiao
    {
        //添加父类的引用
        private YinLiao yinLiao;
        //通过Set方法，给他赋值
        public void SetComponent(YinLiao yinLiao)
        {
            this.yinLiao = yinLiao;
        }

        public override double Cost()
        {
            return this.yinLiao.Cost();
        }
    }

    public class Buding: Decorator
    {
        private static double money = 5;
        public override double Cost()
        {
            Console.WriteLine("布丁5块");
            return base.Cost() + money;
        }
    }

    public class XianCao : Decorator
    {
        private static double money = 6;
        public override double Cost()
        {
            Console.WriteLine("仙草6块");
            return base.Cost() + money;
        }
    }

    public class ZhenZhu : Decorator
    {
        private static double money = 7;
        public override double Cost()
        {
            Console.WriteLine("珍珠7块");
            return base.Cost() + money;
        }
    }


    public abstract class YinLiao
    {
        public abstract double Cost();
    }

    public class MilkTea : YinLiao
    {
        public override double Cost()
        {
            Console.WriteLine("牛奶茶20块");
            return 20;
        }
    }

    public class SoDaTea : YinLiao
    {
        public override double Cost()
        {
            Console.WriteLine("SoDa30块");
            return 30;
        }
    }

}
