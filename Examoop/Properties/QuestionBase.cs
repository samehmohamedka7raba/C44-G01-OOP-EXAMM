using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ExaminationSystem
{
    public abstract class QuestionBase : ICloneable, IComparable<QuestionBase>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; } = new Answer(0, "");

        public QuestionBase(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void Show();

        public object Clone() => this.MemberwiseClone();

        public int CompareTo(QuestionBase other) => this.Mark.CompareTo(other.Mark);

        public override string ToString() => $"{Header} - {Body} (Marks: {Mark})";
    }
}
