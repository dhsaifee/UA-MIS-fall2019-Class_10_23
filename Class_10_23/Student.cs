using System;
using System.Collections.Generic;
using System.Text;

namespace Class_10_23
{
    class Student
    {
        private string name;
        private string classRank;
        private double gpa;
        private static int count;

        public Student(string name)
        {
            this.name = name;
        }

        public Student()
        {

        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetClassRank(string classRank)
        {
            this.classRank = classRank;
        }

        public string GetClassRank()
        {
            return classRank;
        }

        public void SetGPA(double gpa)
        {
            this.gpa = gpa;
        }

        public double GetGPA()
        {
            return gpa;
        }

        public static void SetCount(int count)
        {
            Student.count = count;
        }

        public static int GetCount()
        {
            return count;
        }

        public static void IncCount()
        {
            count++;
        }


        public override string ToString()
        {
            return name + "\t" + classRank;
        }

        public int CompareTo(Student myStudent)
        {
            return this.name.CompareTo(myStudent.GetName());
        }
    }
}
