﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MIS4663_FieldProject_Group2.Models;

public partial class TUsers
{
    public int UserID { get; set; }

    public int ContactID { get; set; }

    public string Username { get; set; }

    public virtual TContact Contact { get; set; }

    public virtual ICollection<TProject> TProject { get; set; } = new List<TProject>();

    public virtual ICollection<TUserRole> TUserRole { get; set; } = new List<TUserRole>();
}