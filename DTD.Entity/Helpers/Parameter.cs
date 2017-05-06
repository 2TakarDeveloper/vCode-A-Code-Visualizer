using DTD.Entity.Enum;

namespace DTD.Entity.Helpers
{
    public class Parameter
    {
        public Enums.Type  Type { get; set; }
        public string Name { get; set; }

        public Parameter()
        {
            Type = Enums.Type.Int;
            Name = "New Parameter";
        }
        public Parameter(Enums.Type type, string name)
        {
            this.Type = type;
            this.Name = name;
        }
        public Parameter(string name)
        {
            this.Type = Enums.Type.Int;
            this.Name = name;
        }
    }
}
