using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaMaster.Domain.Entities
{
    public class UserAnswer
    {
        public Guid Id { get; private set; }
        public Guid QuizResultId { get; private set; }
        public Guid QuestionId { get; private set; }
        public string Answer { get; private set; }
        public bool IsCorrect { get; private set; }
    }

}
