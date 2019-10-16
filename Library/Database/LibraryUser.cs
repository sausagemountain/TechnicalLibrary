using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class LibraryUser
    {
        public LibraryUser()
        {
            AuthorOf = new HashSet<Document>();
            Student = new HashSet<StudentInfo>();
            Worker = new HashSet<WorkerInfo>();
        }

        [Key]
        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }
        
        [Required]
        public UserStatus Status { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        
        public virtual ICollection<WorkerInfo> Worker { get; set; }

        public virtual ICollection<StudentInfo> Student { get; set; }

        public virtual ICollection<Document> AuthorOf { get; set; }
    }
}