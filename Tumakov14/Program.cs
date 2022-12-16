using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Tumakov14
{
    class Program
    {
        static void Main()
        {
            ex2();
        }

        public static void ex1()
        {
            Console.WriteLine("В классе банковский счет добавить метод DumpToScreen, который отображает детали банковского счета.");
            BankAccount acc1 = new BankAccount(123, 5000, BankAccount.AccType.Saving);
            BankAccount acc2 = new BankAccount(124, 123, BankAccount.AccType.Current);
            acc1.DumpToScreen();

        }

        public static void ex2()
        {
            Console.WriteLine("Создать пользовательский атрибут DeveloperInfoAttribute." +
                "Этот атрибут позволяет хранить в метаданных класса имя разработчика и, дополнительно, дату разработки класса." +
                "Атрибут должен позволять многократное использование.");

            System.Reflection.MemberInfo info;
            info = typeof(BankAccount);
            object[] attribute = info.GetCustomAttributes(false);
            foreach (object a in attribute) 
            {
                DeveloperInfoAttribute attr = (DeveloperInfoAttribute)a;
                Console.WriteLine($"Developer: {attr.Developer}\nDate: {attr.Date}");
            }
        }

    }
}
