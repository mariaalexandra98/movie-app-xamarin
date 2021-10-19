using MOVIE.Models;
using MOVIE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOVIE.ViewModels
{
    class FaqViewModel
    {
        public List<Faq> faqList { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public FaqViewModel()
        {
            this._faqListInit();
        }

        public void _faqListInit()
        {
            this.faqList = new FaqService()._loadFaqQuestionList();
        }
    }
}
