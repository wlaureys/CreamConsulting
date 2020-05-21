using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreamConsulting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreamConsulting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IDataRepository<Member> _dataRepository;

        public MemberController(IDataRepository<Member> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Member> employees = _dataRepository.GetAll();
            return Ok(employees);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            Member member = _dataRepository.Get(id);

            if (member == null)
            {
                return NotFound($"Object <Member> with {id} not found");
            }

            return Ok(member);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Member member)
        {
            if (member == null)
            {
                return BadRequest("Member is null.");
            }

            _dataRepository.Add(member);
            return CreatedAtRoute(
                  "Get",
                  new { Id = member.MemberId },
                  member);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Member member)
        {
            if (member == null)
            {
                return BadRequest("Employee is null.");
            }

            Member employeeToUpdate = _dataRepository.Get(id);
            if (employeeToUpdate == null)
            {
                return NotFound($"Object <Member> with {id} not found");
            }

            _dataRepository.Update(employeeToUpdate, member);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Member member = _dataRepository.Get(id);
            if (member == null)
            {
                return NotFound($"Object <Member> with {id} not found");
            }

            _dataRepository.Delete(member);
            return NoContent();
        }


        [HttpPost("{id}/Blacklist")]
        public IActionResult Blacklist(int id)
        {
            Member memberToUpdate = _dataRepository.Get(id);
            Member member = _dataRepository.Get(id);

            if (memberToUpdate == null)
            {
                return BadRequest("Member is null.");
            }

            memberToUpdate.IsBlackListed = true;
            memberToUpdate.BlackListeduntil = DateTime.Now.AddDays(14);

            _dataRepository.Update(memberToUpdate, member);
            return NoContent();
        }

        [HttpGet("{id}/BlacklistedUntil")]
        public IActionResult BlacklistedUntil(int id)
        {
            Member member = _dataRepository.Get(id);

            if (member == null)
            {
                return BadRequest("Member is null.");
            }

            return Ok(member.BlackListeduntil);
        }
    }
}