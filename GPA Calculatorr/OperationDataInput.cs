using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_Calculatorr
{
   
    public class OperationDataInput
    {
        public int TotalCourseUnitReg;
        public int TotalCourseUnitPassed;
        public int TotalWeightPt;
        public decimal GPA;
        public void DataInput()
        {
            Console.WriteLine("------------------------GPA Calculator---------------------\n\n");



            Validation validation = new Validation();
            List<PropertyStore> courses = new List<PropertyStore>();

            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine(userName);


            while (true)
            {


                Console.WriteLine("Enter Course Code: ");
                string courseCode = Console.ReadLine();
                string validatedCourseCode = validation.CourseCode(courseCode);

                Console.WriteLine("Enter Course Unit");
                string courseUnit = Console.ReadLine();
                int validatedCourseUnit = Convert.ToInt32(validation.CourseUnit(courseUnit));

                Console.WriteLine("Enter Score");
                string score = Console.ReadLine();
                int validatedScore = Convert.ToInt32(validation.ValidateScore(score));

                PropertyStore propertyStore = new PropertyStore()
                {
                    CourseCode = validatedCourseCode,
                    CourseUnit = validatedCourseUnit,
                    Score = validatedScore
                };

                propertyStore.Calculation();

                courses.Add(propertyStore);

                Console.WriteLine("Input 1 to enter more courses, input 2 to calculate");
                string code = Console.ReadLine();
                validation.Command(code);

                if (code == "1")
                {
                    Console.Clear();
                }
                else if (code == "2")
                {
                    break;
                }
            }

            Console.Clear();
            PrintTable.PrintLine();
            PrintTable.PrintRow("COURSE  CODE", "COURSE UNIT", "GRADE", "GRADE UNIT", "WEIGHT Pt", "REMARK");
            PrintTable.PrintLine();
            foreach (PropertyStore property in courses)
            {
                PrintTable.PrintRow(property.CourseCode, property.CourseUnit.ToString(), property.Grade, property.GradeUnit.ToString(), property.WeightPt.ToString(), property.Remarks);
                TotalCourseUnitReg += property.CourseUnit;
                TotalWeightPt += property.WeightPt;
                if (property.GradeUnit > 0)
                {
                    TotalCourseUnitPassed += property.CourseUnit;
                }
            }
            GPA = Convert.ToDecimal(TotalWeightPt / TotalCourseUnitReg);
            PrintTable.PrintLine();
            Console.WriteLine("\n\n");



            Console.WriteLine("Total Course Unit Registered is {0}", TotalCourseUnitReg);
            Console.WriteLine("\n");
            Console.WriteLine("Total Course Unit Passed is {0}", TotalCourseUnitPassed);
            Console.WriteLine("\n");
            Console.WriteLine("Total Weight Point is {0}", TotalWeightPt);
            Console.WriteLine("\n");
            Console.WriteLine("Your GPA is {0} to 2 decimal places", Decimal.Round(GPA, 2));
        }
    }
    
}
