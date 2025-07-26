using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;

namespace MathOperationQuiz
{
    class SPerfomance
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo stop2; //will be used to stop the app
            ConsoleKeyInfo changeGrade; //will be used to change the grade level

            DisplayInformation(); //Displays App's info

            string sName = GetStudentName(); //Assigns the student name
            int sGradeLevel = GetGradeLevel(); //assigns a student grade level           


            AppreciateUser(sName); //Displays appreciation of using the App

            //Process to stop the App when press S or any other key to continue playing
            do {                               
                Clear();
                int sOperatorChoice = OperatorChoice();

                Student student = new Student(sName, sGradeLevel, sOperatorChoice);

                student.MathCalculation(sOperatorChoice);

                WriteLine("\nTo stop the Quiz, press s . To display Menu options, press any key.");
                stop2 = ReadKey(true);   
                
                //Check if the entered key is S to stop the App
                if(stop2.Key == ConsoleKey.S)
                {
                    Clear();
                    WriteLine(student);
                    ReadKey();
                }
                else
                {
                    //when app keep running,
                    //Ask if change the grade
                    Clear();
                    WriteLine("Do you want change a Grade Level ? " +
                        "\nTo chaange a Grade, press Y or any Key to use the same Grade: ");
                    changeGrade = ReadKey(true);
                    if(changeGrade.Key == ConsoleKey.Y)
                    {
                        sGradeLevel = GetGradeLevel();
                    }
                    else
                    {
                        WriteLine("\n\nGrade is not changed" +
                            "\nYour are using the same picked Grade Level: {0}", sGradeLevel);
                    }
                    
                }

            } while (stop2.Key != ConsoleKey.S); //if pressed key != S, the App keep running

        }

        //Purpose of the Application
        public static void DisplayInformation()
        {
            WriteLine("Welcome to the Multiplication and Division Tutor App!" +
                "\n\nThis app will ask questions on basic multiplication and division skills that an elementary student should master.");
        }

        //defines the student name
        public static string GetStudentName()
        {
            WriteLine("\nWe would like to get some basic information about you.");
            Write("\nTo get started, please provide your fullname: ");

            string inputName = ReadLine();

            return inputName;
        }

        //defines a student grade
        public static int GetGradeLevel()
        {
           
            int[] grade = {1,2,3,4,5};
            int gradeLevel = 1;
            string inputGradeLevel;
            bool result;
                        
            //The app continue asking the grade until you provide the write grade (positive number in [1 to 5 ]
            do
            {
                WriteLine("\n--Your Grade will determine The Multiplication/Division K-level and Number of questions--" +
                    "\n\tGrade 1 : 3  Questions in [1 to 10] numbers" +
                    "\n\tGrade 2 : 5  Questions in [11 to 20] numbers" +
                    "\n\tGrade 3 : 8  Questions in [21 to 30] numbers" +
                    "\n\tGrade 4 : 10 Questions in [31 to 40] numbers" +
                    "\n\tGrade 5 : 15 Questions in [41 to 50] numbers");
                Write("Enter your Grade Level. Numbers:[ 1 to 5 ]: ");
                inputGradeLevel = ReadLine();
                WriteLine();

                result = int.TryParse(inputGradeLevel, out gradeLevel) == false;

                //The grade must be a positive number contains in the interval [1 to 5] 
                if ( (result == false && !grade.Contains(gradeLevel) ) || gradeLevel == 0 ) 
                {
                    WriteLine("\nYour Grade Level must be a positive number 1 to 5 ");
                    WriteLine();
                    result = false;
                }
                else
                {
                    result = true;                       
                }

            } while (result == false);

            return gradeLevel;
        }

        public static void AppreciateUser(in string sName)
        {
            WriteLine("\n{0}, we appreciate using the Multiplicaton and Division Tutor App. " +
                "When you are ready to be tested on Math skills, press any key to continue. ", sName);
            ReadKey();

        }

        public static int OperatorChoice()
        {
            string inputValue;
            int inputValue2;
            int[] inputOperator = { 1, 2 };
            bool result;           

            //Check if the user provides a right option. 1 or 2 to choose an operation type
            do { 
                WriteLine("Specify the Math skill that you like to be tested. The following are your options:");
                WriteLine("Multiplication - Enter 1");
                WriteLine("Divison - Enter 2");
                Write("\nEnter your Math quiz option: ");

                inputValue = ReadLine();
                result = int.TryParse(inputValue, out inputValue2) == false;

                if (result == false && !inputOperator.Contains(inputValue2) || inputValue2 == 0)
                {                    
                    WriteLine("\nYour Option must be a number and in [ 1 to 2 ]");
                    result = false;
                }
                else
                {
                    result = true;
                }
            } while (result == false);

            return inputValue2;
        }

    }
}
