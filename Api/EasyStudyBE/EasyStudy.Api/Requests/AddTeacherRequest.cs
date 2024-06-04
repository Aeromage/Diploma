using EasyStudy.Shared.Entities.Domain;

namespace EasyStudy.Api.Requests;

public class AddTeacherRequest
{
    public string FullName { get; set; }
    
    public string Email { get; set; }
    
    public List<Subject> Subjects { get; set; }
    
    public List<Group> Groups { get; set; }
}