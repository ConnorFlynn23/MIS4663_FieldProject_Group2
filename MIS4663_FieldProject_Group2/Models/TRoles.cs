﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MIS4663_FieldProject_Group2.Models;

public partial class TRoles
{
    public int RoleID { get; set; }

    public string RoleDesc { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<TPermissions> TPermissions { get; set; } = new List<TPermissions>();

    public virtual ICollection<TUserRole> TUserRole { get; set; } = new List<TUserRole>();
}