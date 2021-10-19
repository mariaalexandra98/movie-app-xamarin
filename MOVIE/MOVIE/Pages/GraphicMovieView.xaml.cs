using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entry = Microcharts.ChartEntry;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;
using MOVIE.Services;
using MOVIE.Models;
using MOVIE.ViewModels;

namespace MOVIE.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraphicMovieView : ContentPage
    {
        List<Entry> entries = new List<Entry>();

        public GraphicMovieView()
        {
            InitializeComponent();
            InitPicker();
        }

        private void InitPicker()
        {
            chartPicker.Items.Add("Vizualizeaza situatie in functie de scor");
            chartPicker.Items.Add("Vizualizeaza situatie in functie de popularitate");
            chartPicker.Items.Add("Vizualizeaza situatie in functie de incasari");
            chartPicker.SelectedIndex = 0;
        }

        private void LoadChartDataByVote()
        {
            Chart.Chart = new RadialGaugeChart
            {
                Entries = entries
            };
        }

        private void LoadChartDataByPopulatiry()
        {
            Chart.Chart = new LineChart
            {
                Entries = entries,
                ValueLabelOrientation = Orientation.Horizontal,
                LabelOrientation = Orientation.Vertical
            };
        }

        private void LoadChartDataByRevenue()
        {
            Chart.Chart = new BarChart
            {
                Entries = entries,
                ValueLabelOrientation = Orientation.Horizontal,
                LabelOrientation = Orientation.Vertical
            };
        }


        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chartPicker.SelectedIndex == 0)
            {
                entries.Clear();
                entries = await new GraphicViewModel().LoadChartEntriesByVote();
                LoadChartDataByVote();
            }
            else if (chartPicker.SelectedIndex == 1)
            {
                entries.Clear();
                entries = await new GraphicViewModel().LoadChartEntriesByPopularity();
                LoadChartDataByPopulatiry();
            }
            else
            {
                entries.Clear();
                entries = await new GraphicViewModel().LoadChartEntriesByRevenue();
                LoadChartDataByRevenue();
            }
        }
    }
}