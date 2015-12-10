using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouthSportsRegistration.Models;


namespace YouthSportsRegistration.Tests
{
    [TestClass]
    public class ChildTest
    {
        [TestMethod]
        public void ChildEnsureThatICanCreateInstance()
        {
            Child player = new Child();
            Assert.IsNotNull(player);
        }
    }
}
