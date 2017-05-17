using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           Assert.AreEqual(20, CalcHelper.Class1.SumOfTwoInt(10, 10), "Sum of two integers is wrong");
        }
    }
}
