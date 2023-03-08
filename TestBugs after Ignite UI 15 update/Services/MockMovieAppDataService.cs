namespace Bugs_after_Ignite_UI_15_update.MovieAppData
{
    public class MockMovieAppDataService : IMovieAppDataService
    {
        public Task<List<NowPlayingType>> GetNowPlaying()
        {
            return Task.FromResult<List<NowPlayingType>>(new());
        }

        public Task<List<MovieListType>> GetMovieList()
        {
            return Task.FromResult<List<MovieListType>>(new());
        }

        public Task<List<TheatresType>> GetTheatres()
        {
            return Task.FromResult<List<TheatresType>>(new());
        }

        public Task<List<ShowtimesType>> GetShowtimes()
        {
            return Task.FromResult<List<ShowtimesType>>(new());
        }

        public Task<List<TheatresNearYouType>> GetTheatresNearYou()
        {
            return Task.FromResult<List<TheatresNearYouType>>(new());
        }
    }
}