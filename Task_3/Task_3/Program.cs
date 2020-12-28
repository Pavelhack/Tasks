using System;

namespace Task_3
{
    class Purchase: IComparable 
    {
        private string NameItem { get; set; }
        public double Cost { get; set; }
        public int Amount { get; set; }
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

        // constructor
        public Purchase(){}

        public Purchase(string N, double C, int A) { NameItem = N; Cost = C; Amount = A;}

        public double GetCost()
        {
            return Amount * Cost;
        }
        public override string ToString()
        {
            return ($"Name of product: {NameItem} Cost of product: {Cost}  Amount total: {Amount} summ total: {GetCost()}");
        }

        public int CompareTo(object obj)
        {
            Purchase p = obj as Purchase;

            Console.WriteLine(p.Cost);
            Console.WriteLine(Cost);
            if (p != null)
                return Cost.CompareTo(p.Cost);
            else
            throw new Exception("unpossible compare both objects");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Purchase ObjOne = new Purchase("netbook", 300.44, 3);
            Purchase ObjTwo = new Purchase("iphone", 500.65, 2);
            
            Console.WriteLine(ObjOne.CompareTo(ObjTwo));
        }
    }
}
