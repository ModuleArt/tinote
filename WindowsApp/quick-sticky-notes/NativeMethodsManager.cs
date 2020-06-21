using System;
using System.Runtime.InteropServices;
using System.Text;

namespace quick_sticky_notes
{
	public static class NativeMethodsManager
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		public const int GWL_HWNDPARENT = -8;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindowEx(IntPtr hP, IntPtr hC, string sC, string sW);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string lpWindowClass, string lpWindowName);
	}
}
