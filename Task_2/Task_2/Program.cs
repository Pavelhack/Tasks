using System;

namespace Task_2
{
    class Substance
    {
        private static string matter ;
        private static double density ;
        


        //getter matterOxygen
        public static string Matter
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

        //getter density
        public static double Density
        {
            get
            {
                return density;
            }

            set
            {
                density = value;
            }
        }

        //Constructor
        public  Substance() { Matter = "oxygen"; Density = 1.429; }

        public Substance ( string n, double d) { Matter = n; Density = d;}

        public override string ToString()
        {
            return ($" matter : {Matter};  density of oxygen : {Density}");
        }
    }

    public class Material
    {
        public string nameSubstance = Substance.Matter;

        public double densitySubstance = Substance.Density;


        private double Volume;

        private string NameMaterial;

        public double volume
        {
            get
            {
                return Volume;
            }

            set
            {
                Volume = value;
            }
        }

        public string nameMaterial
        {
            get
            {
                return NameMaterial;
            }

            set
            {
                NameMaterial = value;
            }
        }

        public Material() { nameMaterial = "water"; volume = 1; }
        public Material(string n, double x) { nameMaterial = n; volume = x;}

        //static Material Item = new Material();

        public double GetMass()
        {   
                return densitySubstance * volume;
        }

        public override string ToString()
        {
            return ($"substance: {nameSubstance} density:{densitySubstance}  material: {nameMaterial} mass: {GetMass()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ToString from class Suvstance
            Substance.Matter = "steel";
            Substance.Density = 7.750;

            // ToString from class Material
            Material Item2 = new Material("wire", 0.03 );
            Console.WriteLine(Item2);

            Substance.Matter = "copper";
            Substance.Density = 8.96;

            Material Item3 = new Material("wire", 0.03);
            Console.WriteLine(Item3);

        }
    }
}
