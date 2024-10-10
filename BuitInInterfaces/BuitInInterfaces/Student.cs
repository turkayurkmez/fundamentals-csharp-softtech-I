using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuitInInterfaces
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }

        public int CompareTo(Student? other)
        {
            if (Score > other!.Score)
            {
                return 1;
            }
            else if (Score< other!.Score)
            {
                return -1;
            }

            return 0;
        }
    }
}
