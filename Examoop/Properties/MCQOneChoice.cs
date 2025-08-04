using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class MCQOneChoice : QuestionBase
    {
        public MCQOneChoice(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
            : base(header, body, mark)
        {
            Answers = answers;
            RightAnswer = rightAnswer;
        }

        public override void Show()
        {
            Console.WriteLine(this);
            foreach (var ans in Answers)
                Console.WriteLine(ans);
        }
    }
}
