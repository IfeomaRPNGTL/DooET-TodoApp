﻿using DooET_TodoApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DooET_ToDoApp.Infrastructure.Persistence.SchemaDefinition
{
    public class CategorySchemaDefinition : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(t => t.CategoryId);

            builder.Property(t => t.Name).HasMaxLength(250);

            builder.Property(t => t.Description).HasMaxLength(250);
        }
    }
}
