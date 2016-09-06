using System.Linq;
using Vysotskyi.EntityFramework;
using Vysotskyi.MultiTenancy;

namespace Vysotskyi.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly VysotskyiDbContext _context;

        public DefaultTenantCreator(VysotskyiDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
