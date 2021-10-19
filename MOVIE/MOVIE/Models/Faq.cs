using System;
using System.Collections.Generic;
using System.Text;

namespace MOVIE.Models
{
    public class Faq
    {

        public Faq(string question, string answer)
        {
            this.Question = question;
            this.Answer = answer;
        }

        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
