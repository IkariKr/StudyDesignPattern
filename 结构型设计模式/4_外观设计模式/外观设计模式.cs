using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.结构型设计模式._4_外观设计模式
{
    public class 外观设计模式
    {
        //隐藏了系统的复杂性，并向客户端提供了可以访问系统的统一接口，这个接口组合了子系统的多个接口，使子系统更容易被访问和使用。
        class MainClass
        {
            public static void Main()
            {

            }
        }

        public class DaTing
        {
            Hospital Hospital = new Hospital();
            Police Police = new Police();
            Street Street = new Street();
        }

        public class Hospital
        {

        }

        public class Police
        {

        }

        public class Street
        {

        }
    
    
    }
}
