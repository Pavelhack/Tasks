using System;

namespace Task_2
{
    class Substance
    {
        private string matterOxygen ;
        private double dansityOxygen ;
        private string matterHydrogen;
        private double dansityHydrogen;


        //getter matterOxygen
        public string MatterOxygen
        {
            get
            {
                return matterOxygen;
            }

            set
            {
                matterOxygen = value;
            }
        }

        //getter matterHydrogen
        public string MatterHydrogen
        {
            get
            {
                return matterHydrogen;
            }

            set
            {
                matterHydrogen = value;
            }
        }

        //getter dansityOxygen
        public double DansityOxygen
        {
            get
            {
                return dansityOxygen;
            }

            set
            {
                dansityOxygen = value;
            }
        }

        //getter dansityOxygen
        public double DansityHydrogen
        {
            get
            {
                return dansityHydrogen;
            }
            set
            {
                dansityHydrogen = value;
            }
        }

        //Constructor
        public Substance() { matterOxygen = "oxygen"; dansityOxygen = 1.429; matterHydrogen = "hydrogen"; dansityHydrogen = 0.0696; }

        public Substance (string n, double d, string h, double x) { matterOxygen = n; dansityOxygen = d; matterHydrogen = h; dansityHydrogen = x; }


        public override string ToString()
        {
            return ($" matter : {MatterOxygen};  dansity of oxygen : {DansityOxygen} \n other matter : {MatterHydrogen}; density of hydrogen : {DansityHydrogen}");
        }
    }

    class Homogeneous_Material
    {
        public string Water = "water";
        public Substance Item = new Substance();
        public enum Volume {centimeter = 1};

        //getter for Volume
        public class Getter
        {
            public Volume volume;
            public void SetVolume(Volume value)
            {
                volume = value;
            }

            public Volume GetVolume()
            {
               return volume;
            }
        }

        public double GetMass()
        {
            public Volume digital = Volume.centimeter;
            public double mass = (Item.DansityOxygen + Item.DansityHydrogen) * digital
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Substance Item = new Substance();
            Console.WriteLine(Item);
        }
    }
}
