using DTD.Entity.Enum;

namespace DTD.Entity.vCodes
{
    public class Variable<T>:VCode
    {
        public string Name { get; set; }
        public T[,] Value { get; set; }
        public bool IsArray { get; set; }
        public bool IsStatic { get; set; }


        //to initialize data in array #ignore if ur nub
        private int Row { get; set; }
        private int Column { get; set; }


       
  
        public Enums.AccessModifier AccessModifier{get;set;}

        public Variable()
        {
            Name = "NewVariable";
            AccessModifier=Enums.AccessModifier.Public;
        }
    }
}
