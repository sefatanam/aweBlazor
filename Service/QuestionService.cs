using AweBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AweBlazor.Service
{
    public class QuestionService
    {
        private List<Question> _questions = new List<Question>()
        {
            new Question(){Id=1,QuestionName="How Are You?",QuestionOptions="Good,Bad"},
            new Question(){Id=2,QuestionName="How Are You?",QuestionOptions="Good,Bad"},
            new Question(){Id=3,QuestionName="How Are You?",QuestionOptions="Good,Bad"},
            new Question(){Id=4,QuestionName="How Are You?",QuestionOptions="Good,Bad"},
            new Question(){Id=5,QuestionName="How Are You?",QuestionOptions="Good,Bad"},
            new Question(){Id=6,QuestionName="How Are You?",QuestionOptions="Good,Bad"},
        };

        public Question GetQuestionById(int id)
        {
            return _questions.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Question> GetAllQuestion()
        {
            return _questions;
        }
    }
}