using DTD.Entity.Enum;

namespace DTD.Entity.vCodes
{
    public class Variable:TypedvCodes
    {
      
        //public dynamic  Value { get; set; }
        public bool IsArray { get; set; }
     


        //to initialize data in array #ignore if ur nub
        public int Row { get; set; }
        public int Column { get; set; }
        public string ArrayType { get; set; }

       
  
        

        public Variable()
        {
            Name = "NewVariable";
            AccessModifier=Enums.AccessModifier.Public;
        }

        public Variable(string name)
        {
            Name = name;
            AccessModifier = Enums.AccessModifier.Public;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
