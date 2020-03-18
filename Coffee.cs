using System;

namespace Lab7_v2
{
    public class Coffee : Drink
    {
        public bool Sugar;
        public bool Cream;
        public string Type;

        public Coffee(double size)
            : base("Coffee", true, size) { }

        public Coffee(double size, bool sugar, bool cream, string type)
            : this(size)
        {
            Sugar = sugar;
            Cream = cream;
            Type = type;
        }
        public override string Prepare()
        {
            string result = $"{base.Prepare()} -> grounding {Name} beans -> {Heat()} -> adding hotwater ";
            if (Sugar)
                result += AddSugar();
            if (Cream)
                result += AddCream();
            return result;
        }

        public override string Heat() => $" {base.Heat()} water";

        public override string Serve() => $"Pouring {Name} in a cup -> putting lid -> putting holder -> {base.Serve()}";

        public string AddSugar() => $" -> Adding suggar";
        public string AddCream() => $" -> Adding Cream";

        public override string Display() => base.Display() + $"{ (Sugar ? "Sugar" : "No Sugar")}, {(Cream ? "Cream" : "No Cream")}, {Type}";

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Coffee c = (Coffee)obj;
            if (this.Type == c.Type && this.Cream == c.Cream && this.Sugar == c.Sugar)
                return true;
            else
                return false;
        }

        public override int GetHashCode() => Name.GetHashCode();

        public static bool operator ==(Coffee c1, Coffee c2)
        {
            if (Object.Equals(c1, null))
                if (Object.Equals(c2, null))
                    return true;
                else
                    return false;
            else
                return c1.Equals(c2);
        }

        public static bool operator !=(Coffee c1, Coffee c2) => !(c1 == c2);
    }
}
