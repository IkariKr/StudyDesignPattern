// See https://aka.ms/new-console-template for more information




using StudyDesignPattern._1_单一职责与开放封闭原则.UsePattern;

using StudyDesignPattern._2_依赖倒置原则.usePattern;

#region 1_单一职责与开放封闭原则.UsePattern;

IBankClient bankClient = new DepositeClient();
BankStuff bankStuff = new BankStuff();
bankStuff.HandleProcess(bankClient);

#endregion

Console.WriteLine("----------------------------------------");

#region 2_依赖倒置原则.usePattern;

Singer singer = new Singer();
singer.SingSong(new ChineseSong());

#endregion




