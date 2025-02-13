namespace Trivial.Functional
{
    public record struct Unit;
    public static partial class Defaults
    {
        public static readonly Unit Unit = new Unit();
        public static Unit ToUnit<T>(this T _) => Unit;
    }

}