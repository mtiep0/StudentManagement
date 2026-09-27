using System;

namespace StudentManagement
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Student: {FullName} - ID: {StudentId}");
        }
    }
}