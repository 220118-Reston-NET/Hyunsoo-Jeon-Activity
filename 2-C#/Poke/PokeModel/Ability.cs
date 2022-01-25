namespace PokeModel 
{
    public class Ability
    {
        public string Name { get; set; }
        private int _pp;
        public int PP
        {
            get { return _pp; }
            set 
            { 
                if(value > 0)
                {
                    _pp = value;
                } 
                else 
                {
                    throw new Exception("You cannot set PP lower than 0");
                }
            }
        }
        
        public int Power { get; set; }
        public int Accuracy { get; set; }


    }
}