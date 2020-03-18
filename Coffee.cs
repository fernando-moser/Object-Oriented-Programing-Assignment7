namespace Lab7_v2
{
    public class Coffee : Drink
    {
        public bool Sugar;
        public bool Cream;

        public Coffee(string name, bool hot, double size)
            : base(name, hot, size) { }

        public Coffee(string name, bool hot, double size, bool sugar, bool cream)
            : this(name, hot, size)
        {
            Sugar = sugar;
            Cream = cream;
        }

        public override string Prepare() => $" {base.Prepare()} \n grounding {Name} beans \n {Heat()} \n adding hotwater";

        public override string Heat() => $" {base.Heat()} water";

        public override string Serve() => $" pouring {Name} in a mug \n putting lid \n putting holder \n {base.Serve()}";

    }
}
