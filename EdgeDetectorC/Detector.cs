using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System;
using System.Runtime.Intrinsics.X86;


namespace EdgeDetectorC
{
    public class Detector
    {
        public static int run(int xy, int x1y, int x1y1, int xy1)
        {
            int result = Math.Abs(xy - x1y1) + Math.Abs(x1y - xy1);
            return result > 255 ? 255: result;
        }
    }
}