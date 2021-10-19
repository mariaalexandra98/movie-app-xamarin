using MOVIE.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE.Services
{
    class GraphicService
    {
        public async Task<List<Movie>> FilterMoviesByVote()
        {
            List<Movie> movies = await new HotReleaseService()._getHotReleaseList();
            movies.Sort((m1, m2) => m2.VoteAverage.CompareTo(m1.VoteAverage));
            List<Movie> orderedMovieList = movies.GetRange(0, 4);
            return orderedMovieList;
        }

        public async Task<List<Movie>> FilterMoviesByPopularity()
        {
            List<Movie> movies = await new HotReleaseService()._getHotReleaseList();
            movies.Sort((m1, m2) => m2.Popularity.CompareTo(m1.Popularity));
            List<Movie> orderedMovieList = movies.GetRange(0, 4);
            return orderedMovieList;
        }

        public async Task<List<Movie>> FilterMoviesByRevenue()
        {
            List<Movie> movies = await new HotReleaseService()._getHotReleaseList();
            movies.Sort((m1, m2) => m2.Revenue.CompareTo(m1.Revenue));
            List<Movie> orderedMovieList = movies.GetRange(0, 4);
            return orderedMovieList;
        }
    }
}
