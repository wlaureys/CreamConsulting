using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CreamConsulting.Models
{
    [Table("IdentityCardMembers")]
    public class IdentityCardMember
    {
        public int MemberId { get; set; }
        public int IdentityCardId { get; set; }
    }
}
