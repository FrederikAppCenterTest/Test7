using Microsoft.VisualStudio.TestTools.UnitTesting;
using App12.viewModel;
using System;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 enT = new Class1();
            Console.WriteLine("2 da maxx");
            Assert.AreEqual(enT.AllesKlar(), true);
        }
    }
}
