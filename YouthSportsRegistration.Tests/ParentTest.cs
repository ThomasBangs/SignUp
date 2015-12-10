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

        [TestMethod]
        public void ParentEnsureThatICanAddChildToList()
        {
            Parent parent = new Parent { FirstName="Betty"};
            Child child = new Child { FirstName = "Jimmy" };
            parent.Child_List.Add(child);

            Assert.AreEqual(1, parent.Child_List.Count);
            Assert.AreEqual(parent.FirstName, "Betty");
            Assert.AreEqual(child.FirstName, "Jimmy");
        }

        [TestMethod]
        public void ParentEnsureThatICanRemoveChild()
        {
            Parent parent = new Parent();
            Child child = new Child { FirstName="tommy",  Address= "231 amherst dr"};
            parent.Child_List.Add(child);

            parent.Child_List.Remove(child);

            Assert.AreEqual(0, parent.Child_List.Count);

        }


    }
}
