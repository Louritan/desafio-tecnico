﻿namespace StudentManagement.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public List<StudentGrade> Grades { get; set; } = new();
    }
}
