using AweBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AweBlazor.Service
{
    public class QuestionService
    {
        readonly private ProjectDbContext _db;

        public QuestionService(ProjectDbContext projectDbContext)
        {
            _db = projectDbContext;
        }

        public Question GetQuestion(int id)
        {
            var dataList = _db.Questions.Find(id);
            var option = _db.Options.Where(c => c.QuestionId == id).ToList();
            dataList.Options = option;
            return dataList;
        }

        public List<Question> GetAllQuestionWithMultipleChoices()
        {
            var questionList = _db.Questions.ToList();
            var optionList = _db.Options.ToList();
            foreach (var item in questionList)
            {
                var option = optionList.Where(c => c.QuestionId == item.Id).ToList();
                item.Options = option;
            }
            return questionList;
        }


        public List<Question> GetAllQuestionList()
        {
            return _db.Questions.ToList();
        }

        public UserSubmitAnswer GetSubmitedAnswer(UserSubmitAnswer obj)
        {
            return obj;
        }

    }
}