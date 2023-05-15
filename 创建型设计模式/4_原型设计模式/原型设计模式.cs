using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.创建型设计模式._4_原型设计模式
{
    public class 原型设计模式
    {
        //原型模式：方便我们创建多个对象，并且节约效率

    }

    /// <summary>
    /// 对于非值类型，需要每一个类都继承ICloneable，对于很复杂的类，就很复杂
    /// </summary>
    public class Resume :ICloneable
    {
        public string Name { get; set; }
        public Resume(string name) 
        {
            this.Name = name;
        }
    
        object ICloneable.Clone()
        {
            //MemberwiseClone 浅克隆
            return this.MemberwiseClone() ;
        }
    }

}
