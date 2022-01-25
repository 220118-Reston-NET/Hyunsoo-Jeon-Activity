using MenuFunction;
using System.Text.Json;

namespace SerializationFunction {
    public class Serialization {
        private static string _filepath = "./Database/Menu.json";
        private static List<string> listOfMenu = new List<string>();

        public static void SerialMain(string item){
            
            listOfMenu.Add(item);

            string jsonString = JsonSerializer.Serialize(listOfMenu, new JsonSerializerOptions {WriteIndented = true});
            
            //Console.WriteLine(jsonString);

            File.WriteAllText(_filepath, jsonString);

            Console.WriteLine($"you have ordered {item}");

        }

        public static void ListOrder(){
            string jsonString2 = File.ReadAllText(_filepath);
            listOfMenu = JsonSerializer.Deserialize<List<string>>(jsonString2);

            if(listOfMenu.Count == 0){
                Console.WriteLine("your cart is empty!");
            } 
            else {
                Console.WriteLine("your order is");
                foreach(string item in listOfMenu){
                // order shows all upper case letter
                Console.WriteLine(item.ToUpper());
                }
            }

        }

        public static void removeItemJson(string removeItem){
            string jsonString2 = File.ReadAllText(_filepath);
            listOfMenu = JsonSerializer.Deserialize<List<string>>(jsonString2);

            if(removeItem == "burger"){
                // it removes elements in index 0 
                listOfMenu.RemoveAt(0);
                Console.WriteLine("your burger is removed!");
                Menu.Next();
            }
            // if user want to remove drink
            else if(removeItem == "drink"){
                // it removes elements in index 1 
                listOfMenu.RemoveAt(1);
                Console.WriteLine("your drink is removed!");
                Menu.Next();
            }
            // if user want to remove side
            else if(removeItem == "side"){
                // it removes elements in index 2 
                listOfMenu.RemoveAt(2);
                Console.WriteLine("your side is removed!");
                Menu.Next();
            }
            else {
                Console.WriteLine("nothing matches");
                Menu.Next();
            }
        }

        public static void searchJsonItem(string searchItem){
            string jsonString2 = File.ReadAllText(_filepath);
            listOfMenu = JsonSerializer.Deserialize<List<string>>(jsonString2);

             if(listOfMenu.Contains(searchItem)){
                Console.WriteLine($"you have {searchItem} in your cart");
            } 
            else {
                Console.WriteLine("does not match");
            }
        }


        
    }
}