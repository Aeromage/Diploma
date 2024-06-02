using EasyStudy.Shared.Entities.Domain;
using EasyStudy.Shared.Services;

namespace EasyStudy.Service.Services;

public class CommentService : ICommentService
{
    public async Task AddCommentAsync(Comment newComment, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateCommentAsync(Comment updatedComment, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public async Task RemoveComment(int commentId, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public async Task<Comment> GetCommentAsync(int commentId, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Comment>> GetAllAsync(CancellationToken token)
    {
        throw new NotImplementedException();
    }
}