using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCoreApp;
using System;

namespace SampleCoreApp_Test
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod()]
        public void SucessesTest()
        {
                SampleApp code = new SampleApp();
                var result = code.Perform(10);
                Assert.AreEqual("10", result);           
            
        }


        [TestMethod()]
        public void ExceptionTest()
        {
                SampleApp code = new SampleApp();
                var result = code.Perform(-1);
                Assert.AreEqual("Error", result);
        }
    }
}
