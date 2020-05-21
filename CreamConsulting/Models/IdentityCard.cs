using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CreamConsulting.Models
{
    [Table("IdentityCards")]
    public class IdentityCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdentityCardId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityId { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
