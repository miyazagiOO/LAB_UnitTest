using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;

namespace LAB_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Add()
        {
            MyMath myMath = new MyMath();
            int result = myMath.Add(1, 2);
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void TestMethod_Add2()
        {
            MyMath myMath = new MyMath();
            int result = myMath.Add(11, 22);
            Assert.AreEqual(result, 33);
        }
    }
}
