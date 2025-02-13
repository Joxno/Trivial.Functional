using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Trivial.Utilities;

public static class StructExtensions
{
    public static Span<T> AsSpan<T>(this T Struct) where T : struct => MemoryMarshal.CreateSpan(ref Struct, 1);
    public static byte[] ToArray<T>(this T Struct) where T : struct => Blit.StructToByteArr(ref Struct);
}