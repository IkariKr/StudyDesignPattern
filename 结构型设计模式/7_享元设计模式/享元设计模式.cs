using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.结构型设计模式._7_享元设计模式
{
    public class 享元设计模式
    {
        //当系统中大量使用某些相同或者相似的对象，这些对象会消耗大量的资源，
        //并且这些对象剔除外部状态后可以通过用一个对象来替代，这时可以使用享元设计模式

        //内部状态：对象内部不受环境改变的部分作为内部桩号
        //外部状态：随着环境的变化而变化的部分。

        //运用共享技术有效的支持大量细粒度的对象

        //优点：通过对象的复用，减少了对象的数量，节省内存
        //缺点：需要分类对象内部和外部的状态，提高了系统的复杂度

        public void Main()
        {
            BikeFactory bikeFactory = new BikeFactory();

            FlyWeightBike flyWeightBike1 = bikeFactory.GetBike();
            flyWeightBike1.Ride("张三");
            flyWeightBike1.Back("张三");

            FlyWeightBike flyWeightBike2 = bikeFactory.GetBike();
            flyWeightBike2.Ride("李四");

            FlyWeightBike flyWeightBike3 = bikeFactory.GetBike();
            flyWeightBike3.Ride("王五");
        }

    }

    public class BikeFactory
    {
        List<FlyWeightBike> bikePool = new List<FlyWeightBike>();
        public BikeFactory()
        {
            for(int i = 0; i < 3; i++)
            {
                bikePool.Add(new YelloBike(i.ToString()));
            }
        }

        public FlyWeightBike GetBike()
        {
            for(int i = 0; i < bikePool.Count; i++)
            {
                if (bikePool[i].State == 0)
                {
                    return bikePool[i];
                }
            }

            return null;
        }

    }


    public abstract class FlyWeightBike
    {
        //内部状态：BikeID State - 0 锁定中 1 -- 骑行中
        //外部状态：用户 

        public string BikeID { get; set; }
        public int State { get; set; }
        public abstract void Ride(string UserName);

        public abstract void Back(string UserName);

    }

    public class YelloBike : FlyWeightBike
    {
        public YelloBike(string BikeID)
        {
            this.BikeID = BikeID;
        }


        public override void Ride(string UserName)
        {
            this.State = 1;
            Console.WriteLine("用户"+UserName+"正在骑行ID是"+this.BikeID);
        }

        public override void Back(string UserName)
        {
            this.State = 0;
            Console.WriteLine("用户"+UserName+"归还了ID是"+this.BikeID);
        }
    }
}
