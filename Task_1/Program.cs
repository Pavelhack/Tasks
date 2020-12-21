using System;
using System.Reflection;

namespace Task_1
{
    
    struct User
    {
        public const int dayMoney = 50;
        public string name;
        public string secondName;
        public int transport;
        public int day;

        public void DisplayInfo()
        {
            // Console.WriteLine($"Name:{name} SecondName:{secondName} money:{dayMoney} transport:{transport} day:{day}");
        }
    }


    public class Person
    {
        public const string account = "Anton Slutsky";
        public static int rate = 25000;
        public static int transport = 50000;
        public static int days = 5;
        public static int total = 175000;

        public static void ShowString(string somthing)
        {
            Console.WriteLine(Person.somthing);

        }

        public static void Show()
        {
            Console.WriteLine($"Имя: {account}  rate: {rate} transtprt: {transport} days: {days} total: {total}");
        }
        

    }


    class Program
    {
        static void Main(string[] args)
        {

            Type myType = typeof(Person);
            FieldInfo[] myField = myType.GetFields();
            for (int i = 0; i < myField.Length; i++)
            {
                //Type type = Person.rate.GetType();
                //Console.Write($"{type} and {myField[i]}");

                //bool p1Ep2 = myField[i].Equals(type);
                //Console.Write(p1Ep2);

                Type type = myField[i];
                    Person.ShowString(type);
                    

            }
           
           // Person.Show();

            //User tom;
            //tom.name = "Tom";
            //tom.secondName = "Soer";
            //tom.day = 3;
            //tom.transport = 15;
            //tom.DisplayInfo();
            //Console.ReadKey();
        }

       
    }
}
