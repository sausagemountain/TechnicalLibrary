using System;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class PassOutRecord
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public DateTime IssueTime { get; set; }

        public DateTime IssueEnd { get; set; }


        public virtual LibraryUser LentTo { get; set; }

        public virtual Document CopyOf { get; set; }
    }
}