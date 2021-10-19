using MOVIE.Models;
using MOVIE.Services;
using MOVIE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MOVIE.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FAQView : ContentPage
    {
        FaqViewModel faqModel;
        public FAQView()
        {
            InitializeComponent();
            this._loadFaqQuestionList();
            faqModel = new FaqViewModel();
            BindingContext = faqModel;
        }

        public void _loadFaqQuestionList()
        {
            faqCollectionView.ItemsSource = new FaqService()._loadFaqQuestionList();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}
