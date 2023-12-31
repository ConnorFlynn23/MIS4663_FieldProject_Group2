﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MIS4663_FieldProject_Group2.Data;
using MIS4663_FieldProject_Group2.Models;
using System;
using System.Collections.Generic;

namespace MIS4663_FieldProject_Group2.Data.Configurations
{
    public partial class TContactConfiguration : IEntityTypeConfiguration<TContact>
    {
        public void Configure(EntityTypeBuilder<TContact> entity)
        {
            entity.HasKey(e => e.ContactID).HasName("PK__TContact__5C6625BBDEDF9F99");

            entity.Property(e => e.Company)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
            entity.Property(e => e.ContactEmail)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
            entity.Property(e => e.FName)
            .IsRequired()
            .HasMaxLength(25)
            .IsUnicode(false);
            entity.Property(e => e.LName)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TContact> entity);
    }
}
