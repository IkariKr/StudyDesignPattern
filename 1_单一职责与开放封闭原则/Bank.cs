using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern._1_单一职责与开放封闭原则
{
    public class BankClient
    {
        public string BankType { get; set; }

    }


    public class BankStuff
    {
        private BankProcess bankProcess = new BankProcess();
        public void HandleProcess(BankClient bankClient)
        {
            switch (bankClient.BankType)
            {
                case "存款":
                    new BankProcess().Deposite();
                    break;
                case "取款":
                    new BankProcess().DrawMoney();
                    break;
                case "转账":
                    new BankProcess().Transfer();
                    break;
                default:
                    Console.WriteLine("暂时无法处理您的需求");
                    break;
            }
             
        }
    }

    public class BankProcess
    {
        public void Deposite()
        {
            Console.WriteLine("存款");
        }

        public void DrawMoney()
        {
            Console.WriteLine("取款");
        }

        public void Transfer()
        {
            Console.WriteLine("转账");
        }
    }

}
