using System.Collections.Generic;

namespace ExamScore {
    public class DisciplinesСalculator {
        public int GetMaxNumber(List<int> numPointsReceived, List<int> numPointsRequired, int numQuestions) {
            List<int> tempList = new List<int>() { };
            for(int i = 0 ; i < numPointsReceived.Count ; i++) {
                tempList.Add(numPointsRequired[i] - numPointsReceived[i]);
            }
            tempList.Sort();
            int result = 0;
            foreach(var item in tempList) {
                if(numQuestions > item) {
                    result++;
                }
                numQuestions -= item;
            }
            return result;
        }
    }
}