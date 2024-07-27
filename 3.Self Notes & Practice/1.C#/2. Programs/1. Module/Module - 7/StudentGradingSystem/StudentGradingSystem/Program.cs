using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double[] Grades { get; set; }

        // Constructor to initialize the object
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Grades = new double[5]; // Assuming 5 subjects
        }
    }

    public class GradingSystem
    {
        public static void Main()
        {
            // Create a student object
            Student student1 = new Student("John Doe", 20);

            // Assign grades
            student1.Grades[0] = 85;
            student1.Grades[1] = 78;
            student1.Grades[2] = 92;
            student1.Grades[3] = 87;
            student1.Grades[4] = 80;

            // Display student information
            Console.WriteLine($"Student Name: {student1.Name}");
            Console.WriteLine($"Student Age: {student1.Age}");

            // Calculate average grade
            double averageGrade = CalculateAverageGrade(student1.Grades);
            Console.WriteLine($"Average Grade: {averageGrade}");

            // Evaluate performance
            EvaluatePerformance(student1.Grades);
        }

        // Method to calculate average grade
        public static double CalculateAverageGrade(double[] grades)
        {
            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Length;
        }

        // Method to evaluate performance based on grades
        public static void EvaluatePerformance(double[] grades)
        {
            foreach (var grade in grades)
            {
                // Using switch statement to categorize grades
                switch ((int)grade / 10)
                {
                    case 10:
                    case 9:
                        Console.WriteLine($"Grade: {grade} - Excellent");
                        break;
                    case 8:
                        Console.WriteLine($"Grade: {grade} - Very Good");
                        break;
                    case 7:
                        Console.WriteLine($"Grade: {grade} - Good");
                        break;
                    case 6:
                        Console.WriteLine($"Grade: {grade} - Satisfactory");
                        break;
                    default:
                        Console.WriteLine($"Grade: {grade} - Needs Improvement");
                        break;
                }
            }
        }
    }

}
