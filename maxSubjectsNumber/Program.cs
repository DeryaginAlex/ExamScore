using System;
using System.Collections.Generic;

namespace ExamScore {
    class Program {
        static void Main(string[] args) {
            var calculator = new DisciplinesСalculator();
            var numPointsReceived = new List<int> { 24, 27, 0 };
            var numPointsRequired = new List<int> { 51, 52, 100 };
            var numQuestions = 100;
            Console.WriteLine(calculator.GetMaxNumber(numPointsReceived, numPointsRequired, numQuestions));
        }
    }
}