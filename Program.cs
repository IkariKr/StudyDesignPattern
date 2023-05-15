// See https://aka.ms/new-console-template for more information




using StudyDesignPattern._1_单一职责与开放封闭原则.UsePattern;

using StudyDesignPattern._2_依赖倒置原则.usePattern;
using StudyDesignPattern.创建型设计模式._1_单利设计模式_懒汉式;
using StudyDesignPattern.结构型设计模式._2_装饰器设计模式;
using StudyDesignPattern.结构型设计模式._3_代理设计模式;
using System.Reflection;

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

#region 单例设计模式

//for (int i = 0; i < 10; i++)
//{
//    new Thread(()=>LazyManSingle.GetLazyManSingle()).Start();
//}


//2. 通过反射来破坏单例
LazyManSingle lazy1 = LazyManSingle.GetLazyManSingle();

Type type = Type.GetType("StudyDesignPattern.创建型设计模式._1_单利设计模式_懒汉式.LazyManSingle");
//获取私有构造函数
ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);

//创建完成之后，在私有的构造函数中，标记位已经被改变成了True
//如果想通过反射来进行破坏，我们需要拿到私有的标记字段，把值在调用第二个构造函数之前，改为false
FieldInfo fieldInfo = type.GetField("isOK", BindingFlags.NonPublic | BindingFlags.Static);
fieldInfo.SetValue("isOK", false);

//执行构造函数
LazyManSingle lazy2 = constructors[0].Invoke(null) as LazyManSingle;


//反射破坏单例
Console.WriteLine(lazy1.GetHashCode());
Console.WriteLine(lazy2.GetHashCode());

fieldInfo.SetValue("isOK", false);

//多次反射抛异常
LazyManSingle lazy3 = constructors[0].Invoke(null) as LazyManSingle;
Console.WriteLine(lazy3.GetHashCode());

Console.ReadKey();


#endregion

#region 装饰器设计模式

装饰器设计模式 main = new 装饰器设计模式();
main.Main();

#endregion

#region 代理设计模式

代理设计模式 proxyMain = new 代理设计模式();
proxyMain.Main();

#endregion


