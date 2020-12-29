using System;

namespace Task_3
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Purchase : IComparable<Purchase>
    {
        public Days days = new Days();
        public string NameItem { get; set; }

        //private const string nameItem = NameItem;
        public double Cost { get; set; }
        public int Amount { get; set; }
        

        // constructor
        public Purchase() { }

        public Purchase(string N, double C, int A, Days D) { NameItem = N; Cost = C; Amount = A; days = D;}

        public double GetCost()
        {
            return Amount * Cost;
        }
        public override string ToString()
        {
            return $"Name of product: {NameItem} Cost of product: {Cost}  Amount total: {Amount} day : {days} summ total: {GetCost()}";
        }

        public int CompareTo(Purchase I)
        {
            Purchase p = I;
            Console.WriteLine(p.Cost);
            Console.WriteLine(Cost);
                return Cost.CompareTo(p.Cost);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Purchase[] purchases = new Purchase[] {
                  new Purchase("netbook", 300.44, 3, Days.Monday),
                  new Purchase("iphone", 500.65, 2, Days.Thursday),
                  new Purchase("macbook", 800.85, 4, Days.Tuesday),
                  new Purchase("PS", 750, 8, Days.Wednesday),
                  new Purchase("X-Box", 740.90, 6, Days.Sunday),
            };

            foreach(object O in purchases)
            {
                Console.WriteLine(O);
            }
           //Arrays.sort(purchases)
        }
    }
}
