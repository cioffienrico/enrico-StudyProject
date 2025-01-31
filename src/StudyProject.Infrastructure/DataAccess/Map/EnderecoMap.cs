﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyProject.Infrastructure.DataAccess.Entidades;

namespace StudyProject.Infrastructure.DataAccess.Map
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco", "public");
            builder.HasKey(k => k.Id);
        }
    }
}
