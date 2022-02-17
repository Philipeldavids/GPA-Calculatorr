using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GPA_Calculatorr
{
    public class Validation
    {
        public string CourseCode(string code)
        {
            code = code.Trim();

            while (true)
            {
                Regex rgx = new Regex("[A-Za-z#]{3,3}[0-9]{3,3}");
                bool containsSpecialCharacter = rgx.IsMatch(code);
                if (containsSpecialCharacter)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nCourse code must be 6 characters: ");
                    Console.Write("\nCourse code must contain three letters and three digits: ");
                    code = Console.ReadLine();
                }
            }
            return code;
        }
        public string CourseUnit(string courseUnit)
        {
            courseUnit = courseUnit.Trim();
            while (true)
            {
                double unit;
                if (double.TryParse(courseUnit, out unit))
                {
                    if (Convert.ToInt32(courseUnit) >= 0 && Convert.ToInt32(courseUnit) <= 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid course unit, course unit must be between 0 - 5");
                        courseUnit = Console.ReadLine();
                    }
                }
                Console.WriteLine("Invalid input, please enter a number between 0 - 5");
                courseUnit = Console.ReadLine();
            }
            return courseUnit;
        }
        public string ValidateScore(string score)
        {
            score = score.Trim();
            while (true)
            {
                double unit;
                if (double.TryParse(score, out unit))
                {
                    if (Convert.ToInt32(score) >= 0 && Convert.ToInt32(score) <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid score, score must be between 0-100");
                        score = Console.ReadLine();
                    }
                }
                Console.WriteLine("Invalid Input, please input score between 0-100");
                score = Console.ReadLine();
            }
            return score;
        }
        public int Command(string code)
        {
            int num;
            while (true)
            {
                if (int.TryParse(code, out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input a valid number");
                    code = Console.ReadLine();

                }

            }
            return num;
        }

    }
}
