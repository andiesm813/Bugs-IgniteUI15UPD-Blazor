namespace Bugs_after_Ignite_UI_15_update.MovieAppData
{
    public class MockMovieAppDataService : IMovieAppDataService
    {
        public Task<List<NowPlayingType>> GetNowPlaying()
        {
            return Task.FromResult<List<NowPlayingType>>(new());
        }
    }
}