using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.结构型设计模式._6_组合设计模式
{
    internal class 组合设计模式
    {
        //实现树状层级结构

        //Component 根节点
        //Composite 树枝
        //leaf 树叶 

       public void Main()
       {
            //创建一个公司节点
            Component company = new DepartComposite("大厂");
            //创建部门
            Component dep1 = new DepartComposite("总裁办");
            //创建员工
            Component boos = new DepartComposite("孙权");

            company.Add(dep1);
            dep1.Add(boos);

            company.Display(3);
        }

    }

    /// <summary>
    /// 定义了子类中公有的成员
    /// </summary>
    public abstract class Component
    {
        public string Name { get; set; }

        public Component(string name)
        {
            Name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }

    /// <summary>
    /// 就是我们的部门类，树枝
    /// </summary>
    public class DepartComposite : Component
    {
        public DepartComposite(string name) : base(name)
        { }

        List<Component> components = new List<Component>();

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);

            foreach(Component component in components)
            {
                //增加这个4仅仅是为了好看
                component.Display(depth + 4);
            }

        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        /// <summary>
        /// 叶子节点
        /// </summary>
        public class Empolyee : Component
        {
            public Empolyee(string name) : base(name)
            {

            }

            public override void Add(Component component)
            {
                throw new NotImplementedException();
            }

            public override void Display(int depth)
            {
                Console.WriteLine(new string ('-', depth) + this.Name);
            }

            public override void Remove(Component component)
            {
                throw new NotImplementedException();
            }
        }
    }



}
