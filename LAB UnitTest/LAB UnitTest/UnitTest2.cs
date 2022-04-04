using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;

namespace LAB_UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_AssignmentClass_1()
        {
            AssignmentClass assignmentClass = new AssignmentClass();
            int input = 1020;
            string result = assignmentClass.greadCalculate(input);
            Assert.AreEqual("A", result);

            result = assignmentClass.greadCalculate(-1);
            Assert.AreEqual("F", result);
        }
        [TestMethod]
        public void Test_Assignment_2()
        {
            AssignmentClass assignmentClass = new AssignmentClass();
            double result = assignmentClass.getDistance(3, 2, 7, 8);
            Assert.AreEqual(7.21 ,result);
            result = assignmentClass.getDistance(-3, 2, 7, -8);
            Assert .AreEqual(14.14 , result);
        }
        [TestMethod]
        public void Test_Assignment_3()
        {
            AssignmentClass assignmentClass = new AssignmentClass();
            string Password1 = "abc";
            int Password2 = 123;
            string Password22 = Convert.ToString(Password1);
            bool password = assignmentClass.checkPassword(Password1, Password22);
            Assert.AreEqual (false, password);
        }
    }
}
