namespace StudyDesignPattern.创建型设计模式._2_简单工厂设计模式
{
    public class CalFactory
    {
        //1、创建对象所有的逻辑，都集合到了一个方法中，风险比较高
        public static ICalculator GetCalCulator(String oper)
        {
            ICalculator cal = null;
            switch (oper)
            {
                case "+":
                    cal = new Add();
                    break;
                case "-":
                    cal = new Sub();
                    break;
                case "*":
                    cal = new Mul();
                    break;
                case "/":
                    cal = new Sub();
                    break;
            }


            return cal;
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
