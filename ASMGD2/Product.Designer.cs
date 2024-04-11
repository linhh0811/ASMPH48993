namespace ASMGD2
{
    partial class Product
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
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            rdb1 = new RadioButton();
            rdb0 = new RadioButton();
            txtpack = new TextBox();
            txtprice = new TextBox();
            txtsid = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lablel1 = new Label();
            dgvProduct = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(rdb1);
            panel1.Controls.Add(rdb0);
            panel1.Controls.Add(txtpack);
            panel1.Controls.Add(txtprice);
            panel1.Controls.Add(txtsid);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lablel1);
            panel1.Controls.Add(dgvProduct);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 621);
            panel1.TabIndex = 0;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(913, 101);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(913, 180);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(913, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 14;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // rdb1
            // 
            rdb1.AutoSize = true;
            rdb1.Location = new Point(653, 209);
            rdb1.Name = "rdb1";
            rdb1.Size = new Size(59, 36);
            rdb1.TabIndex = 13;
            rdb1.TabStop = true;
            rdb1.Text = "1";
            rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb0
            // 
            rdb0.AutoSize = true;
            rdb0.Location = new Point(521, 209);
            rdb0.Name = "rdb0";
            rdb0.Size = new Size(59, 36);
            rdb0.TabIndex = 12;
            rdb0.TabStop = true;
            rdb0.Text = "0";
            rdb0.UseVisualStyleBackColor = true;
            // 
            // txtpack
            // 
            txtpack.Location = new Point(638, 84);
            txtpack.Name = "txtpack";
            txtpack.Size = new Size(200, 39);
            txtpack.TabIndex = 11;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(638, 33);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(128, 39);
            txtprice.TabIndex = 10;
            // 
            // txtsid
            // 
            txtsid.Location = new Point(205, 140);
            txtsid.Name = "txtsid";
            txtsid.Size = new Size(96, 39);
            txtsid.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(235, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(144, 39);
            txtName.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(113, 33);
            txtID.Name = "txtID";
            txtID.Size = new Size(94, 39);
            txtID.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(506, 147);
            label6.Name = "label6";
            label6.Size = new Size(185, 32);
            label6.TabIndex = 6;
            label6.Text = "IsDiscontinued";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 91);
            label5.Name = "label5";
            label5.Size = new Size(114, 32);
            label5.TabIndex = 5;
            label5.Text = "Package ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(506, 40);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 4;
            label4.Text = "UnitPrice ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 147);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 3;
            label3.Text = "SupplierId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 91);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 2;
            label2.Text = "ProductName";
            // 
            // lablel1
            // 
            lablel1.AutoSize = true;
            lablel1.Location = new Point(57, 40);
            lablel1.Name = "lablel1";
            lablel1.Size = new Size(40, 32);
            lablel1.TabIndex = 1;
            lablel1.Text = "ID";
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(20, 275);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 82;
            dgvProduct.Size = new Size(1061, 327);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 645);
            Controls.Add(panel1);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lablel1;
        private DataGridView dgvProduct;
        private RadioButton rdb1;
        private RadioButton rdb0;
        private TextBox txtpack;
        private TextBox txtprice;
        private TextBox txtsid;
        private TextBox txtName;
        private TextBox txtID;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}