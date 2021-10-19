using MOVIE.Models;
using MOVIE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOVIE.ViewModels
{
    class HotReleaseViewModel
    {
        public List<Movie> movieList { get; set; }
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public string PosterPath { get; set; }

        public HotReleaseViewModel()
        {
            this._movieListInit();
        }

        public async void _movieListInit()
        {
            this.movieList = await new HotReleaseService()._getHotReleaseList();
        }
    }
}
