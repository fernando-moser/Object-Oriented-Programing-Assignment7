namespace Lab7_v2
{
    public class Drink
    {
        public string Name;
        public bool Hot;
        public double Size;

        public Drink(double size) => Size = Size > 150 ? Size = size : 300.0;

        public Drink(string name, bool hot, double size)
            : this(size)
        {
            Name = name;
            Hot = hot;
        }

        public virtual string Prepare() => $"Preparing {Name} ";

        public virtual string Heat() => $"Heating ";

        public virtual string Serve() => $"Serving {Name}";

        public virtual string Display() => $"{Name}, {(Hot ? "Hot" : "Cold")}, ";


    }
}
