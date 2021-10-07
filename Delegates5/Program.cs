using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates5
{
    class Student
    {
        public Student()
        {

        }
        public Student(string firstName, int age, int amountToPay, int amountPaied)
        {
            FirstName = firstName;
            Age = age;
            AmountPaied = amountPaied;
            AmountTopay = amountToPay;
        }
        public string FirstName { get; set; }
        public int AmountTopay { get; set; }
        public int AmountPaied { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", FirstName, Age, AmountTopay, AmountPaied);
        }
    }

    delegate bool FilterDelegate(Student student);
    delegate int SumStudentsProperties(Student student);

    class StudentsList
    {
        List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            /*-*/
            students.Add(student);
        }

        void Remove(Student student)
        {
            students.Add(student);
        }

        public List<Student> Filter(FilterDelegate filterDelegateInstance)
        {
            var list = new List<Student>();
            foreach (var item in students)
            {
                if (filterDelegateInstance(item))
                    list.Add(item);
            }
            return list;

        }

        public bool Contains(FilterDelegate filterDelegateInstance)
        {
            var contains = false;
            foreach (var item in students)
            {
                if (filterDelegateInstance(item))
                    return true;
            }
            return false;

        }

        public int Sum(SumStudentsProperties sumStudentsProperties)
        {
            var sum = 0;
            foreach (var student in students)
            {
                sum += sumStudentsProperties(student);
            }
            return sum;

        }

    }

    class Program
    {
        public static bool FilterByLength(Student student)
        {
            return student.FirstName.Length >= 4;
        }

        const int MagicAge = 29;

        public static bool FilterByMagicAge(Student student)
        {
            return student.Age > 29;
        }

        public static int SumAmountPaid(Student student)
        {
            return student.AmountPaied;
        }


        static void Main(string[] args)
        {
            var studentsManager = new StudentsList();
            studentsManager.Add(new Student() { FirstName = "Shraga", AmountPaied = 2500 });
            studentsManager.Add(new Student() { FirstName = "Ohad" });
            studentsManager.Add(new Student() { FirstName = "Bashar", AmountPaied = 12500 });
            studentsManager.Add(new Student() { FirstName = "Daniel" });
            studentsManager.Add(new Student() { FirstName = "Null", Age = 129 });

            var list1 = studentsManager.Filter(FilterByLength);
            var contains = studentsManager.Contains(FilterByLength);
            contains = studentsManager.Contains(FilterByMagicAge);

            Console.WriteLine(contains);


            var sum = studentsManager.Sum(SumAmountPaid);


            /*IoC 
            
             Inversion Od control
            היפוך שליטה
             */
        }
    }
}
