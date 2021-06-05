using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_API.Models;

namespace Entity_API.IServices
{
    public interface IStudentService
    {
        List<Student> GetListStudents();
        Student GetStudent(Guid id);
        Student AddStudent(Student student);
        Student EditStudent(Student student);
        void DeleteStudent(Student student);
    }
}
