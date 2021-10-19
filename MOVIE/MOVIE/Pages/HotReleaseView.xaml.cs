using MOVIE.Models;
using MOVIE.Services;
using MOVIE.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MOVIE.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotReleaseView : ContentPage
    {
        HotReleaseViewModel hotReleaseModel;

        public HotReleaseView()
        {
            InitializeComponent();
            this._hotReleaseListInit();
            hotReleaseModel = new HotReleaseViewModel();
            BindingContext = hotReleaseModel;
        }

        public async void _hotReleaseListInit()
        {
            collectionView.ItemsSource = await new HotReleaseService()._getHotReleaseList();
        }
    }
}