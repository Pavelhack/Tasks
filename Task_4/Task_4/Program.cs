using System;

namespace Task_4
{
    public class Market : IComparable<Market>
    {
        public string Title { get; set; }

        public double Cost { get; set; }

        public int Amount { get; set; }

        public double GetCost()
        {
            return Amount * Cost;
        }

        public override string ToString()
        {
           return $"Name of item: {Title}; Cost of item: {Cost}; Amount of items{Amount}; Total summ: {GetCost()}"; 
        }

        public int Equals(Market X, Market Y)
        {
            return X.CompareTo(Y);
        }
        public int CompareTo(Market I)
        {
            Market p = I;
            int first =  Cost.CompareTo(p.Cost);
            int second =  Title.CompareTo(p.Title);
             if (first == second) {
                return 1;
             } else{
                return 0;
            } 
        }

        
    }
    public class Discont : Market 
    {
        
    }
    public class Goods : Market
    {

    }
    class Program
    {
        static void Main(string[] args)
        {   
            Market[] purchases = new Market[] {
                  new Market{Title = "X-Box", Cost =  740.90, Amount = 6},
                  new Market{Title = "X-Box2", Cost =  980.30, Amount =  4},
                  new Discont{Title = "netbook",Cost =  300.44, Amount = 5 },
                  new Discont{Title = "iphone",Cost =  500.65, Amount =  2 },
                  new Goods{Title = "macbook",Cost =  800.85, Amount =  4 },
                  new Goods{Title = "PS",Cost =  750, Amount =  8 },
            };

        }
    }
}
