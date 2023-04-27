// See https://aka.ms/new-console-template for more information


#region 1_单一职责与开放封闭原则.UsePattern;

using StudyDesignPattern._1_单一职责与开放封闭原则.UsePattern;



IBankClient bankClient = new DepositeClient();
BankStuff bankStuff = new BankStuff();
bankStuff.HandleProcess(bankClient);

#endregion






