namespace MedleyPharmaceuticals
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MedleyModelCF : DbContext
    {
        public MedleyModelCF()
            : base("name=MedleyModelCF")
        {
        }

        public virtual DbSet<RawProduct> RawProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
