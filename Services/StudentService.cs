using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BranchesPractice.Services
{
    public class StudentService : IStudentService
    {
        List<string> studentList = ["Jacob Da Best Teacher", "Mr. Stank", "Onion Breath", "Student 3"];

        public List<string> StudentGetAll()
        {
            return studentList;
        }

        public int StudentCount()
        {
            return studentList.Count();
        }
    }
}