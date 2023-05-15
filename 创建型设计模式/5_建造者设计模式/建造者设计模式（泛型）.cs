using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.创建型设计模式._5_建造者设计模式
{
    public class 建造者设计模式_泛型_
    {

    }

    public interface IBuild<T>
    {
        T Get<T>();
    }

    public interface IDirector<T>
    {
        //泛型可以限制为某一个具体的接口，或者引用类型，但无法限制为接口类型
        void BuildSequence(T build);
    }

    public interface IBuildComputer : IBuild<Computer>
    {
        void BuildCpu();
        void BuildDisk();
        void BuildMemory();
        void BuildScreen();
        void BuildSystem();
    }


    public class Directer : IDirector<IBuildComputer>
    {
        public void BuildSequence(IBuildComputer build)
        {
            build.BuildCpu();
            build.BuildDisk();
            build.BuildMemory();
            build.BuildScreen();
            build.BuildSystem();
        }
    }



}
