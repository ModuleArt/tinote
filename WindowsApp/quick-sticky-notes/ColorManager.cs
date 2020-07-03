using System.Drawing;

namespace quick_sticky_notes
{
	public static class ColorManager
	{
		public static Color UIColor1 = Color.White;
		public static Color UIColor2 = Color.FromArgb(240, 240, 240);
		public static Color UIColor3 = Color.FromArgb(225, 225, 225);
		public static Color UIColor4 = Color.FromArgb(205, 205, 205);
		public static Color UIColor5 = Color.FromArgb(190, 190, 190);

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
			else if (colorStr == "purple")
			{
				return Color.FromArgb(209, 164, 255);
			}
			else if (colorStr == "white")
			{
				return Color.FromArgb(249, 249, 249);
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
			else if (colorStr == "purple")
			{
				return Color.FromArgb(104, 82, 127);
			}
			else if (colorStr == "white")
			{
				return Color.FromArgb(124, 124, 124);
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
			else if (colorStr == "purple")
			{
				return Color.FromArgb(157, 123, 191);
			}
			else if (colorStr == "white")
			{
				return Color.FromArgb(187, 187, 187);
			}
			else
			{
				return Color.FromArgb(191, 173, 96);
			}
		}
	}
}
