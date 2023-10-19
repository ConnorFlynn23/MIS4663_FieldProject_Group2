﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MIS4663_FieldProject_Group2.Data;
using MIS4663_FieldProject_Group2.Models;
using System;
using System.Collections.Generic;

namespace MIS4663_FieldProject_Group2.Data.Configurations
{
    public partial class TPermissionsConfiguration : IEntityTypeConfiguration<TPermissions>
    {
        public void Configure(EntityTypeBuilder<TPermissions> entity)
        {
            entity.HasKey(e => e.PermissionID).HasName("PK__TPermiss__EFA6FB0FFF1B7BD4");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Role).WithMany(p => p.TPermissions)
            .HasForeignKey(d => d.RoleID)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__TPermissi__RoleI__5070F446");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TPermissions> entity);
    }
}
