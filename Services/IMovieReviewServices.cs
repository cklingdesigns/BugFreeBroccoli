using BugFreeBroccoli.Models;

namespace BugFreeBroccoli.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();
        MovieModel? GetMovieById(int id);
    }
}