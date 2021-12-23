#### Exem Score
A student has already answered *answered[i]* questions in each of the the *i^th* subjects, and still has time to answer a total of q more questions overall. 
For each *i^th* subject, the number of questions answered has to be at least neededpjin order to pass Determine the maximum number of 
subjects the student can pass if the q additional answered questions are optimally distributed among the subjects.

For example, there are *n = 2* subjects and *needed = [4, 5]* answered questions, respectively, to pass. The student has answered *answered = [2, 4]* questions 
in the two subjects so far. and can answer another *q = 1* questions in all subjects combined. The best outcome is tcranswer an additional question in the second 
subject to pass it. and it is not possible to pass the first subject. The maximum number of subjects that can be passed is *1*.

Function Description
Complete the function maxSubjectsNumber in the editor below. The function must return an integer that represents the maximum number of subjects that can be passed.
maxSubjectsNumberhas the following parameter(s):
answered[answered[0]f... answered[n-1]]: an array of integers
needed[needed[0]f...needed[n-l]]: an array of integers q an integer

Constraints
1 ≤ n ≤ 10⁵
0 ≤ answered[i], needed[i]; q ≤ 10⁹
