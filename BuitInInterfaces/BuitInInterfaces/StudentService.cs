using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BuitInInterfaces
{
    public class StudentService : IEnumerable<Student>
    {
        private List<Student> _students = new List<Student>();
        public void Add(Student student)
        {
            _students.Add(student);
        }

        public void Add(params Student[] students)
        {
            _students.AddRange(students);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            //her seferinde _students koleksiyonudaki sadece bir student nesnesini döndür.
            foreach (var item in _students)
            {
                yield return item;
            }
        }

        public List<Student> SortStudents()
        {
            _students.Sort();
            return _students;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
