using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AweBlazor.Data
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionName { get; set; }
        public string QuestionType { get; set; }
        public int OptionId { get; set; }

        [NotMapped]
        public virtual Option Options { get; set; }
    }
}