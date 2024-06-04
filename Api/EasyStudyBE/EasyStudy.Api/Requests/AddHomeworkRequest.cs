using EasyStudy.Shared.Entities.Domain;

namespace EasyStudy.Api.Requests;

public class AddHomeworkRequest
{
    public Class Class { get; set; }
    
    public IFormFile Homework { get; set; }
}