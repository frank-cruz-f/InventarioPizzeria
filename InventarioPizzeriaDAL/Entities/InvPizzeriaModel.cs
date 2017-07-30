namespace InventarioPizzeriaDAL.Entities
{
    using System.Data.Entity;

    public partial class InvPizzeriaModel : DbContext
    {
        public InvPizzeriaModel()
            : base("name=InvPizzeriaModel")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Dough> Doughs { get; set; }

        public virtual DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Code)
                .IsUnicode(false);
        }
    }
}
