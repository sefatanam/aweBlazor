using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AweBlazor.Data
{
    public class HelperModel
    {

        public int Count { get; set; }

        public List<Question> QuestionsLists { get; set; }
        public UserSubmitAnswer UserSubmitAnswers { get; set; }
    }
}
