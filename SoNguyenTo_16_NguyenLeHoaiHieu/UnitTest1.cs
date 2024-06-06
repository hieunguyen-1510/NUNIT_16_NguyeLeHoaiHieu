using _16_NguyenLeHoaiHieu_SoNguyenTo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoNguyenTo_16_NguyenLeHoaiHieu
{
    [TestClass]
    public class UnitTest1
    {
        private PrimeChecker_16_NguyenLeHoaiHieu checker;

        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod]
        public void TC1_SNT_16_NguyenLeHoaiHieu()
        {
            int number = 2;
            checker = new PrimeChecker_16_NguyenLeHoaiHieu(number);
            int expected = 1; // 2 là số nguyên tố
            int actual = checker.IsPrime(number);
            Assert.AreEqual(expected, actual); // So sánh kết quả thực tế với kết quả mong đợi
        }

        [TestMethod]
        public void TC2_SNT_16_NguyenLeHoaiHieu()
        {
            int number = 4;
            checker = new PrimeChecker_16_NguyenLeHoaiHieu(number);
            int expected = 0; // 4 không phải là số nguyên tố
            int actual = checker.IsPrime(number);
            Assert.AreEqual(expected, actual); // So sánh kết quả thực tế với kết quả mong đợi
        }

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                  "C:\\Users\\ASUS\\source\\repos\\NuNitTest_16_NguyenLeHoaiHieu\\SoNguyenTo_16_NguyenLeHoaiHieu\\DataSNT_16_NguyenLeHoaiHieu.csv",
                  "DataSNT_16_NguyenLeHoaiHieu#csv",
                  DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC3_SNT_16_NguyenLeHoaiHieu()
        {
            int number = Convert.ToInt32(TestContext.DataRow[0]);
            int expected = Convert.ToInt32(TestContext.DataRow[1]);

            checker = new PrimeChecker_16_NguyenLeHoaiHieu(number);
            int actual = checker.IsPrime(number);

            Assert.AreEqual(expected, actual); // So sánh kết quả thực tế với kết quả mong đợi
        }

    }
}
