using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLibrary.Entities
{
    public class FathersName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string FathersNameValue { get; set; }
        public bool IsMale { get; set; }
    }
}
