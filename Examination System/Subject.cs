using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Subject
    {
        public Subject(int subjectId, string sublectName)
        {
            SubjectId = subjectId;
            SublectName = sublectName;
        }

        public int SubjectId { get; set; }
        public string SublectName { get; set; }

        public Exam exam;

        public void CreateExame()
        {
            int typeOfExam;
            bool flag;

            do
            {
                Console.Write("Please Enter The Type Of Exam You Want To Create ( 1 For Practical And 2 For Final ): ");
                flag = int.TryParse(Console.ReadLine(), out typeOfExam);

            } while (flag == false);

            
            int TimeOfExam;

            do
            {
                Console.WriteLine("Please Enter The Time Of Exam In Minutes");
                flag = int.TryParse(Console.ReadLine(), out TimeOfExam);

            } while (flag == false);

            
            int NumberOfQuestions;

            do
            {
                Console.WriteLine("Please Enter The Number Of Questions You Want To Create");
                flag = int.TryParse(Console.ReadLine(), out NumberOfQuestions);

            } while (flag == false);
            Console.Clear();

            if (typeOfExam == 2)
            {
                exam = new Final_Exam(TimeOfExam, NumberOfQuestions);
                int typeOfQuestion;
                string questionBody;
                int questionMark;
               
                for (int i = 0; i < exam.Questions.Length; i++)
                {
                    
                    do 
                    {
                        Console.Write($"Please Choose The Type Of Question Number {i + 1}\t( 1 For True Or False || 2 For MCQ ): ");
                        flag = int.TryParse(Console.ReadLine(), out typeOfQuestion);
                    } while (flag == false);
                    Console.Clear() ;

                    if (typeOfQuestion == 1)
                    {
                        
                        Console.WriteLine("True Or False Question");
                        Console.WriteLine("Please Enter The Body Of The Question: ");
                        questionBody = Console.ReadLine();
                        
                        do
                        {
                            Console.Write("Please Enter The Mark Of Question: ");
                            flag = int.TryParse(Console.ReadLine(),out questionMark);

                        } while (flag == false);

                        int rightanswerIndex;
                        do 
                        {
                            Console.WriteLine("Please Enter The Right Answer Of The Question ( 1 For True,  2 For False )");
                            flag = int.TryParse(Console.ReadLine(), out rightanswerIndex);

                        } while (flag == false);

                        Answer[] answersList =
                        {
                            new Answer(1, "True"),
                            new Answer(2, "False"),
                        };


                        exam.Questions[i] = new True_Or_False(questionBody, questionMark, rightanswerIndex - 1, answersList);

                        Console.Clear();
                    }
                    else if (typeOfQuestion == 2)
                    {
                        Console.WriteLine("Choose One Answer Question");
                        Console.WriteLine("Please Enter The Body Of The Question: ");
                        questionBody = Console.ReadLine();

                        do
                        {
                            Console.Write("Please Enter The Mark Of Question: ");
                            flag = int.TryParse(Console.ReadLine(), out questionMark);

                        } while (flag == false);

                        Console.WriteLine("The Choices Of The Question:");
                        string[] choices = new string[3];
                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine($"Please Enter The Choice Number {j + 1}: ");
                            choices[j] = Console.ReadLine();
                        }

                        int rightanswerIndex;
                        do
                        {
                            Console.WriteLine("Please Specify The Right Choice Of Question");
                            flag = int.TryParse(Console.ReadLine(), out rightanswerIndex);

                        } while (flag == false);


                        Answer[] answersList =
                        {
                            new Answer(1, choices[0]),
                            new Answer(2, choices[1]),
                            new Answer(2, choices[2]),
                        };

                        exam.Questions[i] = new MCQ(questionBody, questionMark, rightanswerIndex - 1, answersList);

                        Console.Clear();
                    }


                }

               
            }
            else if (typeOfExam == 1) 
            {
                exam = new Practical_Exam(TimeOfExam, NumberOfQuestions);

                
                string questionBody;
                int questionMark;

                for (int i = 0; i < exam.Questions.Length; i++)
                {
                    Console.WriteLine("Choose One Answer Question");
                    Console.WriteLine($"Please Enter The Body Of The Question {i + 1}: ");
                    questionBody = Console.ReadLine();

                    do
                    {
                        Console.Write("Please Enter The Mark Of Question: ");
                        flag = int.TryParse(Console.ReadLine(), out questionMark);

                    } while (flag == false);

                    Console.WriteLine("The Choices Of The Question:");
                    string[] choices = new string[3];
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Please Enter The Choice Number {j + 1}: ");
                        choices[j] = Console.ReadLine();
                    }

                    int rightanswerIndex;
                    do
                    {
                        Console.WriteLine("Please Specify The Right Choice Of Question");
                        flag = int.TryParse(Console.ReadLine(), out rightanswerIndex);

                    } while (flag == false);


                    Answer[] answersList =
                    {
                            new Answer(1, choices[0]),
                            new Answer(2, choices[1]),
                            new Answer(2, choices[2]),
                        };

                    exam.Questions[i] = new MCQ(questionBody, questionMark, rightanswerIndex - 1, answersList);
                    Console.Clear();
                }
            }

            

        }



    }
}
