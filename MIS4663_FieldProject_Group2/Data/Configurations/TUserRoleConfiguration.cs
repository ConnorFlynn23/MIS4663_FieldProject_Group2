﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MIS4663_FieldProject_Group2.Data;
using MIS4663_FieldProject_Group2.Models;
using System;
using System.Collections.Generic;

namespace MIS4663_FieldProject_Group2.Data.Configurations
{
    public partial class TUserRoleConfiguration : IEntityTypeConfiguration<TUserRole>
    {
        public void Configure(EntityTypeBuilder<TUserRole> entity)
        {
            entity.HasKey(e => e.UserRoleID).HasName("PK__TUserRol__3D978A5523FC7CCB");

            entity.HasOne(d => d.Role).WithMany(p => p.TUserRole)
            .HasForeignKey(d => d.RoleID)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__TUserRole__RoleI__5441852A");

            entity.HasOne(d => d.User).WithMany(p => p.TUserRole)
            .HasForeignKey(d => d.UserID)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__TUserRole__UserI__534D60F1");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TUserRole> entity);
    }
}
