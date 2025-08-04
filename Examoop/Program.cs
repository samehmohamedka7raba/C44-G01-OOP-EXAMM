using ExaminationSystem;

namespace Examoop
{
    internal class Program
    {
        static void Main(string[] args)
      
    {
   
                Console.Write("Enter Subject ID: ");
                int subjectId = int.Parse(Console.ReadLine());
                Console.Write("Enter Subject Name: ");
                string subjectName = Console.ReadLine();
                Subject subject = new Subject(subjectId, subjectName);

                Console.Write("Enter Exam Type (1: Final, 2: Practical): ");
                int examType = int.Parse(Console.ReadLine());
                Console.Write("Enter Exam Time: ");
                int time = int.Parse(Console.ReadLine());
                Console.Write("Enter Number of Questions: ");
                int numQuestions = int.Parse(Console.ReadLine());

                Exam exam = examType == 1 ? new FinalExam(time, numQuestions) : new PracticeExam(time, numQuestions);

                for (int i = 0; i < numQuestions; i++)
                {
                    Console.WriteLine($"Enter data for Question {i + 1}:");
                    Console.Write("Enter Question Type (1: True/False, 2: MCQ): ");
                    int questionType = int.Parse(Console.ReadLine());
                    Console.Write("Enter Header: ");
                    string header = Console.ReadLine();
                    Console.Write("Enter Body: ");
                    string body = Console.ReadLine();
                    Console.Write("Enter Mark: ");
                    int mark = int.Parse(Console.ReadLine());

                    if (questionType == 1)
                    {
                        var tfq = new TFQuestion(header, body, mark);
                        Console.Write("Enter Right Answer (1: True, 2: False): ");
                        int ans = int.Parse(Console.ReadLine());
                        tfq.RightAnswer = tfq.Answers[ans - 1];
                        exam.Questions.Add(tfq);
                    }
                    else
                    {
                        Console.Write("Enter number of choices: ");
                        int numChoices = int.Parse(Console.ReadLine());
                        Answer[] answers = new Answer[numChoices];
                        for (int j = 0; j < numChoices; j++)
                        {
                            Console.Write($"Enter Answer {j + 1} Text: ");
                            answers[j] = new Answer(j + 1, Console.ReadLine());
                        }
                        Console.Write("Enter number of correct answer: ");
                        int right = int.Parse(Console.ReadLine());
                        var mcq = new MCQOneChoice(header, body, mark, answers, answers[right - 1]);
                        exam.Questions.Add(mcq);
                    }
                }

                subject.CreateExam(exam);
                subject.ShowExam();
            
        }
    }







}
    


    

