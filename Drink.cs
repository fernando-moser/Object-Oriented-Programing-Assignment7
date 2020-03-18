namespace Lab7_v2
{
    public class Drink
    {
        public string Name;
        public bool Hot;
        public double Size;

        public Drink() => Size = 300.0;

        public Drink(string name, bool hot, double size)
        {
            Name = name;
            Hot = hot;
            Size = Size > 150 ? Size = size : 300.0;
        }

        public virtual string Prepare() => $"Preparing {Name}";

        public virtual string Heat() => $"Heating {Name}";

        public virtual string Serve() => $"Serving {Name}";


    }
}
