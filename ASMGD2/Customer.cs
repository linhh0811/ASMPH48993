using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using DAL;

namespace ASMGD2
{
    public partial class Customer : Form

    {
        CustomerBLL customerBLL = new CustomerBLL();
        DataTable dt = new DataTable();

        public Customer()
        {
            InitializeComponent();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("City", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Phone", typeof(string));

            LuoiViet();


            dgvCustomer.DataSource = dt;

        }
        private void LuoiViet()
        {
            var customer = customerBLL.GetAllCustomer();
            foreach (var ct in customer)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = ct.Id;
                dr["FirstName"] = ct.FirstName;
                dr["LastName"] = ct.LastName;
                dr["City"] = ct.City;
                dr["Country"] = ct.Country;
                dr["Phone"] = ct.Phone;
                dt.Rows.Add(dr);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            dt.Clear();
            try
            {

                int maSua = Convert.ToInt32(txtID.Text);
                if (customerBLL.CheckExists(maSua))
                {
                    DialogResult ds = MessageBox.Show("Ban co chac chan muon sua khong?"
                        , "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    string message = customerBLL.UpdateCustomer(Convert.ToInt32(txtID.Text), txtFirstName.Text, txtLastName.Text, txtcity.Text, txtcountry.Text, txtPhone.Text);
                    MessageBox.Show(message, "Canh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("M", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi:" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LuoiViet();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.Clear();

            string message = customerBLL.CreateCustomer(txtFirstName.Text, txtLastName.Text, txtcity.Text, txtcountry.Text, txtPhone.Text);
            MessageBox.Show(message, "Canh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LuoiViet();
        }

        //private void dgvcustomer(object sender, datagridviewcelleventargs e)
        //{

        //}

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgvCustomer.Rows[e.RowIndex];
            txtID.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtFirstName.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtLastName.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtcity.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtcountry.Text = dataGridViewRow.Cells[4].Value.ToString();
            txtPhone.Text = dataGridViewRow.Cells[5].Value.ToString();


        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            //txtID.Clear();
            //txtFirstName.Clear();
            //txtLastName.Clear();
            //txtcity.Clear();
            //txtcountry.Clear();
            //txtPhone.Clear();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dt.Clear();
            int idXoa = Convert.ToInt32(txtID.Text);
            if (customerBLL.CheckExists(idXoa))
            {
                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {

                    string message = customerBLL.DeleteCustomer(idXoa);
                    MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LuoiViet();

                }
            }
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //}
    }
}

