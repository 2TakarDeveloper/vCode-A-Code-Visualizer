using DTD.Entity.Enum;

namespace DTD.Entity.vCodes
{
    public class Constant:TypedvCodes
    {
        public string Value { set; get; }

        public Constant()
        {
            Value = "";
            VType = Enums.VType.Constant;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
