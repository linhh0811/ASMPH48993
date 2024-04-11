namespace ASMGD2
{
    partial class BanHang
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
            panel1 = new Panel();
            label2 = new Label();
            txtTongTien = new TextBox();
            button1 = new Button();
            grbProductDangChon = new GroupBox();
            dgvDangChon = new DataGridView();
            grbListProduct = new GroupBox();
            dgvListpr = new DataGridView();
            label1 = new Label();
            cbbDSKH = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            grbProductDangChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDangChon).BeginInit();
            grbListProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListpr).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTongTien);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(grbProductDangChon);
            panel1.Controls.Add(grbListProduct);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbbDSKH);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 988);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1015, 50);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 6;
            label2.Text = "TongTien";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(1160, 47);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(148, 39);
            txtTongTien.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(530, 43);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "Dat Hang";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grbProductDangChon
            // 
            grbProductDangChon.Controls.Add(dgvDangChon);
            grbProductDangChon.Location = new Point(60, 562);
            grbProductDangChon.Name = "grbProductDangChon";
            grbProductDangChon.Size = new Size(1284, 400);
            grbProductDangChon.TabIndex = 3;
            grbProductDangChon.TabStop = false;
            grbProductDangChon.Text = "Product Dang Chon";
            // 
            // dgvDangChon
            // 
            dgvDangChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDangChon.Location = new Point(27, 57);
            dgvDangChon.Name = "dgvDangChon";
            dgvDangChon.RowHeadersWidth = 82;
            dgvDangChon.Size = new Size(1230, 292);
            dgvDangChon.TabIndex = 0;
            dgvDangChon.CellEndEdit += dgvSPDangChon_CellEndEdit;
            // 
            // grbListProduct
            // 
            grbListProduct.Controls.Add(dgvListpr);
            grbListProduct.Location = new Point(60, 136);
            grbListProduct.Name = "grbListProduct";
            grbListProduct.Size = new Size(1284, 405);
            grbListProduct.TabIndex = 2;
            grbListProduct.TabStop = false;
            grbListProduct.Text = "List Product";
            // 
            // dgvListpr
            // 
            dgvListpr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListpr.Location = new Point(18, 65);
            dgvListpr.Name = "dgvListpr";
            dgvListpr.RowHeadersWidth = 82;
            dgvListpr.Size = new Size(1230, 322);
            dgvListpr.TabIndex = 0;
            dgvListpr.CellContentClick += dgvListpr_CellContentClick;
            dgvListpr.CellDoubleClick += dgvListpr_CellDoubleClick;
            dgvListpr.DoubleClick += dgvListpr_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 49);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 1;
            label1.Text = "DSKhachH";
            // 
            // cbbDSKH
            // 
            cbbDSKH.FormattingEnabled = true;
            cbbDSKH.Location = new Point(162, 46);
            cbbDSKH.Name = "cbbDSKH";
            cbbDSKH.Size = new Size(242, 40);
            cbbDSKH.TabIndex = 0;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 1012);
            Controls.Add(panel1);
            Name = "BanHang";
            Text = "Ban Hang";
            Load += BanHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbProductDangChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDangChon).EndInit();
            grbListProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListpr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cbbDSKH;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbProductDangChon;
        private GroupBox grbListProduct;
        private Button button1;
        private DataGridView dgvDangChon;
        private DataGridView dgvListpr;
        private TextBox txtTongTien;
        private Label label2;
    }
}