namespace DCC_Parish_LemonadeStand
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model_LemonadeStand")
        {
        }

        public virtual DbSet<LemonadeStandScore> LemonadeStandScores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LemonadeStandScore>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LemonadeStandScore>()
                .Property(e => e.Score)
                .HasPrecision(18, 0);
        }
    }
}
