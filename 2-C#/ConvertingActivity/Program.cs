// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using MenuFunction;
using SerializationFunction;

bool repeat = true;
Console.WriteLine("Name for order?");
string name = Console.ReadLine();

while (repeat)
{
    // menu prints
    Console.Clear();
    Console.WriteLine($"Hello, {name}");
    Console.WriteLine("press 1 if you want to order a burger");
    Console.WriteLine("press 2 if you want to order a drink");
    Console.WriteLine("press 3 if you want to order a side");
    Console.WriteLine("press 4 checkout");
    Console.WriteLine("press 5 Edit order");
    Console.WriteLine("press 6 if you want to search your order");
    Console.WriteLine("press 7 if you want to exit the program");

    // user input
    string userInput = Console.ReadLine();

        // option 1 burger
        if (userInput == "1")
        {
            Console.WriteLine("what sandwitch would you like? \n Doulbe cheese | Cheese | Everything");
            string item = Console.ReadLine();
            Serialization.SerialMain(item);
            //Menu.AddItem(item);
            Menu.Next();
        }
        // option 2 drink
        else if(userInput == "2")
        {
            Console.WriteLine("Drinks? \n Coke | Sprite | Orange Juice ");
            string item = Console.ReadLine();
            Serialization.SerialMain(item);
            //Menu.AddItem(item);
            Menu.Next();
        }
        // option 3 side
        else if(userInput == "3")
        {
            Console.WriteLine("Side? \n Cheese cake | Fries | Onion rings ");
            string item = Console.ReadLine();
            Serialization.SerialMain(item);
            // Menu.AddItem(item);
            Menu.Next();
        }
        // option 4 check cart
        else if(userInput == "4")
        {   
            Serialization.ListOrder();
            //Menu.DisplayCart();
            Menu.Next();       
        }                    
        // option 5 remove an element from list
        else if(userInput == "5"){
            Console.WriteLine("what do you want to remove? press burger or drink or side");
            string removeItem = Console.ReadLine();
            //Menu.RemoveItem(removeItem);
            Serialization.removeItemJson(removeItem);
        }
        // option 6 search elements
        else if(userInput == "6")
        {
            Console.WriteLine("what do you want to find?");
            string searchItem = Console.ReadLine();
            //Menu.SearchItem(searchItem);
            Serialization.searchJsonItem(searchItem);
            Menu.Next();                      
        }
       // option 7 eng program
        else if(userInput == "7")
        {
            repeat = false;
             Console.WriteLine("See you again!");
        }
    }
