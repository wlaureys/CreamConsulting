using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CreamConsulting.Models;

namespace CreamConsulting
{
    public class MemberDataRespository : IDataRepository<Member>
    {
        private MembershipContext _context;

        public MemberDataRespository(MembershipContext context)
        {
            _context = context;
        }

        public IEnumerable<Member> GetAll()
        {
            return _context.Members.ToList();
        }

        public Member Get(int id)
        {
            return _context.Members
                  .FirstOrDefault(e => e.MemberId == id);
        }

        public void Add(Member entity)
        {
            if (!string.IsNullOrEmpty(entity.TelephoneNumber) && !string.IsNullOrEmpty(entity.Emailaddress))
                throw new ValidationException("An email or telephone must be filled out");

            if (string.IsNullOrEmpty(entity.TelephoneNumber) && string.IsNullOrEmpty(entity.Emailaddress))
                throw new ValidationException("Email and telephone are filled. Only use one. ");

            // if needed put extra validations here

            this._context.Set<Member>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(Member dbEntity, Member entity)
        {
            if (!string.IsNullOrEmpty(entity.TelephoneNumber) && !string.IsNullOrEmpty(entity.Emailaddress))
                throw new ValidationException("An email or telephone must be filled out");

            if (string.IsNullOrEmpty(entity.TelephoneNumber) && string.IsNullOrEmpty(entity.Emailaddress))
                throw new ValidationException("Email and telephone are filled. Only use one. ");

            // if needed put extra validations here

            dbEntity.MemberCardNumber = entity.MemberCardNumber;
            dbEntity.TelephoneNumber = entity.TelephoneNumber;
            dbEntity.Emailaddress = entity.Emailaddress;
            dbEntity.IsBlackListed = entity.IsBlackListed;
            dbEntity.BlackListeduntil = entity.BlackListeduntil;

            _context.SaveChanges();
        }

        public void Delete(Member entity)
        {
            _context.Members.Remove(entity);
            _context.SaveChanges();
        }
    }

}
