# Student Performance Tracker (C#)

A simple C# console application that tracks student scores, identifies the top-performing student, and allows user interaction to check if a student exists.

## Features

* Automatically assigns random scores (between 85 and 99) to predefined students.
* Displays all students and their scores.
* Identifies and displays the student with the highest score.
* Accepts user input to check if a student exists in the system.
* Handles common exceptions gracefully with clear console messages.

## Technologies Used

* C# (.NET)
* Console Application
* Dictionary data structure for storing student scores

## Project Structure

```
student_performance_tracker_cs/
│
├── Program.cs        // Entry point of the application
└── Solution.cs       // Core logic for managing student data and interactions
```

## How It Works

1. The program initializes a dictionary of students with randomly generated scores.
2. It prints all student names and their associated scores.
3. It identifies the student with the highest score and displays the result.
4. It prompts the user to enter a student name to check for existence in the dictionary.

## Example Output

```
Student Scores
*********************
Haruki: 92
Ren: 89
Sakura: 97
Takashi: 91
Yumi: 94
*********************

The student with the highest score is Sakura with a score of 97.

Enter a student name to check if they exist:
>> Yumi
Yumi exists in the dictionary with a score of 94.
```

## Error Handling

* Duplicate students: Warns the user without crashing.
* Unexpected exceptions: Displayed in red for visibility.

## How to Run

1. Clone the repository or copy the code into your C# development environment.
2. Compile and run the application using your IDE or terminal:

   ```
   dotnet run
   ```
3. Follow the on-screen instructions.

---
