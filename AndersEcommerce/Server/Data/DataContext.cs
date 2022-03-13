namespace AndersEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Title = "Bipollen",
                    Description = "Vår bipollen hjälper till med att öppna upp lungornas alveoler rejält.",
                    ImageUrl = "https://fincasolmark.com/wp-content/uploads/2021/07/finca-solmark-bipollen-225g.jpg",
                    Price = 150.50m
                },
             new Product
             {
                 Id = 2,
                 Title = "Honung Avokado",
                 Description = "Vår unika avokadohonung passar perfekt till rejäla ostar och att marinera köttbitar med.",
                 ImageUrl = "https://fincasolmark.com/wp-content/uploads/2020/10/finca-solmark-honung-avokado-1.jpg",
                 Price = 129.99m
             },
             new Product
             {
                 Id = 3,
                 Title = "Honung Bergsblommor",
                 Description = "Vår mest populära honung kommer från blommorna på berget ovanför gården.",
                 ImageUrl = "https://fincasolmark.com/wp-content/uploads/2020/10/finca-solmark-honung-bergsblommor-1.jpg",
                 Price = 89.99m
             });
        }

        public DbSet<Product> Products { get; set; }
    }
}
