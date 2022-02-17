namespace PokeModel 
{
    public class Ability
    {
        public int AbId { get; set; }
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

        public Ability(){
            Name = "Tackle";
            PP = 35;
            Power = 35;
            Accuracy = 70;
        }

        public override string ToString()
        {
            return $"ID: {AbId} \n Name: {Name} \n PP: {PP} \n Power: {Power} \n Accuracy: {Accuracy}";
        }
    }
}