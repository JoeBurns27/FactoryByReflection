using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jebur27.Security;
using Jebur27.FactoryBase.Exceptions;
using Jebur27.Security.Factory;
using Jebur27.Security.Interfaces;

namespace Jebur27.Security.Test
{
    [TestClass]
    public class SecurityFactoryTests
    {
        [TestMethod]
        public void TestGetSecurityManagerOne()
        {
            SecurityFactory target = new SecurityFactory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerOne");
            SecurityManagerOne securityManagerOne = new SecurityManagerOne();
            Assert.AreEqual(securityManager.GetType(), securityManagerOne.GetType());
        }

        [TestMethod]
        public void TestGetSecurityManagerTwo()
        {
            SecurityFactory target = new SecurityFactory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerTwo");
            SecurityManagerTwo securityManagerOne = new SecurityManagerTwo();
            Assert.AreEqual(securityManager.GetType(), securityManagerOne.GetType());
        }

        [TestMethod]
        public void TestGetSecurityManagerOneWithOneParameter()
        {
            SecurityFactory target = new SecurityFactory();
            string userName = "Jebur27";
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerOne", userName);
            SecurityManagerOne securityManagerOne = new SecurityManagerOne();
            Assert.AreEqual(securityManager.UserName, userName);
        }

        [TestMethod]
        public void TestGetSecurityManagerTwoWithOneParameter()
        {
            SecurityFactory target = new SecurityFactory();
            string userName = "Jebur27";
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerTwo", userName);
            SecurityManagerTwo securityManagerOne = new SecurityManagerTwo();
            Assert.AreEqual(securityManager.UserName, userName);
        }

        [TestMethod]
        public void TestGetSecurityManagerOneWithTwoParameters()
        {
            SecurityFactory target = new SecurityFactory();
            string userName = "Jebur27";
            int userSecurityLevel = 3;
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerOne", userName, userSecurityLevel);
            SecurityManagerOne securityManagerOne = new SecurityManagerOne();
            Assert.AreEqual(securityManager.UserName, userName);
            Assert.AreEqual(securityManager.UserSecurityLevel, userSecurityLevel);
        }

        [TestMethod]
        public void TestGetSecurityManagerTwoWithTwoParameters()
        {
            SecurityFactory target = new SecurityFactory();
            string userName = "Jebur27";
            int userSecurityLevel = 3;
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerTwo", userName, userSecurityLevel);
            SecurityManagerTwo securityManagerOne = new SecurityManagerTwo();
            Assert.AreEqual(securityManager.UserName, userName);
            Assert.AreEqual(securityManager.UserSecurityLevel, userSecurityLevel);
        }

        [TestMethod]
        [ExpectedException(typeof(TypeNotFoundFactoryException))]
        public void TestGetSecurityManagerFail()
        {
            SecurityFactory target = new SecurityFactory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.DoesNotExist");
            SecurityManagerOne securityManagerOne = new SecurityManagerOne();
            Assert.AreEqual(securityManager.GetType(), securityManagerOne.GetType());
        }

    }
}
