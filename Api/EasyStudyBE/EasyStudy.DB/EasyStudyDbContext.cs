using EasyStudy.Shared.Entities.Domain;
using Microsoft.EntityFrameworkCore;

namespace EasyStudy.DB;

public class EasyStudyDbContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    
    public DbSet<Subject> Subjects { get; set; }
    
    public DbSet<Student> Students { get; set; }
    
    public DbSet<Group> Groups { get; set; }
    
    public DbSet<Class> Classes { get; set; }
}