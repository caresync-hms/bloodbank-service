
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BloodBankService.Models
{
    public class Donor
    {
        [Key]
        public int DonorId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string BloodGroup { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        
    }
    public class BloodDbContext : DbContext
    {
        public BloodDbContext(DbContextOptions<BloodDbContext> options)
            : base(options)
        {
        }

        public DbSet<Donor> Donors { get; set; }

    }
}
