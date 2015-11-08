using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouthSportsRegistration.Models;
namespace YouthSportsRegistration.Tests
{
    [TestClass]
    public class ParentTest
    {
        [TestMethod]
        public void ParentEnsureICanCreatInstance()
        {
            Parent parent = new Parent();
            Assert.IsNotNull(parent);
        }
    }
}
