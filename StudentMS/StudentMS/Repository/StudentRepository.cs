using StudentMS.Models;

namespace StudentMS.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> SelectAllStudents()
        {
            return StudentList.SelectStudentList();
        }

        public Student SelectStudentById(int id)
        {
            return StudentList.SelectStudentList().Find(x => x.StudentID == id);
        }

        public void InsertStudent(Student student)
        {
            StudentList.InsertStudentList(student);
        }

        public void UpdateStudent(Student student)
        {
            StudentList.UpdateStudentList(student);
        }

        public void DeleteStudent(int id)
        {
            StudentList.DeleteStudentList(id);
        }
    }
}
