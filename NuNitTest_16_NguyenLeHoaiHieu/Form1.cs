using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuNitTest_16_NguyenLeHoaiHieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txta.Text);
            int b = Convert.ToInt32(txtb.Text);
            string kq;
            if (a == 0)
            {
                if (b == 0)
                {
                    MessageBox.Show("PTVSN");
                }
                else
                {
                    MessageBox.Show("PTVN");
                }
            }
            else
            {
                int x = (-b / a);
                txtkq.Text = x.ToString();
            }

        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txta.Text = " ";
            txtb.Text = " ";
            txtkq.Text = " ";

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
