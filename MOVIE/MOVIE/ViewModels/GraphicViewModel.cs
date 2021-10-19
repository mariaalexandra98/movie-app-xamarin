using MOVIE.Models;
using MOVIE.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Entry = Microcharts.ChartEntry;

namespace MOVIE.ViewModels
{
    class GraphicViewModel
    {
        List<string> colorCodes = new List<string>() { "#DAF7A6", "#FFC300", "#FF5733", "#C70039 " };
        public List<Entry> popularityEntryList = new List<Entry>();
        public List<Entry> ratingEntryList = new List<Entry>();
        public List<Entry> revenueEntryList = new List<Entry>();

        public async Task<List<Entry>> LoadChartEntriesByPopularity()
        {
            List<Movie> movies = await new GraphicService().FilterMoviesByPopularity();
            foreach (Movie movie in movies)
            {
                popularityEntryList.Add(new Entry((float)movie.Popularity)
                {
                    Label = movie.OriginalTitle.ToString(),
                    ValueLabel = (movie.Popularity).ToString(),
                    Color = SkiaSharp.SKColor.Parse(colorCodes[movies.IndexOf(movie)])
                });
            }
            return popularityEntryList;
        }

        public async Task<List<Entry>> LoadChartEntriesByRevenue()
        {
            List<Movie> movies = await new GraphicService().FilterMoviesByRevenue();
            foreach (Movie movie in movies)
            {
                revenueEntryList.Add(new Entry((float)movie.Revenue)
                {
                    Label = movie.OriginalTitle.ToString(),
                    ValueLabel = (movie.Revenue).ToString("#,###.###$"),
                    Color = SkiaSharp.SKColor.Parse(colorCodes[movies.IndexOf(movie)])
                });
            }
            return revenueEntryList;
        }

        public async Task<List<Entry>> LoadChartEntriesByVote()
        {
            List<Movie> movies = await new GraphicService().FilterMoviesByVote();
            foreach (Movie movie in movies)
            {
                ratingEntryList.Add(new Entry((float)movie.VoteAverage)
                {
                    Label = movie.OriginalTitle.ToString(),
                    ValueLabel = (movie.VoteAverage).ToString(),
                    ValueLabelColor = SkiaSharp.SKColor.Parse(colorCodes[movies.IndexOf(movie)]),
                    Color = SkiaSharp.SKColor.Parse(colorCodes[movies.IndexOf(movie)])
                });
            }
            return ratingEntryList;
        }
    }
}
