using System.Runtime.InteropServices;

namespace Drone.Video
{
  [StructLayout(LayoutKind.Sequential)]
  public class VideoFrame
  {
    public long Timestamp;
    public uint Number;
    public int Width;
    public int Height;
    public int Depth;
    public PixelFormat PixelFormat;
    public byte[] Data;
  }
}