using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteAPI.Models;

namespace TesteAPI.Maps
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.ToTable("user");
            entityBuilder.HasKey(x => x.UserId);

            entityBuilder.Property(x => x.FirstName).HasColumnName("first_name");
            entityBuilder.Property(x => x.LastName).HasColumnName("last_name");
            entityBuilder.Property(x => x.Email).HasColumnName("email");
            entityBuilder.Property(x => x.DateOfBirth).HasColumnName("birth_date");
            entityBuilder.Property(x => x.CreationDate).HasColumnName("creation_date");
        }
    }
}