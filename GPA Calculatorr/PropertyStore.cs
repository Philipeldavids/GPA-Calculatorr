using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_Calculatorr
{
    public class PropertyStore
    {

        public string CourseCode;
        public int CourseUnit;
        public int Score;
        public string Grade;
        public int GradeUnit;
        public int WeightPt;
        public string Remarks;
        

        public void Calculation()
        {

            if (Score >= 70 && Score <= 100)
            {
                Grade = "A";
                GradeUnit = 5;
                Remarks = "Excellent";
            }
            else if (Score >= 60 && Score <= 69)
            {
                Grade = "B";
                GradeUnit = 4;
                Remarks = "Very Good";
            }
            else if (Score >= 50 && Score <= 59)
            {
                Grade = "C";
                GradeUnit = 3;
                Remarks = "Good";
            }
            else if (Score >= 45 && Score <= 49)
            {
                Grade = "D";
                GradeUnit = 2;
                Remarks = "Fair";
            }
            else if (Score >= 40 && Score <= 44)
            {
                Grade = "E";
                GradeUnit = 1;
                Remarks = "Pass";
            }
            else if (Score >= 0 && Score <= 39)
            {
                Grade = "F";
                GradeUnit = 0;
                Remarks = "Fail";
            }
            WeightPt = CourseUnit * GradeUnit;
        }
    }
}
