using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TestApp
{
	public partial class Form2 : Form
	{

		/// <summary>
		/// Gets the current position of the scroll box.
		/// </summary>
		/// <param name="hWnd">the Handle.
		/// <param name="nBar">the Type.
		/// <returns></returns>
		[DllImport("User32.dll")]
		public extern static int GetScrollPos(IntPtr hWnd, int nBar);

		/// <summary>
		/// Function to send messages.
		/// </summary>
		/// <param name="hWnd">the Handle.
		/// <param name="msg">the message Itself.
		/// <param name="wParam">the Parameters.
		/// <param name="lParam">Additional settings.
		[DllImport("User32.dll")]
		public extern static int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

		public enum ScrollBarType : uint
		{
			SbHorz = 0,
			SbVert = 1,
			SbCtl = 2,
			SbBoth = 3
		}

		public enum Message : uint
		{
			/// <summary>
			/// A message to the vertical scrollbar
			/// </summary>
			WM_VSCROLL = 0x0115
		}

		public enum ScrollBarCommands : uint
		{
			/// <summary>
			/// The position of scrollbar thumb in the end of the operation
			/// </summary>
			SB_THUMBPOSITION = 4
		}

		 private RichTextBox rich1  = new RichTextBox();
		 private RichTextBox rich2  = new RichTextBox();


		public Form2()
		{
			InitializeComponent();

			// test text
			string text = "";
			for (int i = 0; i < 99; i++)
			{
				text += "There are 2 richTextBox, you need to set the value of the current vertical scrolling first, as in the moment of the second. Tried all sorts of offset, digging into Google, but anything intelligible did not find.\r\n";
			}

			// add fields to the form
			rich1.Name = "rich1";
			rich1.Dock = DockStyle.Top;
			rich1.Text = text;
			rich1.VScroll += rich_VScroll;
			this.Controls.Add(rich1);

			rich2.Name = "rich2";
			rich2.Dock = DockStyle.Top;
			rich2.Text = text;
			rich2.VScroll += rich_VScroll;
			this.Controls.Add(rich2);
		}

		/// <summary>
		/// Handler for changing the position of the slider of the scroll bar.
		/// </summary>
		private void rich_VScroll(object sender, EventArgs e)
		{
			// who caused the event
			 RichTextBox CurrentRich  = (RichTextBox)sender;
			// if the event is called rich2, the second would be rich1 and Vice versa
			RichTextBox otherRich = CurrentRich.Name.Equals("rich1") ? rich2 : rich1;

			// get the position of the scroll box of the current field
			int pos = GetScrollPos(CurrentRich.Handle, (int)ScrollBarType.SbVert);
			pos <<= 16;

			// to not get stuck in infinity
			// (it is possible not to do that and tie the handler to only one field)
			otherRich.VScroll -= rich_VScroll;
			// --

			// pass the position in the second field
			 uint par = (uint)ScrollBarCommands.SB_THUMBPOSITION | (uint)pos;
			SendMessage(otherRich.Handle, (int)Message.WM_VSCROLL, new IntPtr(par), new IntPtr(0));
			otherRich.VScroll += rich_VScroll;
		}
	}
}