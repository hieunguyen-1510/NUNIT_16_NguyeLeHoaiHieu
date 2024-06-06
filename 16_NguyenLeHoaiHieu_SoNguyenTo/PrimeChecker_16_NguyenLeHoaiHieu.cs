using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_NguyenLeHoaiHieu_SoNguyenTo
{
    public class PrimeChecker_16_NguyenLeHoaiHieu
    {
        private int number_16_NguyenLeHoaiHieu;
        public PrimeChecker_16_NguyenLeHoaiHieu(int number_16_NguyenLeHoaiHieu)
        {
            this.number_16_NguyenLeHoaiHieu = number_16_NguyenLeHoaiHieu;
        }

        public int IsPrime(int number_16_NguyenLeHoaiHieu)
        {
            if (number_16_NguyenLeHoaiHieu <= 1) return 0; //  Số nhỏ hơn hoặc bằng 1 ko phải snt
            if (number_16_NguyenLeHoaiHieu == 2) return 1; // Số lớn hơn 1 và chia hết cho chính nó là snt
            if (number_16_NguyenLeHoaiHieu % 2 == 0) return 0; // Số chẵn chia hết cho 2,lớn hơn 2 cũng k phải là snt

            for (int i = 3; i * i <= number_16_NguyenLeHoaiHieu; i += 2)
            {
                if (number_16_NguyenLeHoaiHieu % i == 0) return 0; ;//Số chia hết cho bất kì số nào khác 1 là snt
            }
            return 1; ;// Còn lại các trường hợp khác là snt
        }
    }
}
