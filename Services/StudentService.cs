using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BranchesPractice.Services
{
    public class StudentService : IStudentService
    {
        List<string> studentList = ["Student 1", "Student 2", "Student 3"];

        public List<string> StudentGetAll()
        {
            return studentList;
        }
    }
}