using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AweBlazor.Data
{
    public class UserSubmitAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }
        public bool IsCorrect { get; set; }
    }
}
