using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace StudyDesignPattern.创建型设计模式._2_工厂设计模式
{
    //1.使用Attribute给代码上特性
    public class OperToFactory : Attribute
    {
        public string Oper { get; }//因为值是我们直接写好，贴到类上，故不需要提供Set方法
        public OperToFactory(string s)
        {
            this.Oper = s;
        }
    }

    //2、程序运行后，拿到这段描述关系，并且返回相应的对象
    public class ReflectionFactory
    {
        //根据用户输入（操作符），返回一个对象
        Dictionary<string, ICalFactory> dic = new Dictionary<string, ICalFactory>();

        public ReflectionFactory()
        {
            //1、拿到当前正在运行的程序集
            Assembly assembly = Assembly.GetExecutingAssembly();
            //Add OperFactory 
            foreach(var item in assembly.GetTypes())
            {
                // IsAssignableFrom type is item or type inherit item
                if (typeof(ICalFactory).IsAssignableFrom(item) && !typeof(ICalFactory).IsInterface)
                {
                    OperToFactory operToFactory = item.GetCustomAttribute<OperToFactory>();
                    if(operToFactory is null)
                    {
                        dic.Add(operToFactory.Oper, Activator.CreateInstance(item) as ICalFactory);
                    }
                }
            }
        }

        public ICalFactory GetFatory(string s)
        {
            if (dic.ContainsKey(s))
            {
                return dic[s];
            }

            return null;
          
        }

    }


    public interface ICalFactory
    {
        ICalculator GetCalCulator();
    }

    [OperToFactory("+")]
    public class AddFactory : ICalFactory
    {
        public ICalculator GetCalCulator()
        {
            return new Add();
        }

    }

    [OperToFactory("-")]
    public class SubFactory : ICalFactory
    {
        public ICalculator GetCalCulator()
        {
            return new Sub();
        }

    }

    [OperToFactory("*")]
    public class MulFactory : ICalFactory
    {
        public ICalculator GetCalCulator()
        {
            return new Mul();
        }

    }

    [OperToFactory("/")]
    public class DivFactory : ICalFactory
    {
        public ICalculator GetCalCulator()
        {
            return new Div();
        }

    }


    public interface ICalculator
    {
        public double GetResult(double x, double y);
    }

    public class Add : ICalculator
    {
        public double GetResult(double x, double y)
        {
            return x + y;
        }
    }

    public class Sub : ICalculator
    {
        public double GetResult(double x, double y)
        {
            return x - y;
        }
    }

    public class Mul : ICalculator
    {
        public double GetResult(double x, double y)
        {
            return x * y;
        }
    }

    public class Div : ICalculator
    {
        public double GetResult(double x, double y)
        {
            return x / y;
        }
    }

}
