namespace Trivial.Functional;

public static class TapExtensions
{
    public static Func<TResult> Tap<TResult>(this Func<TResult> Func, Action<TResult> TapFunc) =>
        () => FP.Let(Func(), R => {
            TapFunc(R);
            return R;
        })();

    public static Func<T, TResult> Tap<T, TResult>(this Func<T, TResult> Func, Action<TResult> TapFunc) =>
        (P) => FP.Let(Func(P), R => {
            TapFunc(R);
            return R;
        })();

    public static Func<T1, T2, TResult> Tap<T1, T2, TResult>(this Func<T1, T2, TResult> Func, Action<TResult> TapFunc) =>
        (P1, P2) => FP.Let(Func(P1, P2), R => {
            TapFunc(R);
            return R;
        })();

    public static Func<T1, T2, T3, TResult> Tap<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> Func, Action<TResult> TapFunc) =>
        (P1, P2, P3) => FP.Let(Func(P1, P2, P3), R => {
            TapFunc(R);
            return R;
        })();

    public static Func<T1, T2, T3, T4, TResult> Tap<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> Func, Action<TResult> TapFunc) =>
        (P1, P2, P3, P4) => FP.Let(Func(P1, P2, P3, P4), R => {
            TapFunc(R);
            return R;
        })();
}