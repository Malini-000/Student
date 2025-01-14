﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Student.Business.Models.Students
{
    public class StudentsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegisterNumber { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Department { get; set; }
        public string Password { get; set; }
        public SubjectModel Subject { get; set; }
    }
}
