using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace NewStore.Models
{   // контекст данных о пользователях и их ролях
    public class IdentityContext : IdentityDbContext<IdentityUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }
    }
}
