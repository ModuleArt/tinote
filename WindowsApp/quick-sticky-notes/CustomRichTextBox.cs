using System;
using System.Drawing;
using System.Windows.Forms;

namespace quick_sticky_notes
{
	class CustomRichTextBox : RichTextBox
	{
        public Panel fakePanel = new Panel
        {
            AutoScroll = true
        };

        public Button fakeButton = new Button
        {
            Height = 1000000
        };
        
        public CustomRichTextBox()
        {
            fakePanel.Controls.Add(fakeButton);

            fakePanel.Scroll += FakePanel_Scroll;
            this.VScroll += CustomRichTextBox_VScroll;
        }

        public int GetCurScrollLine()
        {
            int index = this.GetCharIndexFromPosition(new Point(1, 1));
            int topline = this.GetLineFromCharIndex(index);
            int lines = this.Lines.Length;
            return lines == 0 ? 0 : (int)(100.0 * topline / lines);


        }

        public int GetCurShowedLinesCount()
        {
            int res = this.Height / 17;
            return res;
        }

        private void CustomRichTextBox_VScroll(object sender, EventArgs e)
        {
            int pos = NativeMethodsManager.GetScrollPos(this.Handle, (int)NativeMethodsManager.ScrollBarType.SbVert);
            pos <<= 16;

            fakePanel.Scroll -= FakePanel_Scroll;
            uint par = (uint)NativeMethodsManager.ScrollBarCommands.SB_THUMBPOSITION | (uint)pos;
            NativeMethodsManager.SendMessage(fakePanel.Handle, (int)NativeMethodsManager.Message.WM_VSCROLL, new IntPtr(par), new IntPtr(0));
            fakePanel.Scroll += FakePanel_Scroll;
        }

        public void FakePanel_Scroll(object sender, ScrollEventArgs e)
        {
            int pos = NativeMethodsManager.GetScrollPos(fakePanel.Handle, (int)NativeMethodsManager.ScrollBarType.SbVert);
            pos <<= 16;

            this.VScroll -= CustomRichTextBox_VScroll;
            uint par = (uint)NativeMethodsManager.ScrollBarCommands.SB_THUMBPOSITION | (uint)pos;
            NativeMethodsManager.SendMessage(this.Handle, (int)NativeMethodsManager.Message.WM_VSCROLL, new IntPtr(par), new IntPtr(0));
            this.VScroll += CustomRichTextBox_VScroll;
        }
    }
}
