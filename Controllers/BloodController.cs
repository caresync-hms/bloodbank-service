using BloodBankService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BloodBankService.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class BloodController : Controller
    {
        private readonly BloodDbContext _context;
        public BloodController(BloodDbContext context)
        {
            _context = context; 
        }
        [HttpPost]
        public IActionResult AddDonor(Donor donor)
        {
            donor.CreatedAt = DateTime.UtcNow;
            _context.Donors.Add(donor);
            _context.SaveChanges();
            return Ok(donor);
        }

        [HttpGet]
        public IActionResult getAllDonors()
        {
            var donors = _context.Donors.ToList();
            return Ok(donors);
        }

        [HttpGet("Count")]
        public IActionResult GetCount()
        {   var result=_context.Donors
                .GroupBy(d=>d.BloodGroup)
                .Select(g => new
                {BloodGroup=g.Key,
                Count=g.Count(), 
                }).ToList();
            return Ok(result);

        }

    }
}
