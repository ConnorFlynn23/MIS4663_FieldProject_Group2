using Microsoft.EntityFrameworkCore;

namespace MIS4663_FieldProject_Group2.Data
{
    public class DbCon:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
                optionsBuilder
                    .UseSqlServer("Server=tcp:s30.winhost.com;Database=DB_128040_group2;User Id=DB_128040_group2_user;Password=LaughOutLoud#2023;TrustServerCertificate=True");
    }
}
