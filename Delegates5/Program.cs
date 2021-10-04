using System;
using System.Collections.Generic;

namespace Delegates5
{
    class Student
    {
        public string FirstName { get; set; }
    }

    delegate bool FilterDelegate(Student student);

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
            var list =new List<Student>();
            foreach (var item in students)
            {
                if(filterDelegateInstance(item))
                    list.Add(item);
            }
            return list;
        
        }
    }

    class Program
    {
        public static bool FilterByLength(Student student)
        {
            return student.FirstName.Length > 4;
        }

        static void Main(string[] args)
        {
            var studentsManager = new StudentsList();
            studentsManager.Add(new Student() { FirstName="Shraga"});
            studentsManager.Add(new Student() { FirstName = "Ohad" });
            studentsManager.Add(new Student() { FirstName = "Bashar" });
            studentsManager.Add(new Student() { FirstName = "Danuel" });

            var list1 = studentsManager.Filter(FilterByLength);

            
        }
    }
}
