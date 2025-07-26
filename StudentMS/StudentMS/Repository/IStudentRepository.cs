using StudentMS.Models;

namespace StudentMS.Repository
{
    public interface IStudentRepository
    {
        List<Student> SelectAllStudents();
        Student SelectStudentById(int id);
        void InsertStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
