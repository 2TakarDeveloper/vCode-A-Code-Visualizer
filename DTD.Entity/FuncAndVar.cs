using DTD.Entity.Enum;

namespace DTD.Entity
{
    public class FuncAndVar:VCode
    {
        
        public Enums.Type Type { get; set; }
        public string Name { get; set; }
        public bool IsStatic { get; set; }
        public Enums.AccessModifier AccessModifier { get; set; }
        public bool IsBody { get; set; }
    }
}
