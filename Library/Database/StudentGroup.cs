using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class StudentGroup
    {
        public StudentGroup()
        {
            Students = new HashSet<StudentInfo>();
        }

        [Key]
        public long Id { get; set; }

        [Required]
        public string AreaOfStudy { get; set; }

        [Required]
        public DateTime EducationStartDate { get; set; }

        [Required]
        public string SubGroup { get; set; }


        public virtual ICollection<StudentInfo> Students { get; set; }
    }
}