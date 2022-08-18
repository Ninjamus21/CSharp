using System;

namespace Store {
    class cars 
    {
        public string Name;
        public int TopSpeed;
        public string Generation;
        public int Price; 
        public int Kilometers; 
        public int HorsePower;
        public string GearType;
        public float Zero_Hundred;
        public int availability;



        public cars(string _Name, int _TopSpeed, string _Generation, int _Price, int _Kilometers, int _HorsePower, string _GearType, float _Zero_Hundred, int _availability)
        {
            Name = _Name;
            TopSpeed = _TopSpeed;
            Generation = _Generation;
            Price = _Price;
            Kilometers = _Kilometers;
            HorsePower = _HorsePower;
            GearType = _GearType;
            Zero_Hundred = _Zero_Hundred;
            availability = _availability;
        }

        public void BuyCar() 
        {
            if (availability > 0)
            {
                Console.WriteLine(Name + "are in storage and we have " + availability + "left.");
            } else {
                Console.WriteLine("sadly we ran out come back later ;(");
            }
        }
    }
    class program 
    {
        static void Main(string[] args)
            {
                cars car01 = new cars("omega", 240, "1982", 1000, 10000, 240, "Automatic", 2.7f, 1);

                car01.BuyCar();

                // Wait for console so it dont quick close
                Console.ReadKey();
            }
    }
}



