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
    public partial class Quantity : Form
    {
      public   int quantity;
        public Quantity()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
           quantity = Convert.ToInt32(textBox1.Text);
            this.Close();
        }
    }
}
