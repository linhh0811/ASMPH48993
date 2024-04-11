namespace ASMGD2
{
    partial class Customer
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
            btnClear = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            dgvCustomer = new DataGridView();
            txtPhone = new TextBox();
            label1 = new Label();
            btnThem = new Button();
            txtcountry = new TextBox();
            txtcity = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lablel1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(dgvCustomer);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtcountry);
            panel1.Controls.Add(txtcity);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lablel1);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 738);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(827, 235);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 34;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1015, 187);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1015, 111);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 32;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(21, 294);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 82;
            dgvCustomer.Size = new Size(1144, 419);
            dgvCustomer.TabIndex = 31;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(569, 162);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 39);
            txtPhone.TabIndex = 30;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 169);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 29;
            label1.Text = "Phone";
            label1.Click += label1_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(1015, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 28;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtcountry
            // 
            txtcountry.Location = new Point(588, 89);
            txtcountry.Name = "txtcountry";
            txtcountry.Size = new Size(200, 39);
            txtcountry.TabIndex = 25;
            // 
            // txtcity
            // 
            txtcity.Location = new Point(569, 18);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(128, 39);
            txtcity.TabIndex = 24;
            txtcity.TextChanged += txtprice_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(176, 162);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(96, 39);
            txtLastName.TabIndex = 23;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(210, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(144, 39);
            txtFirstName.TabIndex = 22;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(80, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(94, 39);
            txtID.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 96);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 19;
            label5.Text = "Country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 25);
            label4.Name = "label4";
            label4.Size = new Size(58, 32);
            label4.TabIndex = 18;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 169);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 17;
            label3.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 96);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 16;
            label2.Text = "FirstName";
            // 
            // lablel1
            // 
            lablel1.AutoSize = true;
            lablel1.Location = new Point(21, 29);
            lablel1.Name = "lablel1";
            lablel1.Size = new Size(40, 32);
            lablel1.TabIndex = 15;
            lablel1.Text = "ID";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 762);
            Controls.Add(panel1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThem;
        private TextBox txtcountry;
        private TextBox txtcity;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lablel1;
        private TextBox txtPhone;
        private Label label1;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView dgvCustomer;
        private Button btnClear;
        // private DataGridView dgvCustomer;
    }
}