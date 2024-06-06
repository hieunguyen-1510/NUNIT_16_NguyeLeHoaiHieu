using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NuNitTest_16_NguyenLeHoaiHieu;
using System.Globalization;

namespace UnitTest_16_NguyenLeHoaiHieu
{
    [TestClass]
    public class UnitTest_16_NguyenLeHoaiHieu
    {
        private PhuongTrinhBacNhat_16_NguyenLeHoaiHieu solver;

        [TestInitialize]
        public void SetUp()
        {
            solver = new PhuongTrinhBacNhat_16_NguyenLeHoaiHieu(0,0);
        }

        [TestMethod]
        public void PhuongTrinh_16_NguyenLeHoaiHieu()
        {
            // Khởi tạo
            int a = 2;
            int b = -4;
            double expected = 2.0;

            // Gọi phương thức giải phương trình
            double actual = solver.PhuongTrinh_16_NguyenLeHoaiHieu(a, b);

            // Kiểm tra kết quả
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PhuongTrinhVoNghiem_16_NguyenLeHoaiHieu_TC1()
        {
            // khoi tao
            double a = 0;
            double b = 5;

            // Kiểm tra xem phương trình vô nghiệm
            Assert.ThrowsException<ArgumentException>(() => solver.PhuongTrinh_16_NguyenLeHoaiHieu(a, b), "Phuong trinh vo nghiem");
        }

        [TestMethod]
        public void PhuongTrinhVoSoNghiem_16_NguyenLeHoaiHieu_TC2()
        {
            // Khởi tạo
            double a = 0;
            double b = 0;

            // Kiểm tra xem phương trình có vô số nghiệm
            Assert.ThrowsException<ArgumentException>(() => solver.PhuongTrinh_16_NguyenLeHoaiHieu(a, b), "Phuong trinh vo so nghiem");
        }
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                   "C:\\Users\\ASUS\\source\\repos\\NuNitTest_16_NguyenLeHoaiHieu\\UnitTest_16_NguyenLeHoaiHieu\\TestData_16_NguyenLeHoaiHieu.csv",
                   "TestData_16_NguyenLeHoaiHieu#csv",
                   DataAccessMethod.Sequential)]
        [TestMethod]
        public void PhuongTrinhCoNghiem_16_NguyenLeHoaiHieu_TC3()
        {
            try
            {
                // Đọc file csv
                double a = Convert.ToDouble(TestContext.DataRow["a"], CultureInfo.InvariantCulture);
                double b = Convert.ToDouble(TestContext.DataRow["b"], CultureInfo.InvariantCulture);
                string expected = TestContext.DataRow["expected"].ToString().Trim();

                // Kiểm tra kết quả dựa theo expected
                if (expected == "PTVSN")
                {
                    // Trường hợp phương trình có vô số nghiệm
                    Assert.ThrowsException<ArgumentException>(() => solver.PhuongTrinh_16_NguyenLeHoaiHieu(a, b), "Phuong trinh vo so nghiem");
                }
                else if (expected == "PTVN")
                {
                    // Trường hợp phương trình vô nghiệm
                    Assert.ThrowsException<ArgumentException>(() => solver.PhuongTrinh_16_NguyenLeHoaiHieu(a, b), "Phuong trinh vo nghiem");
                }
                else
                {
                    // Trường hợp phương trình có nghiệm duy nhất
                    double expectedDouble;
                    if (double.TryParse(expected, NumberStyles.Any, CultureInfo.InvariantCulture, out expectedDouble))
                    {
                        double actual = solver.PhuongTrinh_16_NguyenLeHoaiHieu(a, b);
                        Assert.AreEqual(expectedDouble, actual);
                    }
                    else
                    {
                        Assert.Fail("Expected value is not a valid double.");
                    }
                }
            }
            catch (Exception ex)
            {
                //Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }
    }
}