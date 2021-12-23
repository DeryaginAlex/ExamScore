using System;
using System.Collections.Generic;

namespace MaxSubjectsNumber {
    class Program {
        static void Main(string[] args) {
            Subjects subjects = new Subjects();

            List<int> answered = new List<int>{ 24,27,0};
            List<int> needed = new List<int> { 51,52,100};
            int q = 100;

            int result = subjects.maxSubjectsNumber(answered, needed,q);
            Console.WriteLine(result);
        }
    }
}
