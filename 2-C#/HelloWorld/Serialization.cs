using System.Text.Json;
using CarFunction;

namespace SerializationFunction{
    public class Serialization{
        //the period on the file path means to auto put the entire filepath of where this current file is at in our hard drive
        private static string _filepath = "./Database/Car.json";

        public static void SerialMain(){
            Console.WriteLine("=====Serialization demo=====");

            Console.WriteLine("=====converting object to JSON=====");

            // created a list of cars
            List<Car> listOfCars = new List<Car>();

            Car car1 = new Car(){
                Color = "White",
                Fuel = 80,
                Owner = "Hyunsoo"
            };

            Car car2 = new Car(){
                Color = "Grey",
                Fuel = 70,
                Owner = "Hanson"
            };
            
            // added car 1 and 2 inside of list of cars
            listOfCars.Add(car1);
            listOfCars.Add(car2);

            //converting C# object into a JSON formatted string datatype
            //converting C# object into a string
            string jsonString = JsonSerializer.Serialize(listOfCars, new JsonSerializerOptions{ WriteIndented = true});
            Console.WriteLine(jsonString);

            // file class will create a JSON file or overwrite
            File.WriteAllText(_filepath, jsonString);

            Console.WriteLine("=====Converting JSON to object=====");
            
            //File.ReadAllText() static method will read JSON file and store it in jsonString2
            string jsonString2 = File.ReadAllText(_filepath);
            
            //JsonSerializaer converts the JSON object into a C# object
            List<Car> car0 = JsonSerializer.Deserialize<List<Car>>(jsonString2);

            Console.WriteLine(car0[0].Color);
            Console.WriteLine(car0[0].Fuel);
            Console.WriteLine(car0[0].Owner);


        }
    }
}