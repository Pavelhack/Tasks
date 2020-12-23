using System;

namespace Task_1
{

    public class Person
    {
        // getter account
        private  string account;
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
        private  int dayMoney;
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
        private int transport;
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
        private  int days;
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
        public int total()
        {
            return transport + days * dayMoney;  
        }

        // show info line by line  
        public string Show()
        {

            return ($"Имя: {account}\n расходы в день: {dayMoney}\n транспортные расходы: {transport}\n продолжительность командировки: {days}");

        }


        // show info in line
        //public override string ToString()
        //{
        //    return ($"Имя: {account}  rate: {dayMoney} transtprt: {transport} days: {days}");
        //}

       
        
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

            //Person.Show(people);


            foreach (Person key in people)
            {
                //Console.WriteLine($"Имя: {account}\n расходы в день: {dayMoney}\n транспортные расходы: {transport}\n продолжительность командировки: {days}");
                if (key == null) { }
                else
                {
                    Console.WriteLine(key.Show());
                }
            }

            // Console.WriteLine(Person.total());

            //Person tom = new Person();

            int lastIndex = people.Length - 1;

            Person lastObject = people[lastIndex];

            lastObject.Transport = 700;

            Console.WriteLine(lastObject.Transport);

        }


    }
}
