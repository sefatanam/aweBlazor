using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AweBlazor.Data
{
    public class Question
    {
        //Advance Slot

        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public virtual ICollection<Option> Options { get; set; }

        // Basic Slot
        //public int Id { get; set; }
        //public string QuestionName { get; set; }
        //public string QuestionType { get; set; }
        //public int OptionId { get; set; }
        //[NotMapped]
        //public virtual Option Options { get; set; }
    }
}