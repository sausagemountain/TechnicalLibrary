using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class DocumentType
    {
        public DocumentType()
        {
            Documents = new HashSet<Document>();
        }

        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }


        public virtual ICollection<Document> Documents { get; set; }
    }
}