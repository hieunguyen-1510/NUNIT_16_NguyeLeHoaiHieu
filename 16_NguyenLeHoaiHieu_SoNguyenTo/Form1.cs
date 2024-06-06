using System;
using System.Windows.Forms;

namespace _16_NguyenLeHoaiHieu_SoNguyenTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txta.Text = string.Empty;
            txtkq.Text = string.Empty;
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            int number;
            bool isNumber = int.TryParse(txta.Text, out number);

            if (isNumber)
            {
                PrimeChecker_16_NguyenLeHoaiHieu ck = new PrimeChecker_16_NguyenLeHoaiHieu(number);
                int kq = ck.IsPrime(number);

                if (kq == 1)
                {
                    txtkq.Text = $"{number} là số nguyên tố";
                }
                else
                {
                    txtkq.Text = $"{number} không phải là số nguyên tố";
                }
            }
            else
            {
                txtkq.Text = "Vui lòng nhập số nguyên hợp lệ!";
            }
        }
    }
}
