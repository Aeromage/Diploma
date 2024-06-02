namespace EasyStudy.Shared.Entities.Domain;

public class Comment : BaseEntity
{
    public string CommentText { get; set; }
    
    public Student Student { get; set; }
    
    public Teacher Teacher { get; set; }
}