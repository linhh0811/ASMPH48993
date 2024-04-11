namespace ASMGD2
{
    partial class Order
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
            dateTimePiker = new DateTimePicker();
            btnDetail = new Button();
            dgvorder = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txttotal = new TextBox();
            txtCustomerid = new TextBox();
            txtOrderNumber = new TextBox();
            txtID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lablel1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvorder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePiker);
            panel1.Controls.Add(btnDetail);
            panel1.Controls.Add(dgvorder);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txttotal);
            panel1.Controls.Add(txtCustomerid);
            panel1.Controls.Add(txtOrderNumber);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lablel1);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1148, 765);
            panel1.TabIndex = 0;
            // 
            // dateTimePiker
            // 
            dateTimePiker.Location = new Point(169, 94);
            dateTimePiker.Name = "dateTimePiker";
            dateTimePiker.Size = new Size(192, 39);
            dateTimePiker.TabIndex = 51;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(588, 198);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(266, 59);
            btnDetail.TabIndex = 50;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // dgvorder
            // 
            dgvorder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvorder.Location = new Point(35, 278);
            dgvorder.Name = "dgvorder";
            dgvorder.RowHeadersWidth = 82;
            dgvorder.Size = new Size(1097, 484);
            dgvorder.TabIndex = 49;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(982, 211);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 48;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(982, 116);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 47;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(982, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 44;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(602, 116);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(200, 39);
            txttotal.TabIndex = 43;
            // 
            // txtCustomerid
            // 
            txtCustomerid.Location = new Point(592, 22);
            txtCustomerid.Name = "txtCustomerid";
            txtCustomerid.Size = new Size(128, 39);
            txtCustomerid.TabIndex = 42;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(180, 156);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(129, 39);
            txtOrderNumber.TabIndex = 41;
            // 
            // txtID
            // 
            txtID.Location = new Point(75, 29);
            txtID.Name = "txtID";
            txtID.Size = new Size(94, 39);
            txtID.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 116);
            label5.Name = "label5";
            label5.Size = new Size(163, 32);
            label5.TabIndex = 38;
            label5.Text = "TotalAmount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 29);
            label4.Name = "label4";
            label4.Size = new Size(147, 32);
            label4.TabIndex = 37;
            label4.Text = "CustomerId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 163);
            label3.Name = "label3";
            label3.Size = new Size(174, 32);
            label3.TabIndex = 36;
            label3.Text = "OrderNumber";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 98);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 35;
            label2.Text = "OrderDate";
            // 
            // lablel1
            // 
            lablel1.AutoSize = true;
            lablel1.Location = new Point(12, 36);
            lablel1.Name = "lablel1";
            lablel1.Size = new Size(40, 32);
            lablel1.TabIndex = 34;
            lablel1.Text = "ID";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 802);
            Controls.Add(panel1);
            Name = "Order";
            Text = "Order";
            Load += Order_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvorder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txttotal;
        private TextBox txtCustomerid;
        private TextBox txtOrderNumber;
        private TextBox txtID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lablel1;
        private DataGridView dgvorder;
        private Button btnDetail;
        private DateTimePicker dateTimePiker;
    }
}