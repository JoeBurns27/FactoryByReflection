using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jebur27.Security;
using Jebur27.FactoryBase.Exceptions;
using Jebur27.Security.Factory;
using Jebur27.Security.Interfaces;
using Jebur27.Security.Factory;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetSecurityManagerOne()
        {
            Factory target = new Factory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerOne");
            SecurityManagerOne securityManagerOne = new SecurityManagerOne();
            Assert.AreEqual(securityManager.GetType(), securityManagerOne.GetType());
        }

    }
}
