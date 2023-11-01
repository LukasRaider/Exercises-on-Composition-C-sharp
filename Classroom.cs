using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class ClassRoom
    {
        private Teacher teacher;
        private Student[] students;
        private int currentNumberOfStudents;
        private int maxNumberOfStudents;

        public bool addStudent(Student student)
        {
            if (currentNumberOfStudents < maxNumberOfStudents)
            {
                students[currentNumberOfStudents] = student;
                currentNumberOfStudents++;
                return true;
            }
            return false;
        }

        public bool removeStudent(int id)
        {
            
            return true;
        }

        public string toString()
        {
            // Vytvořte řetězec obsahující informace o třídě, učiteli a studentech
            return "";
        }

        public ClassRoom(int max)
        {
            maxNumberOfStudents = max;
            students = new Student[max];
        }
    }

    class Teacher
    {
        private string firstName;
        private string lastName;
        private double salary;
        private string subject;

        public Teacher(string firstName, string lastName, double salary, string subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.subject = subject;
        }

        
        

        public override string ToString()
        {
            return $"Učitel {firstName} {lastName}, Předmět: {subject}, Výdělek: {salary}";
        }
    }

    class Student
    {
        private string firstName;
        private string lastName;
        private double age;
        private double average;

        public Student(string firstname, string lastname, double vek, double prum)
        {
            firstName = firstname;
            lastName = lastname;
            age = vek;
            average = prum;
        }

        public string toString()
        {
            
            return $"Student {firstName} {lastName}, Věk: {age}, Průměr: {average}";
        }
    }

    class TestClassroom
    {
        public static void Mainx(string[] args)
        {
            Teacher teacher = new Teacher("John", "Doe", 30000, "Matematika");

            
            ClassRoom classroom = new ClassRoom(30); 

            

            Student student1 = new Student("Alice", "Johnson", 16, 3.8);
            Student student2 = new Student("Bob", "Smith", 17, 4.0);
            Student student3 = new Student("Charlie", "Brown", 16, 3.5);

            
            classroom.addStudent(student1);
            classroom.addStudent(student2);
            classroom.addStudent(student3);

            
            Console.WriteLine(classroom.ToString());

            
            Console.WriteLine(teacher.ToString());
        }
    }

}
