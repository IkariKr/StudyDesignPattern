using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern._1_单一职责与开放封闭原则.UsePattern
{
    public interface IBankClient
    {
        IBankProcess GetBankProcess();
    }

    public class DepositeClient : IBankClient
    {
        public IBankProcess GetBankProcess()
        {
            return new Deposite();
        }
    }

    public class DrawMoneyClient : IBankClient
    {
        public IBankProcess GetBankProcess()
        {
            return new DrawMoney();
        }
    }

    public class TransferClient : IBankClient
    {
        public IBankProcess GetBankProcess()
        {
            return new Transfer();
        }
    }

    public class BuyFundClient : IBankClient
    {
        public IBankProcess GetBankProcess()
        {
            return new BuyFund();
        }
    }


    public class BankStuff
    {
        private IBankProcess bankProcess;
        public void HandleProcess(IBankClient bankClient)
        {
            bankProcess = bankClient.GetBankProcess();
            bankProcess.BankProcess();
        }
    }


    public interface IBankProcess
    {
        void BankProcess();
    }

    public class Deposite : IBankProcess
    {
        public void BankProcess()
        {
            Console.WriteLine("存款");
        }
    }

    public class DrawMoney : IBankProcess
    {
        public void BankProcess()
        {
            Console.WriteLine("取款");
        }
    }

    public class Transfer : IBankProcess
    {
        public void BankProcess()
        {
            Console.WriteLine("转账");
        }
    }

    public class BuyFund : IBankProcess
    {
        public void BankProcess()
        {
            Console.WriteLine("买基金");
        }
    }
}
