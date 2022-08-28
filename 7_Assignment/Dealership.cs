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
                Console.WriteLine(Name + " are in storage and we have " + availability + " left.");
            } else {
                Console.WriteLine("sadly we ran out come back later ;(");
            }
        }
    }
    class CarDealership
    {
        public string actions;
        public CarDealership(string _actions) 
        {
            actions = _actions;
        }
        public void Entry()
        {
            Console.WriteLine("Hello, Welcome to my humble CarDealership, with over 50% high end cars");
        }
        public void ReEntry()
        {
            Console.WriteLine("Is there any thing else i can help with?");
         
        }
        public void Inspect_car()
        {
            Console.WriteLine("What cars are you interested in? ");
            Console.Write("1. Porshe, 2. Mercedes, 3. Audi or 4. BMW?");
        
        }
  
    class program 
    {
        static void Main(string[] args)
            {
                
                Console.Title = "CarDealership";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WindowHeight = 40;

            #region Porsche
            
                cars car01 = new cars("Porsche Taycan", 230, "2021", 819900, 0, 326, "Automatic", 5.4f, 1);
                cars car02 = new cars("Porshe Macan Turbo", 266, "2013", 749900, 98000, 400, "Automatic", 4.8f, 1);
                cars car03 = new cars("Porsche 911 Targa 4 GTS", 307, "2022", 3453427, 0, 480, "Automatic", 3.5f, 1);
            #endregion porsche
            #region Mercedes
            
                cars car04 = new cars("Mercedes A180", 190, "2014", 169900, 111800, 109, "Automatic", 11.6f, 1);
                cars car05 = new cars("Mercedes S560", 250, "2018", 2299900, 11000, 469, "Automatic", 4.6f, 1);
                cars car06 = new cars("Mercedes E220 d", 240, "2019", 457000, 65000, 194, "Automatic", 7.3f, 1);
            #endregion Mercedes
            #region Audi
            
                cars car07 = new cars("Audi A3", 203, "2008", 59900, 180000, 125, "Automatic", 9.5f, 2);
                cars car08 = new cars("Audi SQ5", 250, "2018", 719000, 51000, 354, "Automatic", 5.4f, 1); 
                cars car09 = new cars("Audi e-tron GT", 245, "2022", 1084900, 1000, 476, "Automatic", 4.1f, 1);
            #endregion Audi
            #region BMW
            
                cars car10 = new cars("BMW 320d", 230, "2014", 184900, 186000, 184, "Automatic", 7.6f, 1);
                cars car11 = new cars("BMW X6", 236, "2012", 459500, 114000, 304, "Automatic", 6.5f, 2);
                cars car12 = new cars("BMW iX", 200, "2022", 819000, 9000, 326, "Automatic", 6.1f, 1);
            #endregion BMW
                Console.Write(car11.Name + " TopSpeed is ");
                Console.WriteLine(car11.TopSpeed);



                // Wait for console so it dont quick close
                Console.ReadKey();
        }
    }
}
}


