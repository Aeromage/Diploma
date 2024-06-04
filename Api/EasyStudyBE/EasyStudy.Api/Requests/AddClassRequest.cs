using System.ComponentModel.DataAnnotations;
using EasyStudy.Shared.Entities.Domain;

namespace EasyStudy.Api.Requests;

public class AddClassRequest
{
    public Teacher Teacher { get; set; }
    
    public Subject Subject { get; set; }
    
    public Group Group { get; set; }
    
    public DateTime DateBegin { get; set; }
    
    [MaxLength(255)]
    public string LinkToClass { get; set; }
    
    [MaxLength(255)]
    public string Place { get; set; }
}