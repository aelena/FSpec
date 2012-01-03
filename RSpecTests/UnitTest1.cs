using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RSpecTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Call_Describe_Function()
        {
            FSpec.SimpleFunctions.describe("test message for describe");
        }

        [TestMethod]
        public void Test_Create_Description()
        {
            FSpec.Core.Description description = new FSpec.Core.Description("test message");
            Assert.AreEqual("test message", description.Message); 
        }



    }
}
