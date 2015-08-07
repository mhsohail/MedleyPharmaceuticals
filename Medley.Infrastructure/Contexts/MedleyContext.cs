using Medley.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medley.DAL.Contexts
{
    public class MedleyContext : DbContext
    {
        public DbSet<RawProduct> RawProducts { get; set; }

        public MedleyContext() : base("MedleyContext")
        {
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
