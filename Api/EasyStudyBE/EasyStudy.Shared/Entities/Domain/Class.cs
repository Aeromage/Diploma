﻿using System.ComponentModel.DataAnnotations;

namespace EasyStudy.Shared.Entities.Domain;

/// <summary>
/// Indicates single lesson
/// </summary>
public class Class : BaseEntity
{
    public Teacher Teacher { get; set; }
    
    public Subject Subject { get; set; }
    
    public Group Group { get; set; }
    
    public DateTime DateBegin { get; set; }
    
    [MaxLength(255)]
    public string LinkToClass { get; set; }
    
    [MaxLength(255)]
    public string Place { get; set; }
    
    /// <summary>
    /// Grades given to students (id)
    /// </summary>
    public Dictionary<int, Grade> ClassGrades { get; set; }
}