using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Village.Models
{
    public partial class VillageDC : DbContext
    {
        public VillageDC()
            : base("name=VillageDC")
        {
        }
        public virtual DbSet<Settler> Settlers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
