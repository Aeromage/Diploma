using EasyStudy.Shared.Data;
using EasyStudy.Shared.Entities.Domain;

namespace EasyStudy.DB.Repositories;

public class CommentRepository : BaseRepository<Comment>, IRepository<Comment>
{
    public CommentRepository(EasyStudyDbContext context) : base(context)
    {
    }
}