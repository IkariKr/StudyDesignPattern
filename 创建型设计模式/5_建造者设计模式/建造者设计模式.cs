using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.创建型设计模式._5_建造者设计模式
{
    public class 建造者设计模式
    {
        public void Main()
        {
            IBuilderComputer computer = new GoodComputer(); //创建了创建电脑的对象
            Directory directory = new Directory();//创建了指挥对象
            directory.BuldComputer(computer);

            Computer computer1 = computer.GetComparer();


        }
    }

    /// <summary>
    /// 建造接口
    /// </summary>
    public interface IBuilderComputer
    {
        //1.封装创建各个部件的过程
        //2.将创建好的复杂对象返回
        void BuildCpu();
        void BuildDisk();
        void BuildMemory();
        void BuildScreen();
        void BuildSystem();

        Computer GetComparer();

    }

    public class Directory
    {
        //稳定创建给个部件的过程
        public void BuldComputer(IBuilderComputer builderComputer)
        {
            builderComputer.BuildCpu();
            builderComputer.BuildDisk();
            builderComputer.BuildMemory();
            builderComputer.BuildScreen();
            builderComputer.BuildSystem();    
        }
    }


    public class GoodComputer:IBuilderComputer
    {
        private Computer _computer = new Computer();

        public void BuildCpu()
        {
            _computer.AddPart("i7CPU");
        }

        public void BuildDisk()
        {
            throw new NotImplementedException();
        }

        public void BuildMemory()
        {
            throw new NotImplementedException();
        }

        public void BuildScreen()
        {
            throw new NotImplementedException();
        }

        public void BuildSystem()
        {
            throw new NotImplementedException();
        }

        public Computer GetComparer()
        {
            throw new NotImplementedException();
        }
    }

    public class BadComputer : IBuilderComputer
    {
        private Computer _computer = new Computer();

        public void BuildCpu()
        {
            _computer.AddPart("i3CPU");
        }

        public void BuildDisk()
        {
            throw new NotImplementedException();
        }

        public void BuildMemory()
        {
            throw new NotImplementedException();
        }

        public void BuildScreen()
        {
            throw new NotImplementedException();
        }

        public void BuildSystem()
        {
            throw new NotImplementedException();
        }

        public Computer GetComparer()
        {
            throw new NotImplementedException();
        }
    }

    public class Computer
    {
        private List<string> listPart = new List<string>();

        public void AddPart(string part)
        {
            listPart.Add(part);
        }

        public void ShowPart()
        {
            foreach(string part in listPart)
            {
                Console.WriteLine("正在安装" + part);
            }
        }

    }




}
