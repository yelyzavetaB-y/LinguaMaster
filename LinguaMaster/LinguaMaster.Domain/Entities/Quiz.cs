using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaMaster.Domain.Entities
{
    public class Quiz
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Category { get; private set; }
        public List<Question> Questions { get; private set; }
    }

}
