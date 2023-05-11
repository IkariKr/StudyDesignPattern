using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPattern.创建型设计模式._3_抽象工厂设计模式
{
    public class _2_抽象工厂案例
    {
        //练习：更换数据库


    }

    public class User
    {
        public string Name { get;set; }
        public int ID { get;set;}

    }

    public class Department
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }


    public interface IDatabaseUser
    {
        void InsertUser(User user);
        User GetUser(int id);
    }

    public interface IDepartment
    {
        void InsertUser(User user);
        User GetUser(int id);
    }

    public interface IFactory
    {
        IDatabaseUser GetDatabaseUser();
        IDepartment GetDepartment();
    }

    public class SqlFactory : IFactory
    {
        public IDatabaseUser GetDatabaseUser()
        {
            return new SqlServerUser();
        }

        public IDepartment GetDepartment()
        {
            return new SqlDepartment();
        }
    }

    public class MySQLFactory : IFactory
    {
        public IDatabaseUser GetDatabaseUser()
        {
            return new MySQLUser();
        }

        public IDepartment GetDepartment()
        {
            return new MySQLDepartment();
        }
    }

    public class SQLiteFactory : IFactory
    {
        public IDatabaseUser GetDatabaseUser()
        {
            return new SQLite();
        }

        public IDepartment GetDepartment()
        {
            return new SQLiteDepartment();
        }
    }



    public class SqlServerUser:IDatabaseUser
    {
        public void InsertUser(User user)
        {
            Console.WriteLine("插入了"+ user.Name);
        }

        public User GetUser(int id)
        {
            Console.WriteLine("获取的ID是" + id);
            return null;
        }
    }

    public class SQLite : IDatabaseUser
    {
        public void InsertUser(User user)
        {
            Console.WriteLine("插入了" + user.Name);
        }

        public User GetUser(int id)
        {
            Console.WriteLine("获取的ID是" + id);
            return null;
        }
    }

    public class MySQLUser : IDatabaseUser
    {
        public void InsertUser(User user)
        {
            Console.WriteLine("插入了" + user.Name);
        }

        public User GetUser(int id)
        {
            Console.WriteLine("获取的ID是" + id);
            return null;
        }
    }

    public class SqlDepartment : IDepartment
    {
        public void InsertUser(User user)
        {
            Console.WriteLine("插入了" + user.Name);
        }

        public User GetUser(int id)
        {
            Console.WriteLine("获取的ID是" + id);
            return null;
        }
    }

    public class SQLiteDepartment : IDepartment
    {
        public void InsertUser(User user)
        {
            Console.WriteLine("插入了" + user.Name);
        }

        public User GetUser(int id)
        {
            Console.WriteLine("获取的ID是" + id);
            return null;
        }
    }

    public class MySQLDepartment : IDepartment
    {
        public void InsertUser(User user)
        {
            Console.WriteLine("插入了" + user.Name);
        }

        public User GetUser(int id)
        {
            Console.WriteLine("获取的ID是" + id);
            return null;
        }
    }








}
