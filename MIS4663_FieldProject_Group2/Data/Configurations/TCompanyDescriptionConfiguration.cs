﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MIS4663_FieldProject_Group2.Data;
using MIS4663_FieldProject_Group2.Models;
using System;
using System.Collections.Generic;

namespace MIS4663_FieldProject_Group2.Data.Configurations
{
    public partial class TCompanyDescriptionConfiguration : IEntityTypeConfiguration<TCompanyDescription>
    {
        public void Configure(EntityTypeBuilder<TCompanyDescription> entity)
        {
            entity.HasKey(e => e.CompanyDescID).HasName("PK__TCompany__C61893BFE4461C62");

            entity.Property(e => e.Background)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.Goals)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.Mission)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.Product)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.Structure)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TCompanyDescription> entity);
    }
}
