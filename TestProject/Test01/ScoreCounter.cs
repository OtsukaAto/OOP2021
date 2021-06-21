using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _scores;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _scores = ReadScore(filePath);
        }


        //メソッドの概要： 点数データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            
            var scores= new List<Student>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines) {
                var items = line.Split(',');
                var student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(student);
            }
            return scores;
        }

        //メソッドの概要： 科目別点数を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string,int>();
            foreach(var score in _scores) {
                if (dict.ContainsKey(score.Name))
                    dict[score.Name] += score.Score;
                else
                    dict[score.Name]  = score.Score;
            }
            return dict;
        }
    }
}
