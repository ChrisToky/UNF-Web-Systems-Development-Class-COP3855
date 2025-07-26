using StudentMS.Models;

namespace StudentMS.Repository
{
    public class StudentList
    {
        static List<Student> studentList = null;
        static StudentList()
        {
            studentList = new List<Student>(){
                new Student()
                {
                    StudentID = 1,
                    Name = "Karthik Umapathy",
                    Age = 48,
                    Degree = "B.S. Information Systems",
                    Status = "Junior"
                }
            };
        }

        public static List<Student> SelectStudentList()
        {
            return studentList;
        }

        public static void InsertStudentList(Student student)
        {
            studentList.Add(student);
        }

        public static void UpdateStudentList(Student student)
        {
            Student studentUpdate = studentList.Find(x => x.StudentID == student.StudentID);
            studentUpdate.Name = student.Name;
            studentUpdate.Age = student.Age;
            studentUpdate.Degree = student.Degree;
            studentUpdate.Status = student.Status;
        }
        public static void DeleteStudentList(int id)
        {
            Student studentDelete = studentList.Find(x => x.StudentID == id);
            studentList.Remove(studentDelete);
        }
    }
}
