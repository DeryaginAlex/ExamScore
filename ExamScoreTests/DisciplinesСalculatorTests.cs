using NUnit.Framework;
using ExamScore;
using System.Collections.Generic;

namespace ExamScoreTests {
    [TestFixture]
    public class Disciplines—alculatorTests {
        static object[] testValue =
        {
        new object[] {
            new List<int> { 24, 27, 0 },
            new List<int> { 51, 52, 100 },
            100,
            2},
         new object[] {
            new List<int> { 25, 26, 0 },
            new List<int> { 50, 52, 100 },
            99,
            2}
         };
        [TestCaseSource(nameof(testValue))]
        public void GetMaxNumber_DefaultValue_Test(List<int> numPointsReceived, List<int> numPointsRequired, int numQuestions, int result) {
            Disciplines—alculator calculator = new Disciplines—alculator();

            Assert.AreEqual(result, calculator.GetMaxNumber(numPointsReceived, numPointsRequired, numQuestions));
        }
    }
}