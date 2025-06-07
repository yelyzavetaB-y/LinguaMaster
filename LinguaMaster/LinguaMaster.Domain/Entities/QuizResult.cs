using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaMaster.Domain.Entities
{
    public class QuizResult
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public Guid QuizId { get; private set; }
        public int Score { get; private set; }
        public DateTime SubmittedAt { get; private set; }
        public int TotalQuestions { get; private set; }
        public int CorrectAnswers { get; private set; }

        protected QuizResult() { }

        public QuizResult(Guid userId, Guid quizId, int score, int totalQuestions, int correctAnswers)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            QuizId = quizId;
            Score = score;
            TotalQuestions = totalQuestions;
            CorrectAnswers = correctAnswers;
            SubmittedAt = DateTime.UtcNow;
        }
    }
}
