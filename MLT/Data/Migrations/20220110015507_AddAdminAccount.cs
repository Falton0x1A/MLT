using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace MLT.Data.Migrations
{
    public partial class AddAdminAccount : Migration
    {
        const string ADMIN_USER_GUID = "0dad377d-32b4-4be5-902c-e373b92993a1";
        const string ADMIN_ROLE_GUID = "d666077a-24c2-439e-91ed-d0a4259bef07";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var passwordHash = hasher.HashPassword(null, "Passw0rd1!");

            StringBuilder sb = new StringBuilder(); sb.AppendLine("INSERT INTO AspNetUsers(Id, UserName, NormalizedUserName,Email,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount,NormalizedEmail,PasswordHash,SecurityStamp)");
            sb.AppendLine("VALUES(");
            sb.AppendLine($"'{ADMIN_USER_GUID}'");
            sb.AppendLine(",'MLTAdmin@MLT.com'");
            sb.AppendLine(",'MLTADMIN@MLT.COM'");
            sb.AppendLine(",'mltadmin@mlt.com'");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(",'MLTADMIN@MLT.COM'");
            sb.AppendLine($", '{passwordHash}'");
            sb.AppendLine(", '')");

            migrationBuilder.Sql(sb.ToString());

            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('{ADMIN_ROLE_GUID}','Admin','ADMIN')");

            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('{ADMIN_USER_GUID}','{ADMIN_ROLE_GUID}')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{ADMIN_USER_GUID}' AND RoleId = '{ADMIN_ROLE_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{ADMIN_USER_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{ADMIN_ROLE_GUID}'");

        }
    }
}