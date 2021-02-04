using Microsoft.EntityFrameworkCore;

namespace AnimalCoutingDatabase.Api
{
    public class Customer
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }
    }

    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
    }
}
