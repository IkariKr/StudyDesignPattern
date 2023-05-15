using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.结构型设计模式._3_代理设计模式
{
    public class 代理设计模式应用
    {

    }

    public class ProxyOrder : IOrder
    {
        private RealOrder realOrder;

        public ProxyOrder(RealOrder realOrder)
        {
            this.realOrder = realOrder;
        }

        public int GetOrderNum()
        {
            return realOrder.GetOrderNum();
        }

        public string GetOrderUser()
        {
            throw new NotImplementedException();
        }

        public string GetProductName()
        {
            throw new NotImplementedException();
        }

        public void SetOrderNum(int count, string user)
        {
            //权限判断
            if(user !=null && user.Equals(this.realOrder.User))
            {
                this.realOrder.SetOrderNum(count, user);
            }
            else
            {
                Console.WriteLine("您无权修改此数据");
            }
        }

        public void SetOrderUser(string orderUserName, string user)
        {
            //权限判断
            if (user != null && user.Equals(this.realOrder.User))
            {

            }
            else
            {
                Console.WriteLine("您无权修改此数据");
            }
        }

        public void SetProductName(string productName, string user)
        {
            //权限判断
            if (user != null && user.Equals(this.realOrder.User))
            {

            }
            else
            {
                Console.WriteLine("您无权修改此数据");
            }
        }
    }

    public interface IOrder
    {
        string GetProductName();
        void SetProductName(string productName, string user);

        int GetOrderNum();
        void SetOrderNum(int count ,string user);

        string GetOrderUser();
        void SetOrderUser(string orderUserName, string user);

    }

    public class RealOrder : IOrder
    {
        public string ProductName
        {
            get;
            set; }
        public string User { get; set; }
        public int OrderNum { get; set; }
        public string OrderUser { get; set; }

        public RealOrder(string productName, string user, int orderNum, string orderUser)
        {
            ProductName = productName;
            User = user;
            OrderNum = orderNum;
            OrderUser = orderUser;
        }

        public int GetOrderNum()
        {
            return this.OrderNum;
        }

        public string GetOrderUser()
        {
            return this.User;
        }

        public string GetProductName()
        {
            return this.ProductName;
        }

        public void SetOrderNum(int count, string user)
        {
            this.User = user;
            this.OrderNum = count;
        }

        public void SetOrderUser(string orderUserName, string user)
        {
            this.User = user;
            this.OrderUser = orderUserName;
        }

        public void SetProductName(string productName, string user)
        {
            this.User = user;
            this.ProductName = productName;
        }
    }








}
