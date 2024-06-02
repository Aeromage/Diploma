using EasyStudy.Shared.Entities.Domain;

namespace EasyStudy.Shared.Services;

public interface ICommentService
{
    Task AddCommentAsync(Comment newComment, CancellationToken token);

    Task UpdateCommentAsync(Comment updatedComment, CancellationToken token);

    Task RemoveComment(int commentId, CancellationToken token);

    Task<Comment> GetCommentAsync(int commentId, CancellationToken token);

    Task<List<Comment>> GetAllAsync(CancellationToken token);
}