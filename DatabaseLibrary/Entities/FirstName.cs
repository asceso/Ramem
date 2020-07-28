using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLibrary.Entities
{
    public class FirstName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string FirstNameValue { get; set; }
        public bool IsMale { get; set; }
    }
}
