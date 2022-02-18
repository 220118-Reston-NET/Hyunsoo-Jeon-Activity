namespace AsyncFunction
{

    public class Asynchronous
    {
        public async Task<string> CookRice()
        {
            Console.WriteLine("Started cooking rice...");
            await Task.Delay(5000);
            return "Finished cooking rice";
        }

        public async Task<string> CookMeat()
        {
            Console.WriteLine("Started cooking meat...");
            await Task.Delay(3000);
            return "Finished cooking meat";
        }

        public async Task<string> CookVeggies()
        {
            Console.WriteLine("Started cooking veggies...");
            await Task.Delay(1000);
            return "Finished cooking veggies";
        }
    }

}