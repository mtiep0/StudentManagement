using System;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Student Management System!");
            
            Login login = new Login();
            Console.WriteLine("Login status: " + login.Authenticate("admin", "123456"));

            Student st = new Student { StudentId = "SV001", FullName = "Nguyen Van An" };
            st.DisplayInfo();
        }
    }
}