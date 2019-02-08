using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateClassLibrary;

namespace DateUnitTestProject
{
    [TestClass]
    public class UnitTestDate
    {
        [TestMethod]
        public void TestMethod_DateConstructor()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.IsNotNull(aDate, "UclDate Constructor is not working");
        }
        [TestMethod]
        public void TestMethod_GetDay()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.AreEqual(6, aDate.GetDay());
        }
        [TestMethod]
        public void TestMethod_GetMonth()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.AreEqual(2, aDate.GetMonth());
        }
        [TestMethod]
        public void TestMethod_GetDatoStringYMMDD()
        {
            UclDate aDate = new UclDate(2019, 2, 6);
            Assert.AreEqual("2019-02-06", aDate.GetDatoStringYMD());
        }
        [TestMethod]
        public void TestMethod_MoveToPrevDate()
        {
            UclDate aDate = new UclDate(2019, 12, 1);
            aDate.MoveToPrevDate();

            Assert.AreEqual("2019-11-30", aDate.GetDatoStringYMMDDAlternativ());
        }
        [TestMethod]
        public void TestMethod_GetDatoStringYMMDDAlternativ()
        {
            UclDate aDate = new UclDate(2019, 12, 20);
            aDate.MoveToPrevDate();

            Assert.AreEqual("2019-12-19", aDate.GetDatoStringYMMDDAlternativ());
        }
        [TestMethod]
        public void TestMethod_SetDay()
        {
            UclDate aDate = new UclDate(2019, 12, 20);
            aDate.SetDay(19);

            Assert.AreEqual("2019-12-19", aDate.GetDatoStringYMMDDAlternativ());
        }
        [TestMethod]
        public void TestMethod_SetYear()
        {
            UclDate aDate = new UclDate(2019, 12, 20);
            aDate.SetYear(2018);

            Assert.AreEqual(2018, aDate.GetYear());
        }
        [TestMethod]
        public void TestMethod_GetMonthTXT()
        {
            UclDate aDate = new UclDate(2019, 8, 20);
            aDate.GetQuaterTxt();
            Assert.AreEqual("August", aDate.GetMonthTxt());
        }
        [TestMethod]
        public void TestMethod_GetQuater()
        {
            UclDate aDate = new UclDate(2019, 4, 20);
            Assert.AreEqual("April kvartal", aDate.GetQuaterTxt());
        }


    }
}
