using System.Runtime.InteropServices;

namespace Electra.MouseHelpers
{
	[StructLayout(LayoutKind.Sequential)]
	public struct MousePoint
	{
		public int X;
		public int Y;

		public MousePoint(int x, int y)
		{
			X = x;
			Y = y;
		}
	}
}