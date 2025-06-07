using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaMaster.Domain.Entities
{
    public class Progress
    {
        public Guid Id { get; private set; }

        public Guid UserId { get; private set; }

        public bool Completed { get; private set; }
        public DateTime LastUpdated { get; private set; }

        public int? Score { get; private set; } 

        protected Progress() { }

        public Progress(Guid userId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Completed = false;
            LastUpdated = DateTime.UtcNow;
        }

        public void MarkCompleted(int? score = null)
        {
            Completed = true;
            Score = score;
            LastUpdated = DateTime.UtcNow;
        }

        public void UpdateScore(int score)
        {
            Score = score;
            LastUpdated = DateTime.UtcNow;
        }
    
    }
}
