using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMGD2
{
    public partial class Order : Form
    {
        OrderBLL orderBLL = new OrderBLL();
        DataTable dt = new DataTable();
        public Order()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            dt.Clear();
            int idXoa = Convert.ToInt32(txtID.Text);
            if (orderBLL.CheckExists(idXoa))
            {
                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {

                    string message = orderBLL.DeleteOrder(idXoa);
                    MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LuoiViet();

                }
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("OrderDate", typeof(DateTime));
            dt.Columns.Add("OrderNumber", typeof(string));
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Columns.Add("TotalAmount", typeof(decimal));

            LuoiViet();


            dgvorder.DataSource = dt;

        }
        private void LuoiViet()
        {
            var order = orderBLL.GetAllOrder();
            foreach (var or in order)
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = or.Id;
                dr["OrderDate"] = or.OrderDate;
                dr["OrderNumber"] = or.OrderNumber;
                dr["CustomerId"] = or.CustomerId;
                dr["TotalAmount"] = or.TotalAmount;

                dt.Rows.Add(dr);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dt.Clear();
            try
            {

                int maSua = Convert.ToInt32(txtID.Text);
                if (orderBLL.CheckExists(maSua))
                {
                    DialogResult ds = MessageBox.Show("Ban co chac chan muon sua khong?"
                        , "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    string message = orderBLL.UpdateOrder(Convert.ToInt32(txtID.Text), DateTime.ParseExact(dateTimePiker.Text.Trim(), "dd-MM-yyyy", null), 
                        txtOrderNumber.Text,Convert.ToInt32(txtCustomerid.Text), Convert.ToDecimal(txttotal.Text));
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
            string message = orderBLL.CreateOrder(dateTimePiker.Value, txtOrderNumber.Text, Convert.ToInt32(txtCustomerid.Text), Convert.ToDecimal(txttotal.Text));
            MessageBox.Show(message, "Canh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LuoiViet();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

    }
}

