using MOVIE.Models;
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
    public partial class WatchListView : ContentPage
    {
        WatchlistViewModel viewModel;
   
        public WatchListView()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<MovieListViewModel, object>(this, "added", (sender, arg) =>
            {
                if(!viewModel.watchList.Contains(arg as Movie))
                {
                    viewModel.watchList.Add(arg as Movie);
                }
            });
            viewModel = new WatchlistViewModel();
            BindingContext = viewModel;
        }

    }
}