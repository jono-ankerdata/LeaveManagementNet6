using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    UserId = "9b92dc6f-5864-499f-9c3e-213b32d18d62"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                    UserId = "6b92cc6f-5864-499f-9c3e-213b32d18d32"
                }
            );
        }
    }
}