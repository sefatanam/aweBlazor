using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AweBlazor.Data
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionName { get; set; }
        public int? OptionId { get; set; }
        public virtual ICollection<Option> Options { get; set; }
    }
}