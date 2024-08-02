using System;
using System.Collections.Generic;

namespace RNET104_02082024.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime EnrollmentDate { get; set; }
    }
}
