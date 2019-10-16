using System;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class StudentInfo
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public DateTime From { get; set; }

        [Required]
        public DateTime To { get; set; }


        public virtual StudentGroup Group { get; set; }

        public virtual LibraryUser Person { get; set; }
    }
}