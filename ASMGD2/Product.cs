using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using BLL;
using DAL;
using DTO.Models;

namespace ASMGD2
{

    public partial class Product : Form
    {
        ProductBLL productBLL = new ProductBLL();
        SupplierService spService = new SupplierService();
        DataTable dt = new DataTable();

        public Product()
        {
            InitializeComponent();
        }

        public void Product_Load(object sender, EventArgs e)
        {

            load();
        }
        public void load()
        {
            //dt.Columns.Add("Id", typeof(int));
            //dt.Columns.Add("ProductName", typeof(string));
            //dt.Columns.Add("SupplierId", typeof(int));
            //dt.Columns.Add("UnitPrice", typeof(decimal));
            //dt.Columns.Add("Package", typeof(string));
            //dt.Columns.Add("IsDiscontinued", typeof(bool));
            //var product = productBLL.GetAllProduct();
            //foreach (var pr in product)
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["Id"] = pr.Id;
            //    dr["ProductName"] = pr.ProductName;
            //    dr["SupplierId"] = pr.SupplierId;
            //    dr["UnitPrice"] = pr.UnitPrice;
            //    dr["Package"] = pr.Package;
            //    dr["IsDiscontinued"] = pr.IsDiscontinued;
            //    dt.Rows.Add(dr);
            //}

            var result = from pr in productBLL.GetAllProduct()
                         join sup in spService.GetAllSup()
                         on pr.SupplierId equals sup.Id
                         select new
                         {
                             pr.Id,
                             pr.ProductName,
                             pr.SupplierId,
                             pr.UnitPrice,
                             pr.Package,
                             pr.IsDiscontinued,

                         };
            //var result = sinhVienService.GetAllSvSer().Select(x =>
            //        new { x.MaSv, x.TenSv, x.Tuoi, x.GioiTinh, x.MaLop }).ToList();



            dgvProduct.DataSource = result.ToList();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgvProduct.Rows[e.RowIndex];
            txtID.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtName.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtsid.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtprice.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtpack.Text = dataGridViewRow.Cells[4].Value.ToString();

            if (Convert.ToBoolean(dataGridViewRow.Cells[5].Value) == true)
                rdb0.Checked = true;
            if (Convert.ToBoolean(dataGridViewRow.Cells[5].Value) == false)
                rdb1.Checked = true;

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            dt.Clear();
            try
            {

                int maSua = Convert.ToInt32(txtID.Text);
                if (productBLL.CheckExists(maSua))
                {
                    DialogResult ds = MessageBox.Show("Ban co chac chan muon sua khong?"
                        , "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    string check;
                    if (rdb0.Checked == true)
                    {
                        check = "0";
                    }
                    else
                        check = "1";
                    bool status = (check == "1");
                    string message = productBLL.UpdateProduct(Convert.ToInt32(txtID.Text), txtName.Text, Convert.ToInt32(txtsid.Text), Convert.ToDecimal(txtprice.Text), txtpack.Text, status);
                    MessageBox.Show(message, "Canh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("M", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi:" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            load();

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string check;
            if (rdb0.Checked == true)
            {
                check = "0";
            }
            else
                check = "1";
            bool status = (check == "1");
            string message = productBLL.CreateProduct(txtName.Text, Convert.ToInt32(txtsid.Text), Convert.ToDecimal(txtprice.Text), txtpack.Text, status);
            MessageBox.Show(message, "Canh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load();

        }

        //private void dgvProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow dataGridViewRow = dgvProduct.Rows[e.RowIndex];
        //    txtID.Text = dataGridViewRow.Cells[0].Value.ToString();
        //    txtName.Text = dataGridViewRow.Cells[1].Value.ToString();
        //    txtsid.Text = dataGridViewRow.Cells[2].Value.ToString();
        //    txtprice.Text = dataGridViewRow.Cells[3].Value.ToString();
        //    txtpack.Text = dataGridViewRow.Cells[4].Value.ToString();

        //    if (Convert.ToBoolean(dataGridViewRow.Cells[5].Value) == true)
        //        rdb0.Checked = true;
        //    if (Convert.ToBoolean(dataGridViewRow.Cells[5].Value) == false)
        //        rdb1.Checked = true;
        //}

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow dataGridViewRow = dgvProduct.Rows[e.RowIndex];
            txtID.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtName.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtsid.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtprice.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtpack.Text = dataGridViewRow.Cells[4].Value.ToString();

            if (Convert.ToBoolean(dataGridViewRow.Cells[5].Value) == true)
                rdb0.Checked = true;
            if (Convert.ToBoolean(dataGridViewRow.Cells[5].Value) == false)
                rdb1.Checked = true;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {

            dt.Clear();
            int idXoa = Convert.ToInt32(txtID.Text);
            if (productBLL.CheckExists(idXoa))
            {
                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {

                    string message = productBLL.DeleteProduct(idXoa);
                    MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    load();

                }
            }

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            dt.Clear();
            try
            {

                int maSua = Convert.ToInt32(txtID.Text);
                if (productBLL.CheckExists(maSua))
                {
                    DialogResult ds = MessageBox.Show("Ban co chac chan muon sua khong?"
                        , "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    string check;
                    if (rdb0.Checked == true)
                    {
                        check = "0";
                    }
                    else
                        check = "1";
                    bool status = (check == "1");
                    string message = productBLL.UpdateProduct(Convert.ToInt32(txtID.Text), txtName.Text, Convert.ToInt32(txtsid.Text), Convert.ToDecimal(txtprice.Text), txtpack.Text, status);
                    MessageBox.Show(message, "Canh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("M", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi:" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            load();
        }
    }
}
