using DooET_TodoApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Infrastructure.Persistence.SchemaDefinition
{
    public class UserSchemaDefinition : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.UserId);

            builder.Property(t => t.FirstName)
                .HasMaxLength(250);
            builder.Property(t => t.LastName)
                .HasMaxLength(250);

            builder.HasIndex(t => t.Password).IsUnique();
            builder.Property(t => t.Password).HasMaxLength(8);

            builder.HasIndex(t => t.Email).IsUnique();
            builder.Property(t => t.Email).HasMaxLength(250);


        }
    }
}
