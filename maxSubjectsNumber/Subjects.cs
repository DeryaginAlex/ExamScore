using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemScore {
    public class Subjects {
        public int maxSubjectsNumber(List<int> answered, List<int> needed, int q) {
            List<int> CanAnswer = new List<int>() {};
            for(int i = 0 ; i < answered.Count; i++) {
                CanAnswer.Add(needed[i] - answered[i]);
            }
            CanAnswer.Sort();

            int result = 0;

            for(int i = 0 ; i < CanAnswer.Count ; i++) {
                if(q > CanAnswer[i])
                    result++;
                q = q - CanAnswer[i];
            }
            return result;
        }
    }
}
