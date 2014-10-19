using Jebur27.FactoryBase;
using Jebur27.FactoryBase.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    
    
    /// <summary>
    ///This is a test class for FactoryBaseTest and is intended
    ///to contain all FactoryBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FactoryBaseTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for GetNamedType
        ///</summary>
        [TestMethod()]
        public void GetNamedTypeTest()
        {
            TestProtectedMethods target = new TestProtectedMethods();

            Type testType = typeof(Jebur27.Security.Interfaces.ISecurityManager);
            string typeName = "Jebur27.Security.SecurityManagerOne";
            Type actual;
            actual = target.GetNamedTypeTest(typeName, testType); 
            Assert.AreEqual(typeName, actual.FullName);
        }

        /// <summary>
        ///A test for GetNamedType
        ///</summary>
        [TestMethod()]
        public void GetNamedTypeTest2()
        {
            TestProtectedMethods target = new TestProtectedMethods();
            string typeName = "Jebur27.Security.SecurityManagerOne";
            Type actual;
            actual = target.GetNamedTypeTest(typeName, this.GetType());
            Assert.AreEqual(typeName, actual.FullName);
        }

        [TestMethod()]
        public void TypeNotFoundFactoryExceptionTest1()
        {
            string typeName = "TestTypeName";
            TypeNotFoundFactoryException target = new TypeNotFoundFactoryException(typeName);
            Assert.AreEqual(typeName, target.TypeName);
        }

        [TestMethod()]
        public void TypeNotFoundFactoryExceptionTest2()
        {
            string typeName = "TestTypeName";
            string message = "Error Message";
            TypeNotFoundFactoryException target = new TypeNotFoundFactoryException(typeName, message);
            Assert.AreEqual(typeName, target.TypeName);
            Assert.AreEqual(message, target.Message);
        }

        [TestMethod()]
        public void TypeNotFoundFactoryExceptionTest3()
        {
            string typeName = "TestTypeName";
            string message = "Error Message";
            ArgumentException argumentException = new ArgumentException();
            TypeNotFoundFactoryException target = new TypeNotFoundFactoryException(typeName, message, argumentException);
            Assert.AreEqual(typeName, target.TypeName);
            Assert.AreEqual(message, target.Message);
            Assert.AreEqual(argumentException.GetType(), target.InnerException.GetType());
        }

        protected class TestProtectedMethods : BaseFactory
        {
            public Type GetNamedTypeTest(string typeName, Type typeOfCaller)
            {
                return GetNamedType(typeName, typeOfCaller);
            }
        }

    }

}
