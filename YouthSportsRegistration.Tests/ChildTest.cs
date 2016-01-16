using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouthSportsRegistration.Models;


namespace YouthSportsRegistration.Tests
{
    [TestClass]
    public class ChildTest
    {
        private Child c;

        [TestInitialize]
        public void Setup()
        {
            c = new Child();
        }
        [TestMethod]
        public void ChildEnsureThatICanCreateInstance()
        {
           
            Assert.IsNotNull(c);
        }
        [TestMethod]
        public void ChildTestThatChildHasFirstName()
        {

        }
    }
}
