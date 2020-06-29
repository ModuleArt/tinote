using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TestApp {
    public partial class Form1 : Form {

        Point pt;

        public Form1() {
            InitializeComponent();

            Button b = new Button();
            b.Location = new Point(0, 300);
            b.Text = "test";
            this.innerPanel.Controls.Add(b);

            pt = new Point(this.innerPanel.AutoScrollPosition.X, this.innerPanel.AutoScrollPosition.Y);
            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.Maximum = this.innerPanel.DisplayRectangle.Height;
            this.customScrollbar1.LargeChange = customScrollbar1.Maximum / customScrollbar1.Height + this.innerPanel.Height;
            this.customScrollbar1.SmallChange = 15;
            this.customScrollbar1.Value = Math.Abs(this.innerPanel.AutoScrollPosition.Y);

            this.vScrollBar1.Minimum = 0;
            this.vScrollBar1.Maximum = this.innerPanel.DisplayRectangle.Height;
            this.vScrollBar1.LargeChange = vScrollBar1.Maximum / vScrollBar1.Height + this.innerPanel.Height;
            this.vScrollBar1.SmallChange = 15;
            this.vScrollBar1.Value = Math.Abs(this.innerPanel.AutoScrollPosition.Y);
            
        }

        private void customScrollbar1_Load(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
          
        }

        private void Form1_Click(object sender, EventArgs e) {
            //customScrollbar1.Value = 100;
        }

        private void customScrollbar1_Scroll(object sender, EventArgs e)
        {
            innerPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);
            vScrollBar1.Value = customScrollbar1.Value;
            customScrollbar1.Invalidate();
            Application.DoEvents();
            Debug.WriteLine("vscroll: " + vScrollBar1.Value.ToString() + "  custom: " + customScrollbar1.Value.ToString());
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            innerPanel.AutoScrollPosition = new Point(0, vScrollBar1.Value);
            customScrollbar1.Value = vScrollBar1.Value;
            Application.DoEvents();
            Debug.WriteLine("vscroll: " + vScrollBar1.Value.ToString() + "  custom: " + customScrollbar1.Value.ToString());
        }

        private void btnHidePanelScrollbar_Click(object sender, EventArgs e)
        {
            if (btnHidePanelScrollbar.Text == "Hide Panel Scrollbar")
            {
                outerPanel.Width -= 20;
                customScrollbar1.Left -= 20;
                btnHidePanelScrollbar.Text = "Show Panel Scrollbar";
            }
            else
            {
                outerPanel.Width += 20;
                customScrollbar1.Left += 20;
                btnHidePanelScrollbar.Text = "Hide Panel Scrollbar";
            }
        }
    }
}