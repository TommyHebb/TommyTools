using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TommyTools;

namespace TommyToolsTest
{
    [TestClass]
    public class AddExerciseNumberToGivenArrayAndGiveBackNewArrayTest
    {
        private ConsoleTools consoleTools;

        [TestInitialize]
        public void Initialize()
        {
            consoleTools = new ConsoleTools();
        }

        [TestMethod]
        public void ReturnsAtLeastCount1()
        {
            int[] givenArray = new int[0];
            Assert.AreEqual(1, consoleTools.AddExerciseNumberToGivenArrayAndGiveBackNewArray(0, givenArray).Length);
        }
        
        [TestMethod]
        public void IfExerciseNumber0AndEmptyGivenArrayReturnsArrayWith0()
        {
            int[] givenArray = new int[0];
            Assert.AreEqual(0, consoleTools.AddExerciseNumberToGivenArrayAndGiveBackNewArray(0, givenArray)[0]);
        }
        
    }
}
