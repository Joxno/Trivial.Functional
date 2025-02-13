using System;

namespace Trivial.Functional.Func
{
    public static partial class FP
    {
        public static Func<Maybe<T>, bool> MaybeHasValue<T>() =>
            (Maybe) => Maybe.HasValue;
    }
}
