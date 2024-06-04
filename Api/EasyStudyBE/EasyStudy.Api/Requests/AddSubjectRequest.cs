using EasyStudy.Shared.Entities.Domain;

namespace EasyStudy.Api.Requests;

public class AddSubjectRequest
{
    public string Name { get; set; }
    
    public List<Teacher> Teachers { get; set; }
}