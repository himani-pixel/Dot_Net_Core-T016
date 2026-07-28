using Microsoft.EntityFrameworkCore.Storage;

namespace Practical_5C.Models
{
    public class Employee
    {
        public int Id { get; set;  }
        public required string Name { get; set; }
        public required string Dept { get; set; }
        public double salary { get; set; }
    }
}
