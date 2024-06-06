using System;
using System.Windows.Forms;

namespace NuNitTest_16_NguyenLeHoaiHieu
{
    public class PhuongTrinhBacNhat_16_NguyenLeHoaiHieu
    {
        private int a_16_NguyenLeHoaiHieu;
        private int b_16_NguyenLeHoaiHieu;

        public PhuongTrinhBacNhat_16_NguyenLeHoaiHieu(int a, int b)
        {
            this.a_16_NguyenLeHoaiHieu = a_16_NguyenLeHoaiHieu;
            this.b_16_NguyenLeHoaiHieu = b_16_NguyenLeHoaiHieu;
        }

        public void GiaiPhuongTrinh_16_NguyenLeHoaiHieu()
        {
            if (a_16_NguyenLeHoaiHieu == 0)
            {
                if (b_16_NguyenLeHoaiHieu == 0)
                {
                    MessageBox.Show("Phuong trinh vo so nghiem");
                }
                else
                {
                    MessageBox.Show("Phuong trinh vo nghiem");
                }
            }
            else
            {
                int x = -b_16_NguyenLeHoaiHieu / a_16_NguyenLeHoaiHieu;
                MessageBox.Show($"Phuong trinh co nghiem la: {x}");
            }
        }
        public double PhuongTrinh_16_NguyenLeHoaiHieu(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    throw new ArgumentException("Phuong trinh vo so nghiem");
                }
                else
                {
                    throw new ArgumentException("Phuong trinh vo nghiem");
                }
            }
            else
            {
                return -b / a;
            }
        }
    }
}
