using System;

namespace Task_4
{
    public class Market : IComparable<Market>
    {
        public string Title { get; set; }

        public double Cost { get; set; }

        public int Amount { get; set; }

        public int Remainder { get; set; }

          public int CompareTo(Market I)
        {
            Market p = I;
            return GetCost().CompareTo(p.GetCost()) ;
        }

        public virtual double GetCost()
        {
            return Amount * Cost;
        }

        public override string ToString()
        {
           return $"Name of item: {Title}; Cost of item: {Cost}; purshase: {Amount}; Amount of Remainder: {Remainder}; Total summ: {GetCost()}"; 
        }

        public Market() { }

        public Market(string S, double D, int I, int R) { Title = S; Cost = D; Amount = I; Remainder = R; }

    }

    public class Discont : Market 
    {
        public override double GetCost()
        {
          return (Amount * Cost) * 85 / 100;
        }
        public Discont(string S, double D, int I, int R) { Title = S; Cost = D; Amount = I; Remainder = R; }

    }
    public class Goods : Market 
    {
        private int minItem = 3;
        
        public override double GetCost()
        {
            return minItem >= Remainder ? Amount * Cost * 80 / 100 : Amount * Cost; ;
        }
        public Goods(string S, double D, int I, int R) { Title = S; Cost = D; Amount = I; Remainder = R; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Market[] purchases = new Market[] {
                  new Market("X-Box", 740.90, 1, 2),
                  new Market("X-Box2", 980.30, 2, 5),

                  new Discont("X-Box", 740.90, 1, 2),
                  new Discont("X-Box2", 980.30, 2, 5),

                  new Goods("X-Box", 740.90, 1, 2),
                  new Goods("X-Box2",  980.30, 2, 5),
            };

            Array.Sort(purchases);

            int X;

            foreach (Market O in purchases)
            {
                X = 0;
                Console.WriteLine("{0}\n",O);
                foreach (Market I in purchases)
                {
                    if (O.GetCost().Equals(I.GetCost())&&(O.Title.Equals(I.Title))) { X++; if (X > 1) { Console.WriteLine("Same purchase is : {0}\n", O); } }
                }
            };

            Console.WriteLine("The biggest purchase is {0}\n", purchases[purchases.Length -1]);

        }
    }
}
