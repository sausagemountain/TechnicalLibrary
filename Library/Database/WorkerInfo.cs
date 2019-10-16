using System;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class WorkerInfo
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public DateTime From { get; set; }

        [Required]
        public DateTime To { get; set; }

        public string Position { get; set; }

        public string AcademicRank { get; set; }


        public virtual LibraryUser Person { get; set; }
    }
}