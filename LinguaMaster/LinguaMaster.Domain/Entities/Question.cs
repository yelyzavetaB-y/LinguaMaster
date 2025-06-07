using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaMaster.Domain.Entities
{
    public class Question
    {
        public Guid Id { get; private set; }
        public Guid QuizId { get; private set; }

        public string Text { get; private set; }

        private readonly List<string> _options = new();
        public IReadOnlyCollection<string> Options => _options.AsReadOnly();

        public string CorrectAnswer { get; private set; }

        protected Question() { }

        public Question(Guid quizId, string text, List<string> options, string correctAnswer)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Question text is required.");

            if (options == null || options.Count < 2)
                throw new ArgumentException("At least two options are required.");

            if (!options.Contains(correctAnswer))
                throw new ArgumentException("Correct answer must be one of the options.");

            Id = Guid.NewGuid();
            QuizId = quizId;
            Text = text;
            _options.AddRange(options);
            CorrectAnswer = correctAnswer;
        }

        public bool IsCorrect(string answer)
        {
            return string.Equals(CorrectAnswer, answer?.Trim(), StringComparison.OrdinalIgnoreCase);
        }
    }
}
