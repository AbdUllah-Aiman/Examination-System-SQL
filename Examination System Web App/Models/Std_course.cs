﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Examination_System_Web_App.Models;

public partial class Std_course
{
    public int std_id { get; set; }

    public int crs_id { get; set; }

    public int? grade { get; set; }

    public string status { get; set; }

    public virtual Course crs { get; set; }

    public virtual Student std { get; set; }
}