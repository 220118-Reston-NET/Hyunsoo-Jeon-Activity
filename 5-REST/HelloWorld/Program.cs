// See https://aka.ms/new-console-template for more information
using AsyncFunction;

Console.WriteLine("Hello, World!");

Asynchronous demo = new Asynchronous();

// Console.WriteLine(demo.CookRice());
// Console.WriteLine(demo.CookMeat());
// Console.WriteLine(demo.CookVeggies());

Task<string> riceTask = demo.CookRice();
//Task<string> meatTask = demo.CookMeat();
//Task<string> veggieTask = demo.CookVeggies();
Task<string> mainCourseTask = demo.CookMeatthenVeiggies();

List<Task<string>> toDoMakeDinner = new List<Task<string>>(){riceTask, mainCourseTask};

while(toDoMakeDinner.Count > 0)
{
    // WhenAny() method will run all the tasks inside of a list of tasks at the same time
    // it will store the first finished task inside of another task reference variable
    Task<string> finishedTask = await Task.WhenAny(toDoMakeDinner);

    // we are displaying the result of that tasks
    Console.WriteLine(finishedTask.Result);

    // we proceed to remove in our to do list
    toDoMakeDinner.Remove(finishedTask);
}