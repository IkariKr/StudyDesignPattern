using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.结构型设计模式._3_代理设计模式
{
    public class 代理设计模式
    {
        public void Main()
        {
            ClassFlower classFlower = new ClassFlower();
            classFlower.Name = "海绵宝宝";

            //创建代理对象
            ISubject subject = new Proxy(new RealSubject(classFlower));

            subject.GiveSmoking();
            subject.GiveBeer();
            subject.GiveJK();
        }

    }

    public class Proxy : ISubject
    {
        private ISubject realSubject;

        public Proxy(ISubject realSubject)
        {
            this.realSubject = realSubject;
        }

        public void GiveBeer()
        {
            realSubject.GiveBeer();
        }

        public void GiveJK()
        {
            realSubject.GiveJK();
        }

        public void GiveSmoking()
        {
            realSubject.GiveSmoking();
        }
    }

    public interface ISubject
    {
        void GiveSmoking();
        void GiveBeer();
        void GiveJK();
    }

    public class ClassFlower
    {
        public string Name { get; set; }
    }

    public class RealSubject : ISubject
    {
        private ClassFlower _classFlower;

        public RealSubject(ClassFlower classFlower)
        {
            _classFlower = classFlower;
        }

        public void GiveBeer()
        {
            Console.WriteLine(this._classFlower.Name + "同学请你喝酒");
        }

        public void GiveJK()
        {
            Console.WriteLine(this._classFlower.Name + "同学请你JK");
        }

        public void GiveSmoking()
        {
            Console.WriteLine(this._classFlower.Name + "同学请你抽烟");
        }
    }



}
