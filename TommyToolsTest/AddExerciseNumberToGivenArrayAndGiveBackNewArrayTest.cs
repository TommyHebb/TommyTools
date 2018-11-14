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
        public void Test001IfEmptyGivenArrayReturnsArrayWithExerciseNumber()
        {
            int exerciseNumber = 5;
            int[] givenArray = new int[0];
            int[] resultArray = consoleTools.AddExerciseNumberToGivenArrayAndGiveBackNewArray(exerciseNumber, givenArray);
            Assert.AreEqual(exerciseNumber, resultArray[0]);
            Assert.AreEqual(1, resultArray.Length);
        }

        [TestMethod]
        public void Test002IfFilledGivenArrayReturnsGivenArrayWithExerciseNumberAdded()
        {
            int exerciseNumber = 5;
            int[] givenArray = new int[3];
            givenArray[0] = 1;
            givenArray[1] = 2;
            givenArray[2] = 3;
            int[] resultArray = consoleTools.AddExerciseNumberToGivenArrayAndGiveBackNewArray(exerciseNumber, givenArray);
            Assert.AreEqual(exerciseNumber, resultArray[3]);
            Assert.AreEqual(4, resultArray.Length);
        }
    }
}
