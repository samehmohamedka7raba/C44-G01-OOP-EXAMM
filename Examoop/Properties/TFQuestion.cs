using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class TFQuestion : QuestionBase
    {
        public TFQuestion(string header, string body, int mark)
            : base(header, body, mark)
        {
            Answers = new Answer[]
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };
        }

        public override void Show()
        {
            Console.WriteLine(this);
            foreach (var ans in Answers)
                Console.WriteLine(ans);
        }
    }
}
