using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CreamConsulting.Models
{
    [Table("Members")]
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }

        [StringLength(16)]
        public string MemberCardNumber { get; set; }
        [StringLength(50)]
        public string Emailaddress { get; set; }
        [StringLength(30)]
        public string TelephoneNumber { get; set; }
        public bool IsBlackListed { get; set; }
        public DateTime BlackListeduntil { get; set; }
    }
}
