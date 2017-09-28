using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SD_Lab_01_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual( 3, SD_Lab_01_Console.TaskSolution.RunTaskA(1, 2, 3));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(20, SD_Lab_01_Console.TaskSolution.RunTaskB(1, 2, 3));         
        }
        [TestMethod]
        public void TestMethod3()
        {         
            Assert.AreEqual( 6, SD_Lab_01_Console.TaskSolution.RunTaskC(3, 4, 5));
        }

    }
}
