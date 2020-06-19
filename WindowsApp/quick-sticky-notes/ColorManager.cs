using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sticky_notes
{
	public static class ColorManager
	{
		public static Color GetNoteColor(string colorStr)
		{
			if (colorStr == "green")
			{
				return Color.FromArgb(132, 219, 193);
			}
			else if (colorStr == "blue")
			{
				return Color.FromArgb(128, 194, 255);
			}
			else if (colorStr == "pink")
			{
				return Color.FromArgb(255, 163, 209);
			}
			else
			{
				return Color.FromArgb(255, 231, 128);
			}
		}

		public static Color GetDarkColor(string colorStr)
		{
			if (colorStr == "green")
			{
				return Color.FromArgb(66, 109, 96);
			}
			else if (colorStr == "blue")
			{
				return Color.FromArgb(64, 97, 127);
			}
			else if (colorStr == "pink")
			{
				return Color.FromArgb(127, 81, 104);
			}
			else
			{
				return Color.FromArgb(127, 115, 64);
			}
		}

		public static Color GetMiddleColor(string colorStr)
		{
			if (colorStr == "green")
			{
				return Color.FromArgb(99, 164, 145);
			}
			else if (colorStr == "blue")
			{
				return Color.FromArgb(96, 145, 191);
			}
			else if (colorStr == "pink")
			{
				return Color.FromArgb(191, 122, 157);
			}
			else
			{
				return Color.FromArgb(191, 173, 96);
			}
		}
	}
}
