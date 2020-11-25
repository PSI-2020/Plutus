using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class PaymentsContext : DbContext
    {
        public PaymentsContext(DbContextOptions<PaymentsContext> options)
            : base(options)
        {
        }

        public DbSet<WebPayment> WebPayments { get; set; }
    }
}
