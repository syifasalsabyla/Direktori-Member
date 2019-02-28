using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using direktoriMember.Models;

namespace direktoriMember.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<direktoriMember.Models.Produk> Produk { get; set; }
        public DbSet<direktoriMember.Models.Member> Member { get; set; }
        public DbSet<direktoriMember.Models.SOHeader> SOHeader { get; set; }
        public DbSet<direktoriMember.Models.SOLine> SOLine { get; set; }
    }
}
