﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Examination_System_Web_App.Models;

public partial class Course
{
    public int crs_id { get; set; }

    public string crs_name { get; set; }

    public int? crs_duration { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<Std_course> Std_courses { get; set; } = new List<Std_course>();

    public virtual ICollection<Topic> Topics { get; set; } = new List<Topic>();

    public virtual ICollection<Department> dept_nos { get; set; } = new List<Department>();

    public virtual ICollection<Instructor> ins { get; set; } = new List<Instructor>();
}