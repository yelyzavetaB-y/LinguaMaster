using LinguaMaster.Domain.Common;
using LinguaMaster.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaMaster.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }

        public string Username { get; private set; }
        public string Email { get; private set; }

        public int Points { get; private set; }

        private readonly List<Progress> _progressRecords = new();
        public IReadOnlyCollection<Progress> ProgressRecords => _progressRecords.AsReadOnly();

        private readonly List<QuizResult> _quizResults = new();
        public IReadOnlyCollection<QuizResult> QuizResults => _quizResults.AsReadOnly();

        private User(string username, string email)
        {
            Id = Guid.NewGuid();
            Username = username;
            Email = email;
            Points = 0;
        }


        public static Result<User> Create(string username, string email)
        {
            var errors = UserValidator.Validate(username, email);
            if (errors.Any())
                return Result<User>.Failure(errors);

            return Result<User>.Success(new User(username, email));
        }
    }
}
