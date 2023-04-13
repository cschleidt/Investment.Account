using Microsoft.EntityFrameworkCore;
using Investment.Account.Models;


namespace Investment.Account.Repository
{
    /// <summary>
    /// Database configuration
    /// </summary>
    public class InvestmentAccountContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public InvestmentAccountContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<InvestmentAccountFacility> InvestmentAccount { get; set; }
        public DbSet<InvestmentAccountEntry> InvestmentAccountEntry { get; set; }

    }
}
