using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class PracticeExam : Exam
    {
        public PracticeExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("=== Practical Exam ===");
            foreach (var q in Questions)
            {
                q.Show();
                Console.WriteLine($"Correct Answer: {q.RightAnswer.AnswerText}\\n");
            }
        }
    }
}
