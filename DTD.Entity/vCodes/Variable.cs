using DTD.Entity.Enum;

namespace DTD.Entity.vCodes
{
    public class Variable<T>:vCode
    {
        public string Name { get; set; }
        public T[,] Value { get; set; }
        public bool isArray { get; set; }
        public bool isStatic { get; set; }


        //to initialize data in array #ignore if ur nub
        private int Row { get; set; }
        private int Column { get; set; }


        public Enums.Type Type { get; set; }
  
        public Enums.AccessModifier AccessModifier{get;set;}

    }
}
