﻿using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Models.DataModels
{
    [Table("Course")]
    public class CourseEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime OpeningDate { get; set; }
        public int DurationInHour { get; set; }
        public DateTime DurationInMonth { get; set; }

    }
}
