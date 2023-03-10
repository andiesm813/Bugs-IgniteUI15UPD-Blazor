namespace Bugs_after_Ignite_UI_15_update.MovieAppData1
{
    public interface IMovieAppData1Service
    {
        Task<List<NowPlayingType>> GetNowPlaying();

        Task<List<MovieListType>> GetMovieList();

        Task<List<TheatresType>> GetTheatres();

        Task<List<ShowtimesType>> GetShowtimes();

        Task<List<TheatresNearYouType>> GetTheatresNearYou();
    }
}