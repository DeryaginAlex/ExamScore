using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamScore {
    public class Subjects {
        public int maxSubjectsNumber(List<int> answered, List<int> needed, int q) {
            List<int> CanAnswer = new List<int>() {};
            for(int i = 0 ; i < answered.Count; i++) {
                CanAnswer.Add(needed[i] - answered[i]);
            }
            CanAnswer.Sort();
            int result = 0;
            foreach(var item in CanAnswer) {  
                if(q > item) {
                    result++;
                }
                q -= item;
            }
            return result;
        }
    }
}
