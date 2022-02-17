namespace PokeModel
{
    public class Pokemon 
    {
        public int PokeId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        
        private List<Ability> _abilities;
        public List<Ability> Abilities
        {
            get { return _abilities; }
            set {
                    if(value.Count < 4) 
                    {
                        _abilities = value;
                    } 
                    else 
                    {
                        throw new Exception("Pokemon cannot hold more than 4 abilities");
                    }
                }
        }
        

        // default constructor to add default values to the properties
        public Pokemon()
        {
            Name = "Ditto";
            Level = 1;
            Attack = 55;
            Defense = 55;
            Health = 55;
            _abilities = new List<Ability>()
            {
                new Ability()
            };
        }

        //Tostring() method is the string version of your object
        public override string ToString()
        {
            return $"ID: {PokeId} \nName: {Name}\n Level: {Level}\n Attack: {Attack}\n Defence: {Defense}\n Health: {Health} ";
        }
    }
}

