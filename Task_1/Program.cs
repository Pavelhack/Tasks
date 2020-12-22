using System;

namespace Task_1
{

    public class Person
    {
        // getter account
        private static string account;
        public string Account
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
            }
        }

        //getter dayMoney
        private static int dayMoney;
        public  int DayMoney
        {
            get
            {
                return dayMoney;
            }
            set
            {
                dayMoney = value;
         
            }
        }
        // getter transport
        private static int transport;
        public int Transport
        {
            get
            {
                return transport;
            }
            set
            {
                transport = value;
            }
        }

        // getter days
        private static int days;
        public  int Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }

        // constuctor Person
        public Person() { account = "Mister"; dayMoney = 2500; transport = 500; days = 5; }
        public Person(string n) { account = n; dayMoney = 2500; transport = 500; days = 5; }
        public Person(string n, int d) { account = n; dayMoney = 2500; transport = 500; days = d; }


        // total sum
        public static int total()
        {
            return transport + days * dayMoney;  
        }

        // show info line by line  
        public static void Show(object[] arr)
        {
            foreach(object key in arr)
            {
                //Console.WriteLine($"Имя: {account}\n расходы в день: {dayMoney}\n транспортные расходы: {transport}\n продолжительность командировки: {days}");
                
                Console.WriteLine(key);


            }
            
            
        }

        // show info in line
        public static void ShowString()
        {
            Console.WriteLine($"Имя: {account}  rate: {dayMoney} transtprt: {transport} days: {days}");
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Write array
            Person[] people = new Person[5];
            
            Person Bill = new Person( "Bill",  3);

            people[0] = Bill;

            Person Jon = new Person("Jon", 5);

            people[1] = Jon;

            people[2] = null;

            Person Trump = new Person("Trump", 7);

            people[3] = Trump;

            Person Five = new Person();

            people[4] = Five;




            // Person.ShowString();

            Person.Show(people);

            // Console.WriteLine(Person.total());

            //Person tom = new Person();
            
        }


    }
}
