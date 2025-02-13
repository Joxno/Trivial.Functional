namespace Trivial.Functional;

public static class PipeExtensions
{
        public static Func<T1, T3> PipeTo<T1, T2, T3>(this Func<T1, T2> A, Func<T2, T3> B) =>
            (P) => B(A(P));

        public static Func<TResult> PipeTo<T, TResult>(this Func<T> A, Func<T, TResult> B) =>
            () => B(A());
}