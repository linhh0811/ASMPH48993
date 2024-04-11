using System.Xml.Linq;

namespace ASMGD2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            toolStripContainer1 = new ToolStripContainer();
            menuStrip1 = new MenuStrip();
            traCuuToolStripMenuItem = new ToolStripMenuItem();
            productMenuItem = new ToolStripMenuItem();
            customerMenuItem = new ToolStripMenuItem();
            orderMenuItem = new ToolStripMenuItem();
            banHangToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStripContainer1);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(-391, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1520, 689);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.BackColor = SystemColors.ButtonHighlight;
            toolStripContainer1.ContentPanel.Enabled = false;
            toolStripContainer1.ContentPanel.Size = new Size(300, 325);
            toolStripContainer1.ContentPanel.Load += toolStripContainer1_ContentPanel_Load;
            toolStripContainer1.Location = new Point(47, 118);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(300, 350);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { traCuuToolStripMenuItem, banHangToolStripMenuItem });
            menuStrip1.Location = new Point(401, 30);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(497, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // traCuuToolStripMenuItem
            // 
            traCuuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productMenuItem, customerMenuItem, orderMenuItem });
            traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem";
            traCuuToolStripMenuItem.Size = new Size(111, 38);
            traCuuToolStripMenuItem.Text = "Tra cuu";
            // 
            // productMenuItem
            // 
            productMenuItem.Name = "productMenuItem";
            productMenuItem.Size = new Size(359, 44);
            productMenuItem.Text = "Product";
            productMenuItem.Click += productMenuItem_Click;
            // 
            // customerMenuItem
            // 
            customerMenuItem.Name = "customerMenuItem";
            customerMenuItem.Size = new Size(359, 44);
            customerMenuItem.Text = "Customer";
            customerMenuItem.Click += customerMenuItem_Click;
            // 
            // orderMenuItem
            // 
            orderMenuItem.Name = "orderMenuItem";
            orderMenuItem.Size = new Size(359, 44);
            orderMenuItem.Text = "Order";
            orderMenuItem.Click += orderMenuItem_Click;
            // 
            // banHangToolStripMenuItem
            // 
            banHangToolStripMenuItem.Name = "banHangToolStripMenuItem";
            banHangToolStripMenuItem.Size = new Size(138, 38);
            banHangToolStripMenuItem.Text = "Ban Hang";
            banHangToolStripMenuItem.Click += banHangToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 721);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem traCuuToolStripMenuItem;
        private ToolStripMenuItem productMenuItem;
        private ToolStripMenuItem customerMenuItem;
        private ToolStripMenuItem orderMenuItem;
        private ToolStripMenuItem banHangToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
       // private XObjectChangeEventArgs
    }
}
