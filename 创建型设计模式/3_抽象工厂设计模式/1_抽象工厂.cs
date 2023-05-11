using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.创建型设计模式._3_抽象工厂设计模式
{
    public class _1_抽象工厂设计模式实现
    {
        //将工厂生产的产品归类，放在同一个工厂里



    }

    public interface IKeyboard
    {
        void ShowKeyboardBrand();
    }

    public interface IMouse
    {
        void ShowMouseBrand();
    }

    public class DellKeyboard : IKeyboard
    {
        public void ShowKeyboardBrand()
        {
            Console.WriteLine("DellKeyboard");
        }
    }

    public class HPKeyboard : IKeyboard
    {
        public void ShowKeyboardBrand()
        {
            Console.WriteLine("HPKeyboard");
        }
    }

    public class LenovoKeyboard : IKeyboard
    {
        public void ShowKeyboardBrand()
        {
            Console.WriteLine("LenovoKeyboard");
        }
    }

    public class DellMouse : IMouse 
    {
        public void ShowMouseBrand()
        {
            Console.WriteLine("DellMouse");
        }
    }

    public class HPMouse : IMouse
    {
        public void ShowMouseBrand()
        {
            Console.WriteLine("HPMouse");
        }
    }

    public class LenovoMouse : IMouse
    {
        public void ShowMouseBrand()
        {
            Console.WriteLine("LenovoMouse");
        }
    }

    public interface IAbastractFactory
    {
        IKeyboard GetIkeyboard();
        IMouse GetMouse() ;
    }

    public class DellFactory : IAbastractFactory
    {
        public IKeyboard GetIkeyboard()
        {
            return new DellKeyboard();
        }

        public IMouse GetMouse()
        {
            return new DellMouse();
        }
    }

}

