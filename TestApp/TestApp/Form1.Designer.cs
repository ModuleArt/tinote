namespace TestApp {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.outerPanel = new System.Windows.Forms.Panel();
            this.innerPanel = new System.Windows.Forms.Panel();
            this.btnHidePanelScrollbar = new System.Windows.Forms.Button();
            this.customScrollbar1 = new CustomControls.CustomScrollbar();
            this.outerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 15;
            this.vScrollBar1.Location = new System.Drawing.Point(242, 8);
            this.vScrollBar1.Maximum = 250;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 175);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // outerPanel
            // 
            this.outerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outerPanel.Controls.Add(this.innerPanel);
            this.outerPanel.Location = new System.Drawing.Point(3, 5);
            this.outerPanel.Name = "outerPanel";
            this.outerPanel.Size = new System.Drawing.Size(200, 179);
            this.outerPanel.TabIndex = 3;
            // 
            // innerPanel
            // 
            this.innerPanel.AutoScroll = true;
            this.innerPanel.Location = new System.Drawing.Point(0, 0);
            this.innerPanel.Name = "innerPanel";
            this.innerPanel.Size = new System.Drawing.Size(196, 175);
            this.innerPanel.TabIndex = 0;
            // 
            // btnHidePanelScrollbar
            // 
            this.btnHidePanelScrollbar.Location = new System.Drawing.Point(3, 204);
            this.btnHidePanelScrollbar.Name = "btnHidePanelScrollbar";
            this.btnHidePanelScrollbar.Size = new System.Drawing.Size(200, 23);
            this.btnHidePanelScrollbar.TabIndex = 4;
            this.btnHidePanelScrollbar.Text = "Hide Panel Scrollbar";
            this.btnHidePanelScrollbar.UseVisualStyleBackColor = true;
            this.btnHidePanelScrollbar.Click += new System.EventHandler(this.btnHidePanelScrollbar_Click);
            // 
            // customScrollbar1
            // 
            this.customScrollbar1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));
            this.customScrollbar1.DownArrowImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.DownArrowImage")));
            this.customScrollbar1.LargeChange = 10;
            this.customScrollbar1.Location = new System.Drawing.Point(209, 4);
            this.customScrollbar1.Maximum = 100;
            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.MinimumSize = new System.Drawing.Size(15, 92);
            this.customScrollbar1.Name = "customScrollbar1";
            this.customScrollbar1.Size = new System.Drawing.Size(15, 179);
            this.customScrollbar1.SmallChange = 1;
            this.customScrollbar1.TabIndex = 5;
            this.customScrollbar1.ThumbBottomImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.ThumbBottomImage")));
            this.customScrollbar1.ThumbBottomSpanImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.ThumbBottomSpanImage")));
            this.customScrollbar1.ThumbMiddleImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.ThumbMiddleImage")));
            this.customScrollbar1.ThumbTopImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.ThumbTopImage")));
            this.customScrollbar1.ThumbTopSpanImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.ThumbTopSpanImage")));
            this.customScrollbar1.UpArrowImage = ((System.Drawing.Image)(resources.GetObject("customScrollbar1.UpArrowImage")));
            this.customScrollbar1.Value = 0;
            this.customScrollbar1.Scroll += new System.EventHandler(this.customScrollbar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(471, 266);
            this.Controls.Add(this.customScrollbar1);
            this.Controls.Add(this.btnHidePanelScrollbar);
            this.Controls.Add(this.outerPanel);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Form1";
            this.Text = "Custom Scrollbar Test";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.outerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel outerPanel;
        private System.Windows.Forms.Panel innerPanel;
        private System.Windows.Forms.Button btnHidePanelScrollbar;
        private CustomControls.CustomScrollbar customScrollbar1;
    }
}

