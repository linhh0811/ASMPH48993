using BLL;
using DAL;
using DTO;
using DTO.Models;
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
    public partial class BanHang : Form
    {
        //private CustomerDAL _customerService;
        private int indexdangchon;
        DataTable dt = new DataTable();
        ProductBLL _productBLL = new ProductBLL();
        CustomerBLL customerBLL = new CustomerBLL();
        SupplierRes _supplierBll = new SupplierRes();
        List<int> _lstcustomer = new List<int>();
        private int _idCellClickListPro;
        private int _idCellClickChosePro;

        private decimal _total = 0;
        List<Fakedataorer> _lstFDO = new List<Fakedataorer>();

        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)

        {
            LoadGrid();
        }
        // danh sach customer

        public void LoadGrid()
        {

            //int stt = 1;

            dgvListpr.ColumnCount = 7;

            //dgvListpr.Columns[0].Name = "STT";
            dgvListpr.Columns[0].Name = "ID";
            dgvListpr.Columns[1].Name = "ProductName";
            dgvListpr.Columns[2].Name = "SupplierName";
            dgvListpr.Columns[3].Name = "UnitPrice";
            dgvListpr.Columns[4].Name = "Package";
            dgvListpr.Columns[5].Name = "IsDiscontinued";

            dgvListpr.Rows.Clear();

            foreach (var item in _productBLL.GetAllProduct())
            {
                var nameSupplier = _supplierBll.GetById(item.SupplierId).CompanyName;
                dgvListpr.Rows.Add(item.Id, item.ProductName, nameSupplier, item.UnitPrice, item.Package, item.IsDiscontinued == true ? "Hoat Dong" : "Khong Hoat Dong");
                foreach (DataGridViewRow row in dgvListpr.Rows)
                {
                    if (row.Cells[6].Value == "Khong Hoat Dong")
                    {
                        row.Visible = false;
                    }
                }
            }
            foreach (var item in customerBLL.GetAllCustomer())
            {
                cbbDSKH.Items.Add(item.FirstName);
                _lstcustomer.Add(item.Id);

                cbbDSKH.SelectedIndex = 0;
            }

        }

        private void dgvListpr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void loadGridChose()
        {
            dgvDangChon.Rows.Clear();

            dgvDangChon.ColumnCount = 5;

            dgvDangChon.Columns[0].Name = "Id";
            dgvDangChon.Columns[1].Name = "ProductName";
            dgvDangChon.Columns[2].Name = "quantity";
            dgvDangChon.Columns[3].Name = "Total";
            dgvDangChon.Columns[4].Name = "Delete";

            foreach (var item in _lstFDO)
            {
                dgvDangChon.Rows.Add(item.ID, item.name, item.quantity, item.price);

            }
        }
        private void TotalBill()
        {
            _total = 0;

            if (_lstFDO.Count == 0)
            {
                txtTongTien.Text = "0";
            }

            for (int i = 0; i < _lstFDO.Count; i++)
            {
                _total += _lstFDO[i].price;
            }

            txtTongTien.Text = _total.ToString();


        }
        private void dgvSPDangChon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int newQuantity = Convert.ToInt32(dgvDangChon.Rows[e.RowIndex].Cells[0].Value);
            decimal newTotal = Convert.ToDecimal((_productBLL.GetById(_idCellClickListPro).UnitPrice) * newQuantity);
            var obj = _lstFDO.Where(x => x.ID == _idCellClickChosePro).FirstOrDefault();
            if (obj != null)
            {
                obj.quantity = newQuantity;
                obj.price = newTotal;
            }
            TotalBill();
            loadGridChose();
        }
        private void dgvSPDangChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idCellClickChosePro = Convert.ToInt32(dgvDangChon.Rows[e.RowIndex].Cells[0].Value);
        }

        private void dgvListpr_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvListpr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _idCellClickListPro = Convert.ToInt32(dgvListpr.Rows[e.RowIndex].Cells[0].Value);
            string namePro = dgvListpr.Rows[e.RowIndex].Cells[1].Value.ToString();
            Quantity quantity = new Quantity();
            quantity.ShowDialog();
            int soLuong = quantity.quantity;
            decimal total = Convert.ToDecimal((_productBLL.GetById(_idCellClickListPro).UnitPrice) * soLuong);
            Fakedataorer FDO = new Fakedataorer()
            {
                ID = _lstFDO.Count + 1,
                productId = _idCellClickListPro,
                name = namePro,
                quantity = soLuong,
                price = total,
            };

            _lstFDO.Add(FDO);
            TotalBill();
            loadGridChose();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //private void button1_Click(object sender, EventArgs e)
            //{
            //    Order order = new Order()
            //    {
            //        OrderDate = DateTime.Now.Date,
            //        CustomerId = _lstcustomer[cbbDSKH.SelectedIndex],
            //        TotalAmount = _total
            //    };

            //    if (OrderBLL.Create(order))
            //    {
            //        int check = 0;
            //        for (int i = 0; i < _lstFDO.Count; i++)
            //        {
            //            decimal unitPrice1 = Convert.ToDecimal(_productBLL.GetById(_lstFDO[i].productId).UnitPrice);

            //            OrderItem item = new OrderItem()
            //            {
            //                OrderId = order.Id,
            //                Quantity = _lstFDO[i].quantity,
            //                ProductId = _lstFDO[i].productId,
            //                UnitPrice = unitPrice1
            //            };

            //            or.Create(item);
            //            check++;
            //        }
            //        if (check == _lstFDO.Count)
            //        {
            //            MessageBox.Show("Oder thanh cong");
            //            _lstFDO.Clear();
            //            _total = 0;
            //            TotalBill();
            //            LoadGrid();
            //        }

            //    }
        }
    }
}




