using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AweBlazor.Data
{
    public class Option
    {
        public int Id { get; set; }
        public string OptionsName { get; set; }
        public string IsCorrect { get; set; }
        public int QuestionId { get; set; }

        [NotMapped]
        public virtual Question Question { get; set; }
    }
}