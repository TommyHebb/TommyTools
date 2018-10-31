using NUnit.Framework;
using System;

namespace TommyTools.Test
{
    [TestFixture]
    public class GetSpecificExercisesToRunTest
    {
        [Test]
        public void ShouldReturnAtLeastArrayWithOneElementBeing0()
        {
            int[] expectedResult = ConsoleTools.GetSpecificExercisesToRun();
            Assert.That(expectedResult[0], Is.EqualTo(0));
        }
    }
}
