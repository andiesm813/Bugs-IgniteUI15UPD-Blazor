using System.Net.Http.Json;

namespace Bugs_after_Ignite_UI_15_update.MovieAppData
{
    public class MovieAppDataService: IMovieAppDataService
    {
        private readonly HttpClient _http;

        public MovieAppDataService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<NowPlayingType>> GetNowPlaying()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/15755be7-cee3-4b74-4382-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<NowPlayingType>>().ConfigureAwait(false);
            }

            return new List<NowPlayingType>();
        }
    }
}