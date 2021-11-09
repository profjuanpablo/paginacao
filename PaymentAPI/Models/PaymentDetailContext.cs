using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PaymentAPI.Identity;

namespace PaymentAPI.Models
{
    public class PaymentDetailContext : IdentityDbContext<User,Role,int,
                                                          IdentityUserClaim<int>,UserRole,IdentityUserLogin<int>,
                                                          IdentityRoleClaim<int>,IdentityUserToken<int>>
                                                           
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        { }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
