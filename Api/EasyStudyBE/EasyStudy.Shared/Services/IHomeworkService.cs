using EasyStudy.Shared.Entities;
using EasyStudy.Shared.Entities.Domain;

namespace EasyStudy.Shared.Services;

public interface IHomeworkService
{
    Task AddHomeworkAsync(Homework newHomework, Stream file, CancellationToken token);

    Task UpdateHomeworkAsync(Homework updatedHomework, Stream file, CancellationToken token);

    Task RemoveHomework(int homeworkId, CancellationToken token);

    Task<Homework> GetHomeworkAsync(int homeworkId, CancellationToken token);

    Task<List<Homework>> GetAllAsync(CancellationToken token);
}