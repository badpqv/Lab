using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_API.Context;
using Entity_API.IServices;
using Entity_API.Models;

namespace Entity_API.Services
{
    public class StudentService:IStudentService
    {
        private List<Student> _lstStudents;
        private readonly ApiContext _context;

        public StudentService(ApiContext context)
        {
            _context = context;
            _lstStudents = new List<Student>();
            GetListStudents();
        }
        public List<Student> GetListStudents()
        {
            _lstStudents = _context.Student.ToList();
            return _lstStudents;
        }

        public Student GetStudent(Guid id)
        {
           return  _lstStudents.FirstOrDefault(c => c.Id == id);
        }

        public Student AddStudent(Student student)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student EditStudent(Student student)
        {
            var std = GetStudent(student.Id);
            std.Msv = student.Msv;
            std.NamSinh = student.NamSinh;
            std.NganhHoc = student.NganhHoc;
            _context.Student.Update(std);
            _context.SaveChanges();
            return std;
        }

        public void DeleteStudent(Student student)
        {
            _context.Student.Remove(student);
            _context.SaveChanges();
        }
    }
}
