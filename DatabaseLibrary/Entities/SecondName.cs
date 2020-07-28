using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLibrary.Entities
{
    public class SecondName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string SecondNameValue { get; set; }
        public bool IsMale { get; set; }
    }
}
