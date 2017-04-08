namespace DTD.Entity.Enum
{
    public class Enums
    {
        public enum Type
        {
            Int, Float, Double, String, Bool, Void, Char
        }

        public enum AccessModifier
        {
            Public, Private, Protected
        }

        public enum VType
        {
            Variable, Function, If, While, GlobalScope, Constant, Assignment
        }

        public enum InstructionType
        {
            SingleAddress, ThreeAddress
        }
    }
}
