using System;

namespace Task_2
{
    class Substance
    {
        private string matter ;
        private double density ;
        


        //getter matterOxygen
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

        //getter density
        public double Density
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
        public  Substance() {}

        public Substance ( string n, double d) { Matter = n; Density = d;}

        public override string ToString()
        {
            return ($" matter : {Matter};  density of oxygen : {Density}");
        }
    }

    public class Material
    {
        public string nameSubstance;

        public double densitySubstance;

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

        public Material() {}
        public Material(string n, double x,  double d, string s) { nameMaterial = n; volume = x; densitySubstance = d; nameSubstance = s; }

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

            Substance Item = new Substance("steel", 7.750);

            // ToString from class Material
            Material Item2 = new Material("wire", 0.03, Item.Density, Item.Matter );
            Console.WriteLine(Item2);

            Item.Matter = "copper";
            Item.Density = 8.96;

            Material Item3 = new Material("wire", 0.03, Item.Density, Item.Matter);
            Console.WriteLine(Item3);

        }
    }
}
