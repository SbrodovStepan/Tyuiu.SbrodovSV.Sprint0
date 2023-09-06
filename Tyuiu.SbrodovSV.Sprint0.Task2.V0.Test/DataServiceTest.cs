using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SbrodovSV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SbrodovSV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Степан";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Степан", res);
        }
    }
}