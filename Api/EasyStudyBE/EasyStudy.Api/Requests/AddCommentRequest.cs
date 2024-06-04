using EasyStudy.Shared.Entities.Domain;

namespace EasyStudy.Api.Requests;

public class AddCommentRequest
{
    public string CommentText { get; set; }
    
    public Student Student { get; set; }
    
    public Teacher Teacher { get; set; }
}