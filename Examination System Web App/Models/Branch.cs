﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Examination_System_Web_App.Models;

public partial class Branch
{
    public int branch_no { get; set; }

    public string branch_name { get; set; }

    public string location { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Works_in> Works_ins { get; set; } = new List<Works_in>();
}