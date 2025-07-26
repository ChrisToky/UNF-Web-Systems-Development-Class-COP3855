using System;
using static System.Console;

namespace MathOperationQuiz
{
    //Global variable are assigned the summary of operations done
    static class GlobalVariables
    {   public static int numberOfMultiAskedQstOverall = 0;
        public static int numberOfDivAskedQstOverall = 0;
        public static int numberOfMultiCrtAnswersOverall = 0;
        public static int numberOfDivCrtAnswersOverall = 0;

    }
    public class Student
    {
        private string name;
        private int gradeLevel;
        private int operatorChoice;

        //will be assigned the total number of correct answers
        int returnMultiCorrectAnswers = 0;
        int returnDivCorrectAnswers = 0;
        //will be assigned the total number asqued questions
        int numberOfMultiAskedQuestion;
        int numberOfDivAskedQuestion;      

        //Constructor
        public Student()
        {

        }

        //Constructor with 2 arguments
        public Student(string sName, int sGradeLevel, int sOperatorChoice)
        {
            name = sName;
            gradeLevel = sGradeLevel;
            operatorChoice = sOperatorChoice;
        }

        //Constructor for operator sign
        public Student(char operatorSign)
        {
            operatorChoice = operatorSign;
        }

        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int GradeLevel
        {
            get
            {
                return gradeLevel;
            }
            set
            {
                gradeLevel = value;
            }
        }

        public int OperatorChoice
        {
            get
            {
                return operatorChoice;
            }
            set
            {
                operatorChoice = value;
            }
        }

        //Return an operation when choose an option
        public string GetOperatorType()
        {
            string operatorType;
            switch (operatorChoice)
            {
                case 1:
                    operatorType = "Multiplication";
                    break;
                case 2:
                    operatorType = "Division";
                    break;
                default:
                    operatorType = "Non applicant. By Default is Multipliaction";
                    break;
            }

            return operatorType;
        }

        //return number of questions by Grade applied
        public int  NumberOfQuestionByGrade()
        {
            int numberOfQuestion = 0;

            if (gradeLevel == 1)
            {
                numberOfQuestion = 3;
            }
            else
            {
                if (gradeLevel == 2)
                {
                    numberOfQuestion = 5;
                }
                if (gradeLevel == 3)
                {
                    numberOfQuestion = 8;
                }
                if (gradeLevel == 4)
                {
                    numberOfQuestion = 10;
                }
                if (gradeLevel == 5)
                {
                    numberOfQuestion = 15;
                }
            }

            return numberOfQuestion;
        } 

