using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASMGD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productMenuItem_Click(object sender, EventArgs e)
        {
            Product productForm = new Product();
            productForm.ShowDialog();
        }

        private void customerMenuItem_Click(object sender, EventArgs e)
        {
            Customer customerForm = new Customer();
            customerForm.ShowDialog();
        }

        private void orderMenuItem_Click(object sender, EventArgs e)
        {
            Order orderForm = new Order();
            orderForm.ShowDialog();
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            banHang.Show();
        }

        private void formBanHangMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void banHang1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //menu.Visible = true;
        }

































        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang banHangForm = new BanHang();
            banHangForm.ShowDialog();

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          // toolStripContainer1.Controls.Remove();
        }
    }
}
