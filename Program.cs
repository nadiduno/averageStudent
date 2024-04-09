using System;

class Program
{
    static void Main()
    {
        int[,] grade = new int[,]
         {
            { 93, 87, 98, 95, 100 },
            { 80, 83, 82, 88, 85 },
            { 84, 96, 73, 85, 79 },
            { 90, 92, 98, 100, 97 }
        };
        string[] student = { "Sophia", "Nicolas", "Zahirah", "Jeong" };
        double[] averageStudent = new double[grade.GetLength(0)];
        string[] category = new string[grade.GetLength(0)];

        for (int i = 0; i < grade.GetLength(0); i++)
        {
            double sum = 0;
            for (int j = 0; j < grade.GetLength(1); j++)
            {
                sum += grade[i, j];
            }
            averageStudent[i] = (double)sum / grade.GetLength(1);
        }
        Console.WriteLine("Student\tGrade");
        for (int i = 0; i < averageStudent.Length; i++)
        {
            if (averageStudent[i] >= 90)
                category[i] = "A";
            else if (averageStudent[i] >= 80)
                category[i] = "B";
            else
                category[i] = "C";
            Console.WriteLine($"{student[i]}\t{averageStudent[i]}\t{category[i]}");
        }

    }
}