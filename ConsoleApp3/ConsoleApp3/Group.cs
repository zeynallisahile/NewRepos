using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Group
    {
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }
        private int _studentLimit;
        private string _groupNo;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        }
        public int StudentLimit
        {
            get => _studentLimit;
            set
            {
                if (value >= 5 && value <= 18)
                    _studentLimit = value;
            }
        }
        private Student[] students = new Student[0];
        public bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 5)
            {
                if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                    return true;
                else
                    return false;
            }
            return false;
        }
        public void AddStudent(Student student)
        {
            if (students.Length <= StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else
                Console.WriteLine("Siz qrup limitini kecmisiz!!!");
        }
        public Student GetStudent(int? id)
        {
            if (Array.Exists(students, x => x.Id == id))
            {
                Student student = Array.Find(students, x => x.Id == id);
                return student;
            }
            else
            {
                Console.WriteLine("Bele bir id yoxdur,zehmet olmasa duzgun axtaris edin!");
                return null;
            }
        }
        public Student[] GetAllStudents()
        {
            return students;
        }
    }
}
