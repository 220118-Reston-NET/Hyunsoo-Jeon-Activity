using System.Collections;

namespace CollectionFunction{
    public class Collection {

        private int[] _nums = new int[5];

        // List collection
        private List <string> _strings = new List<string>();

        //hashset collection
        private HashSet<int> _numsCollection = new HashSet<int>();


        // Dictionary
        private Dictionary<string, int> _dictionary = new Dictionary<string, int>();

        // non generic collection
        private ArrayList _nonGeneric = new ArrayList();
        

        public void CollectionMain(){
            Console.WriteLine("===collection demo===");
            
            _nums[0] = 3;
            _nums[1] = 10;
            _nums[2] = 20;

            // a way to go through a list
            // foreach will iterate through all of the elements of a collection/array
            Console.WriteLine("===foreach loop===");            
            foreach(int num in _nums){
                Console.WriteLine(num);
            }
            Console.WriteLine("===for loop===");
            for(int i = 0; i < _nums.Length; i++){
                Console.WriteLine("current value of i :" +i);
                Console.WriteLine(_nums[i]);
            }

             Console.WriteLine("===Generic collection===");
             Console.WriteLine("===List Demo===");
             _strings.Add("First Element");
             _strings.Add("second Element");
             _strings.Add("third Element");

             foreach(string item in _strings){
                 Console.WriteLine(item);
             }  

             Console.WriteLine("===hash demo===");
            _numsCollection.Add(1);
            _numsCollection.Add(2);
            _numsCollection.Add(3);
            _numsCollection.Add(1);
            
            foreach(int item in _numsCollection){
                Console.WriteLine(item);
            }

             Console.WriteLine("===Dictionary demo===");
            _dictionary.Add("Hanson", 1000);
            _dictionary.Add("mike", 1200);
            _dictionary.Add("hyunsoo", -1000);
            _dictionary.Add("Jeon", 500);

            Console.WriteLine(_dictionary["hyunsoo"]);

            _nonGeneric.Add("hanson");
            _nonGeneric.Add(10);
            _nonGeneric.Add(true);
            _nonGeneric.Add(10.70);

        }
    }
}