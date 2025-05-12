using System;
using System.Collections.Generic;

namespace student_performance_tracker_cs
{
    // Solution class: Coordinates the flow of the application and student management
    class Solution
    {
        private Dictionary<string, int> studentScores;  // To store student names and their scores
        private Random rand;

        // Constructor: Initializes the student scores dictionary and random number generator
        public Solution()
        {
            studentScores = new Dictionary<string, int>();
            rand = new Random();
        }

        // Method to run the logic for managing students and scores
        public void Run()
        {
            try
            {
                // Add students with random scores between 85 and 99
                AddStudent("Haruki");
                AddStudent("Ren");
                AddStudent("Sakura");
                AddStudent("Takashi");
                AddStudent("Yumi");

                // Print all students and their scores
                PrintStudentScores();

                // Find and display the student with the highest score
                FindTopStudent();

                // Prompt the user to check if a student exists in the dictionary
                Console.WriteLine("\nEnter a student name to check if they exist:");
                string studentToCheck = Console.ReadLine();
                CheckIfStudentExists(studentToCheck);
            }
            catch (Exception ex)
            {
                // Catch any unexpected exceptions and display the error
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR]: {ex.Message}");
                Console.ResetColor();
            }
        }

        // Method to add a student with a random score between 85 and 99
        private void AddStudent(string name)
        {
            try
            {
                int score = rand.Next(85, 100); // Random score between 85 and 99
                studentScores.Add(name, score);
            }
            catch (ArgumentException)
            {
                // Handle duplicate student names
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[WARNING]: The student {name} already exists.");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                // Handle any other errors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR]: Unable to add student {name}. {ex.Message}");
                Console.ResetColor();
            }
        }

        // Method to print all students and their scores
        private void PrintStudentScores()
        {
            Console.WriteLine("Student Scores");
            Console.WriteLine("*********************");

            foreach (var student in studentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            Console.WriteLine("*********************");
        }

        // Method to find and display the student with the highest score
        private void FindTopStudent()
        {
            try
            {
                if (studentScores.Count == 0)
                {
                    Console.WriteLine("No students available to determine the highest score.");
                    return;
                }

                string topStudent = "";
                int highestScore = int.MinValue;

                // Loop through the dictionary to find the student with the highest score
                foreach (var student in studentScores)
                {
                    if (student.Value > highestScore)
                    {
                        topStudent = student.Key;
                        highestScore = student.Value;
                    }
                }

                // Display the top student's name and score
                Console.WriteLine($"\nThe student with the highest score is {topStudent} with a score of {highestScore}.");
            }
            catch (Exception ex)
            {
                // Catch any unexpected errors during the process
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: Unable to determine the top student.");
                Console.WriteLine($"Exception Message: {ex.Message}");
                Console.ResetColor();
            }
        }

        // Method to check if a specific student exists in the dictionary
        private void CheckIfStudentExists(string studentName)
        {
            try
            {
                if (studentScores.ContainsKey(studentName))
                {
                    Console.WriteLine($"{studentName} exists in the dictionary with a score of {studentScores[studentName]}.");
                }
                else
                {
                    Console.WriteLine($"{studentName} does not exist in the dictionary.");
                }
            }
            catch (Exception ex)
            {
                // Catch any unexpected errors during the process
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR]: Unable to check if student exists.");
                Console.WriteLine($"Exception Message: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
