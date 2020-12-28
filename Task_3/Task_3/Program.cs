using System;

namespace Task_3
{
    class Purchase: IComparable 
    {
        private string nameItem = "B";

        //public string NameItem { get; set; }
        public string NameItem
        {
            get
            {
                return NameItem = nameItem;
            }
            set
            {
                nameItem = value;
            }

        }


        // constructor
        public Purchase(string nameItem){ this.NameItem = nameItem; }

        public int CompareTo(object obj)
        {
            Console.WriteLine(this.nameItem);
            
            Purchase p = obj as Purchase;
            if (p != null)
                return this.nameItem.CompareTo(p.nameItem);
            else
            throw new Exception("unpossible compare both objects");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Purchase O = new Purchase("nameItem@");
            Console.WriteLine(O.NameItem);
            Console.WriteLine(O.CompareTo(O));
        }
    }
}
