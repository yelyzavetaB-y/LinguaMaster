using LinguaMaster.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaMaster.Application.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<User> Users { get; }
        DbSet<Quiz> Quizzes { get; }
        DbSet<Question> Questions { get; }
        DbSet<QuizResult> QuizResults { get; }
        DbSet<Progress> ProgressRecords { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
