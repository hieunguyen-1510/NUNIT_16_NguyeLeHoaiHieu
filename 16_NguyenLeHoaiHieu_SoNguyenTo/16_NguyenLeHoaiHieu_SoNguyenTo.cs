using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_NguyenLeHoaiHieu_SoNguyenTo
{
    public class _16_NguyenLeHoaiHieu_SoNguyenTo
    {
        private int number;
        public _16_NguyenLeHoaiHieu_SoNguyenTo(int number)
        {
            this.number = number;
        }
        public int SoNguyenTo_16_NguyenLeHoaiHieu(int number)
        {
            if (number <= 1)
            {
                return 0; // Số nhỏ hơn hoặc bằng 1 không phải là snt
            }
            if (number == 2)
            {
                return 1; // Số lớn hơn 1 và chia hết cho chính nó là snt
            }
            if (number % 2 == 0)
            {
                return 0; // Số chẵn chia hết cho 2, lớn hơn 2 cũng không phải là snt
            }
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return 0; // Số chia hết cho bất kỳ số nào khác 1 không là snt
                }
            }
            return 1; // Còn lại các trường hợp khác là snt
        }
    }
}
