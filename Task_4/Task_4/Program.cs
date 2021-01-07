using System;

namespace Task_4
{
    public class Market 
    {
        public string Title { get; set; }

        public double Cost { get; set; }

        public int Amount { get; set; }

        public virtual double GetCost()
        {
            return Amount * Cost;
        }

        public override string ToString()
        {
           return $"Name of item: {Title}; Cost of item: {Cost}; Amount of items: {Amount}; Total summ: {GetCost()}"; 
        }

        public Market() { }

        public Market(string S, double D, int I) { Title = S; Cost = D; Amount = I; }

    }

    public class Discont : Market 
    {
        public override double GetCost()
        {
          return (Amount * Cost) * 85 / 100;
        }
        public Discont(string S, double D, int I) { Title = S; Cost = D; Amount = I; }

    }
    //public class Goods
    //{
    //    public int 
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Market[] purchases = new Market[] {
                  new Market("X-Box", 740.90, 6),
                  new Market("X-Box2", 980.30, 6),
                  new Discont("netbook", 300.44, 3),
                  new Discont("iphone", 500.65, 2),
                  //new Goods("macbook", 800.85, 4),
                  //new Goods("PS", 750, 8),
            };

            foreach(Market O in purchases)
            {
                Console.WriteLine(O);
            }

        }
    }
}
