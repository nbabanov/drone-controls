using System.Runtime.InteropServices;

namespace Drone.Data.Navigation.Native.Math
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct vector21_t
    {
        public float x;
        public float y;
    }
}