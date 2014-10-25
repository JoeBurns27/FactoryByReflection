using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jebur27.Security;
using Jebur27.FactoryBase.Exceptions;
using Jebur27.Security.Factory;
using Jebur27.Security.Interfaces;

namespace Test
{
    [TestClass]
    public class SecurityFactoryTests2
    {
        [TestMethod]
        public void TestGetSecurityManagerOne()
        {
            Factory target = new Factory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerOne");
            SecurityManagerOne securityManagerOne = new SecurityManagerOne();
            Assert.AreEqual(securityManager.GetType(), securityManagerOne.GetType());
        }

        [TestMethod]
        public void TestGetSecurityManagerTwo()
        {
            Factory target = new Factory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerTwo");
            SecurityManagerTwo securityManagerOne = new SecurityManagerTwo();
            Assert.AreEqual(securityManager.GetType(), securityManagerOne.GetType());
        }

        [TestMethod]
        public void TestGetSecurityManagerOneSetUserName()
        {
            Factory target = new Factory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerOne");
            string userName = "Jebur27";
            securityManager.UserName = userName;
            Assert.AreEqual(securityManager.UserName, userName);
        }

        [TestMethod]
        public void TestGetSecurityManagerTwoSetUserName()
        {
            Factory target = new Factory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerTwo");
            string userName = "Jebur27";
            securityManager.UserName = userName;
            Assert.AreEqual(securityManager.UserName, userName);
        }

        [TestMethod]
        public void TestGetSecurityManagerOneSetUserLevel()
        {
            Factory target = new Factory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerOne");
            int userSecurityLevel = 3;
            securityManager.UserSecurityLevel = userSecurityLevel;
            Assert.AreEqual(securityManager.UserSecurityLevel, userSecurityLevel);
        }

        [TestMethod]
        public void TestGetSecurityManagerTwoSetUserLevel()
        {
            Factory target = new Factory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerTwo");
            int userSecurityLevel = 3;
            securityManager.UserSecurityLevel = userSecurityLevel;
            Assert.AreEqual(securityManager.UserSecurityLevel, userSecurityLevel);
        }

        [TestMethod]
        public void TestGetSecurityManagerOneWithOneParameter()
        {
            Factory target = new Factory();
            string userName = "Jebur27";
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerOne", userName);
            SecurityManagerOne securityManagerOne = new SecurityManagerOne();
            Assert.AreEqual(securityManager.UserName, userName);
        }

        [TestMethod]
        public void TestGetSecurityManagerTwoWithOneParameter()
        {
            Factory target = new Factory();
            string userName = "Jebur27";
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerTwo", userName);
            SecurityManagerTwo securityManagerOne = new SecurityManagerTwo();
            Assert.AreEqual(securityManager.UserName, userName);
        }

        [TestMethod]
        public void TestGetSecurityManagerOneWithTwoParameters()
        {
            Factory target = new Factory();
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
            Factory target = new Factory();
            string userName = "Jebur27";
            int userSecurityLevel = 3;
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.SecurityManagerTwo", userName, userSecurityLevel);
            SecurityManagerTwo securityManagerOne = new SecurityManagerTwo();
            Assert.AreEqual(securityManager.UserName, userName);
            Assert.AreEqual(securityManager.UserSecurityLevel, userSecurityLevel);
        }

        [TestMethod]
        [ExpectedException(typeof(TypeNotFoundFactoryException))]
        public void TestGetSecurityManagerFail1()
        {
            Factory target = new Factory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.DoesNotExist");
        }

        [TestMethod]
        [ExpectedException(typeof(TypeNotFoundFactoryException))]
        public void TestGetSecurityManagerFail2()
        {
            string userName = "Jebur27";
            Factory target = new Factory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.DoesNotExist", userName);
        }

        [TestMethod]
        [ExpectedException(typeof(TypeNotFoundFactoryException))]
        public void TestGetSecurityManagerFail3()
        {
            string userName = "Jebur27";
            int userSecurityLevel = 3;
            Factory target = new Factory();
            ISecurityManager securityManager = target.GetSecurityManager("Jebur27.Security.DoesNotExist", userName, userSecurityLevel);
        }

    }
}
