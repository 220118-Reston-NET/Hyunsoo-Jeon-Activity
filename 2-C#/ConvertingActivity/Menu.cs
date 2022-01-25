using SerializationFunction;

namespace MenuFunction {
    public class Menu{

        private string _burger;
        private string _drink;
        private string _side;

        public string Burger{
            get {
                return _burger;
            }
            set {
                _burger = value;
            }
        }

        public string Drink{
            get{
                return _drink;
            }
            set{
                _drink = value;
            }
        }

        public string Side{
            get{
                return _side;
            }
            set{
                _side = value;
            }
        }

        // create list 
        public static List<string> _order = new List<string>();
        

        // press enter method
        public static void Next(){
            Console.WriteLine("Please press Enter to continue");
            Console.ReadLine();
        }

        public static void AddItem(string item){
            _order.Add(item);
            Console.WriteLine($"you have ordered {item}");
        }

        public static void DisplayCart(){
             // if array is empty
            if(_order.Count == 0){
                Console.WriteLine("your cart is empty!");
            } 
            else {
                Console.WriteLine("your order is");
                foreach(string item in _order){
                // order shows all upper case letter
                Console.WriteLine(item.ToUpper());
                }
            }
        }

        public static void RemoveItem(string removeItem){
            // if user want to remove burer
            if(removeItem == "burger"){
            // it removes elements in index 0 
            _order.RemoveAt(0);
            Console.WriteLine("your burger is removed!");
            Next();
            }
            // if user want to remove drink
            else if(removeItem == "drink"){
                // it removes elements in index 1 
                _order.RemoveAt(1);
                Console.WriteLine("your drink is removed!");
                Next();
            }
            // if user want to remove side
            else if(removeItem == "side"){
                // it removes elements in index 2 
                _order.RemoveAt(2);
                Console.WriteLine("your side is removed!");
                Next();
            }
        }

        public static void SearchItem(string searchItem){
            //if searching element is in list
            if(_order.Contains(searchItem)){
                Console.WriteLine($"you have {searchItem} in your cart");
            } 
            else {
                Console.WriteLine("does not match");
            }
        }


    }
}