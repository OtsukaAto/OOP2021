using System.Collections.Generic;

namespace Test01 {
    internal class ScoreCounterBase {
        private readonly IEnumerable<Student> scores;
        private IEnumerable<Student> _scores;


        //メソッドの概要： 科目別に点数を求める
        private static IEnumerable<Student> ReadScore(string filePath)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var score in _scores) {
                if (dict.ContainsKey(score.Subject))
                    dict[score.Subject] += score.Score;
                else
                    dict[score.Subject] = score.Score;
            }
        }
    }
}