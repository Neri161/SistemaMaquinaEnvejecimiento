using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SistemaMaquinaEnvejecimiento.Models
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB5")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Medicion> Medicion { get; set; }
        public virtual DbSet<Prueba> Prueba { get; set; }
    }
}
