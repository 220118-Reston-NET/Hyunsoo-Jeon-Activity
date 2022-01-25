namespace CarFunction {

    public class Car 
    {
        private string _color;
        private int _fuel;
        private int _gallonPerMile;

        public string Color {
            get {
                return "The color is " + _color;
            }
            set {
                _color= value;
            }
        }

        private string _owner;
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        
        public int Fuel{
            get;
            set;
        }
        
        // polymorphism , overriding
        public void Start(){
            Console.WriteLine("the car is starting right now!");
            Console.WriteLine($"Current fule is : {Fuel}");
        }

        public void Start(int p_fuel){
            Fuel = p_fuel;
            Console.WriteLine("the car is starting right now!");
            Console.WriteLine($"Current fule is : {Fuel}");

        }

        //Constructor
        // it is a special method that will run first whenever you create an object out of that class
        public Car(){
            _color = "Blue";
            _gallonPerMile = 10;
            _owner = "Nobody";
            Fuel=100;
        }

        //will give the total distance 
        public double TotalDistance(){
            return (double)Fuel / _gallonPerMile;
        }
    }


}