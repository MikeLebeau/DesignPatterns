using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarSystem;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class SolarSystemTest
    {
        [TestMethod]
        public void ShouldContainsOnlyOneSun()
        {
            var firstSun = Sun.getInstance();
            var secondSun = Sun.getInstance();
            
            Assert.AreEqual(secondSun, firstSun);
        }
    }
}
