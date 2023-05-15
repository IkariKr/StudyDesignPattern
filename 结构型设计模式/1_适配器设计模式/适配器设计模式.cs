using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.结构型设计模式._1_适配器设计模式
{
    /// <summary>
    /// 转接器
    /// </summary>
    public class 适配器设计模式
    {
        public void Main()
        {
            IPhoneCharge phoneCharge = new PhoneChargeAdapter();
            phoneCharge.PhoneCharge();
        }

        
    }

    public class AndroidChargeAdaptee
    {
        public void AndroidCharge()
        {
            Console.WriteLine("安卓充电线充电");
        }
    }

    public interface IPhoneCharge
    {
        void PhoneCharge();
    }

    public class PhoneChargeAdapter : IPhoneCharge
    {
        //在Adapter中，封装了一个Adaptee对象，这个对象才是实现功能的对象
        private AndroidChargeAdaptee androidChargeAdaptee = new AndroidChargeAdaptee();
        public void PhoneCharge()
        {
            androidChargeAdaptee.AndroidCharge();
        }
    }
}
