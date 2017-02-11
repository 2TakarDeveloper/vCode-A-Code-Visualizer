using DTD.Entity.Enum;

namespace DTD.Entity.vCodes
{
    public class Variable:FuncAndVar
    {
      
        public dynamic  Value { get; set; }
        public bool IsArray { get; set; }
     


        //to initialize data in array #ignore if ur nub
        public int Row { get; set; }
        public int Column { get; set; }


       
  
        

        public Variable()
        {
            Name = "NewVariable";
            AccessModifier=Enums.AccessModifier.Public;
        }
    }
}