        //calculate total number of correct answers for each operation
        public void MathCalculation(int operSign)
        {            
            WriteLine("\nWe will be quizzing you on {0} skills at the k-{1} level. " +
                  "When you are ready to take the quiz, press any key to continue", GetOperatorType(), gradeLevel);

            ReadKey();

            Clear();            
            int numberOfQuestion = 0;
            string operationName = "times";
            decimal firstRand = 1;
            int secondRand = 1;
            Random rand = new Random();

            //assign variables
            //displays operation type and number of questions in Console.WriteLine
            if (operSign == 1)
            {
                numberOfQuestion = NumberOfQuestionByGrade(); //return number of question for each Grade

                operationName = "times";
                WriteLine("You will be tested in {0} skills. We will ask {1} questions.", GetOperatorType(), numberOfQuestion);
            }
            else 
            {
                if (operSign == 2)
                {
                    numberOfQuestion = NumberOfQuestionByGrade();
                    operationName = "by";
                    WriteLine("You will be tested in {0} skills. We will ask {1} questions. " +
                        "\nYour answer must be correct up to 2 decimal points.", GetOperatorType(), numberOfQuestion);
                }
                    
            }
            


            for (int i = 1; i <= numberOfQuestion; i++)
            {
                decimal correctResult = 0;
                string inputAnswer;
                decimal outputAnswer;
                bool result;

                //1 == Multiplication
                //2 == Division
                //using random number to calculate answer
                if (operSign == 1)
                {
                    if (gradeLevel == 1)
                    {
                        firstRand = rand.Next(1, 10);
                        secondRand = rand.Next(1, 10);
                        correctResult = firstRand * secondRand;
                    }
                    if (gradeLevel == 2)
                    {
                        firstRand = rand.Next(11, 20);
                        secondRand = rand.Next(11, 20);
                        correctResult = firstRand * secondRand;
                    }
                    if (gradeLevel == 3)
                    {
                        firstRand = rand.Next(21, 30);
                        secondRand = rand.Next(21, 30);
                        correctResult = firstRand * secondRand;
                    }
                    if (gradeLevel == 4)
                    {
                        firstRand = rand.Next(31, 40);
                        secondRand = rand.Next(31, 40);
                        correctResult = firstRand * secondRand;
                    }
                    if (gradeLevel == 5)
                    {
                        firstRand = rand.Next(41, 50);
                        secondRand = rand.Next(41, 50);
                        correctResult = firstRand * secondRand;
                    }
                    
                    
                }
                else if (operSign == 2)
                {
                    if (gradeLevel == 1)
                    {
                        firstRand = rand.Next(1, 10);
                        secondRand = rand.Next(1, 10);
                        correctResult = Math.Truncate( (firstRand / secondRand)*100 )/100;
                    }
                    if (gradeLevel == 2)
                    {
                        firstRand = rand.Next(11, 20);
                        secondRand = rand.Next(11, 20);
                        correctResult = Math.Truncate((firstRand / secondRand) * 100) / 100;
                    }
                    if (gradeLevel == 3)
                    {
                        firstRand = rand.Next(21, 30);
                        secondRand = rand.Next(21, 30);
                        correctResult = Math.Truncate((firstRand / secondRand) * 100) / 100;
                    }
                    if (gradeLevel == 4)
                    {
                        firstRand = rand.Next(31, 40);
                        secondRand = rand.Next(31, 40);
                        correctResult = Math.Truncate((firstRand / secondRand) * 100) / 100;
                    }
                    if (gradeLevel == 5)
                    {
                        firstRand = rand.Next(41, 50);
                        secondRand = rand.Next(41, 50);
                        correctResult = Math.Truncate((firstRand / secondRand) * 100) / 100;
                    }
                    
                }
                
                Write($"\nQuestion number {i} : How much is {firstRand} {operationName} {secondRand} ?: ");
                inputAnswer = ReadLine(); //Give option to enter the answer

                //check if the entered number can be parsed
                result = decimal.TryParse(inputAnswer, out outputAnswer) == false;
                WriteLine();

                if (result)
                {
                    WriteLine("The entered value is not a number. So, 0 will be used as provided answer");
                    WriteLine();
                }

                //compare the entred answered by the user and the correct one
                if (correctResult == outputAnswer)
                {
                    if (operSign == 1)
                    {
                        returnMultiCorrectAnswers += 1;
                        WriteLine($"Nice work {name}");
                    }
                    else
                    {
                        if (operSign == 2)
                        {
                            returnDivCorrectAnswers += 1;
                            WriteLine($"Nice work {name}");
                        }
                    }
                        
                }
                else
                {
                    WriteLine("Wrong. The correct answer is: {0}", correctResult);
                }

                if (i == (numberOfQuestion - 1) )
                {
                    WriteLine("\nYour last question.");
                }

                //assign the total number of the asked queations for each operation
                if (operSign == 1)
                {
                    numberOfMultiAskedQuestion = i;
                }
                else
                {
                    if (operSign == 2)
                    {
                        numberOfDivAskedQuestion = i;
                    }
                }
            }

            //Global variable get the final answers
            GlobalVariables.numberOfMultiAskedQstOverall += numberOfMultiAskedQuestion;
            GlobalVariables.numberOfMultiCrtAnswersOverall += returnMultiCorrectAnswers;
            GlobalVariables.numberOfDivAskedQstOverall += numberOfDivAskedQuestion;
            GlobalVariables.numberOfDivCrtAnswersOverall += returnDivCorrectAnswers;
        }

        displays summary
        public override string ToString()
        {
            return "\n\nName: " + name +
            "\nGrade: " + gradeLevel +
            "\n\nNumber of Multiplication question asked: " + GlobalVariables.numberOfMultiAskedQstOverall +
            "\nNumber of Multiplication question correctly answered: " + GlobalVariables.numberOfMultiCrtAnswersOverall +
            "\n\nNumber of Division question asked: " + GlobalVariables.numberOfDivAskedQstOverall +
            "\nNumber of Division question correctly answered: " + GlobalVariables.numberOfDivCrtAnswersOverall;
        }

    }
}