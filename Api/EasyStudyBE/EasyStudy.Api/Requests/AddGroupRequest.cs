using EasyStudy.Shared.Entities.Domain;

namespace EasyStudy.Api.Requests;

public class AddGroupRequest
{
    public string GroupName { get; set; }
    
    public IEnumerable<Student> Students { get; set; }
}