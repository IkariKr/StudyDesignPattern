using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern._3_依赖注入的3种方式
{
    public interface ICar
    {
        void Run();
    }

    public interface IDrive
    {
        /// <summary>
        /// 接口注入
        /// </summary>
        /// <param name="car"></param>
        void Drive(ICar car);

        /// <summary>
        /// 构造注入
        /// </summary>
        void Drive();

        /// <summary>
        /// set注入
        /// </summary>
        void SetCar(ICar car);

    }

    public class Student : IDrive
    {
        public void Drive(ICar car)
        {
            car.Run();
        }

        private ICar _car;


        public Student(ICar car)
        {
            this._car = car;
        }

        public void Drive()
        {
            this._car.Run();
        }

        public void SetCar(ICar car)
        {
            _car = car;
        }
    }

}
