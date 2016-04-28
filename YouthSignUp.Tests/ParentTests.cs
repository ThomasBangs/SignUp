using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouthSignUp.Models;

namespace YouthSignUp.Tests
{
    /// <summary>
    ///Arrange, Act, Assert
    /// </summary>
    [TestClass]
    public class ParentTests
    {
        [TestMethod]
        public void ParentEnsureThatAnInstanceCanBeCreated()
        {
            //Arrange
            Parent parent = new Parent();
            //Assert
            Assert.IsNotNull(parent);

        }
        [TestMethod]
        public void ParentTestParentFirstName()
        {
            Parent parent = new Parent { FirstName = "Betty", Address = "231 Jones Rd", LastName = "Smith"};
            Assert.AreEqual("Betty", parent.FirstName);
            Assert.AreEqual("Smith", parent.LastName);
            Assert.AreEqual("231 Jones Rd", parent.Address);
        }
        

    

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

      
    }
}
