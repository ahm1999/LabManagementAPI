using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    //[Key(nameof(Id))]
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("AspNetUsers")]
        public string? UserId { get; set; }
        public DateOnly CreatedOn { get; set; }
        public DateOnly UpdatedOn { get; set; }
    }
}
