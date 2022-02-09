using NUnit.Framework;
using ExamScore;
using System.Collections.Generic;

namespace ExamScore {
    [TestFixture]
    public class MaxSubjectsNumberTests {
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
        public void Subjects_maxSubjectsNumber_defaultValueUsingTestCaseSource_Test(List<int> answered, List<int> needed, int q, int result) {
            Subjects subjects = new Subjects();
            Assert.AreEqual(result, subjects.maxSubjectsNumber(answered, needed, q));
        }
    }
}