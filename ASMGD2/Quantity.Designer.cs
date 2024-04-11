namespace ASMGD2
{
    partial class Quantity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnok = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 39);
            textBox1.TabIndex = 0;
            // 
            // btnok
            // 
            btnok.Location = new Point(553, 35);
            btnok.Name = "btnok";
            btnok.Size = new Size(150, 46);
            btnok.TabIndex = 1;
            btnok.Text = "ok";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // Quantity
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 157);
            Controls.Add(btnok);
            Controls.Add(textBox1);
            Name = "Quantity";
            Text = "Quantity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnok;
    }
}