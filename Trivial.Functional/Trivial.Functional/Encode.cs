using System;

namespace Trivial.Functional;

public static partial class FP
{
    public static Func<T> EncodeState<T>(Func<Func<T>> F) => F();
}