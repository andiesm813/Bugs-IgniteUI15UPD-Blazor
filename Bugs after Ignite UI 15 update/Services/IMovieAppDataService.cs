namespace Bugs_after_Ignite_UI_15_update.MovieAppData
{
    public interface IMovieAppDataService
    {
        Task<List<NowPlayingType>> GetNowPlaying();
    }
}