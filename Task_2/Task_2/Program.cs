using System;

namespace Task_2
{
    class Substance
    {
        private string matter ;
        private double dansity ;

        //getter matter
        public string Matter
        {
            get
            {
                return matter;
            }

            set
            {
                matter = value;
            }
        }

        //getter dansity
        public double Dansity
        {
            get
            {
                return dansity;
            }

            set
            {
                dansity = value;
            }
        }

        //Constructor
        public Substance() { matter = "oxygen"; dansity = 1.429; }

        public Substance (string n, double d) { matter = n; dansity = d;}


        public override string ToString()
        {
            return ($"matter : {Matter}:  dansity : {Dansity}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Substance Item = new Substance();
            Console.WriteLine(Item) ;
        }
    }
}
