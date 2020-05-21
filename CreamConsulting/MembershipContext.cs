using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreamConsulting.Models;

namespace CreamConsulting
{
    public class MembershipContext:DbContext
    {
        public MembershipContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<IdentityCard> IdCards { get; set; }
        public DbSet<IdentityCardMember> IdCardMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityCardMember>()
                .HasKey(c => new { c.MemberId, c.IdentityCardId });

        }

    }
}
