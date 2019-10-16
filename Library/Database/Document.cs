using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class Document
    {
        public Document()
        {
            Authors = new HashSet<LibraryUser>();
        }

        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Publication { get; set; }

        public string FileLink { get; set; }

        public string PrintLocation { get; set; }

        [Required]
        public long NumberOfCopies { get; set; }

        public virtual ICollection<LibraryUser> Authors { get; set; }

        public virtual DocumentType Type { get; set; }
    }
}