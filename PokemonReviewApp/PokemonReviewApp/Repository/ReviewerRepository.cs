using PokemonReviewApp.Interface;
using PokemonReviewApp.models;

namespace PokemonReviewApp.Repository
{
    public class ReviewerRepository : IReviewerRepository
    {
        public Reviewer GetReviewer(int reviewerId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            throw new NotImplementedException();
        }

        public ICollection<Review> GetReviewsByReviewer(int reviewerId)
        {
            throw new NotImplementedException();
        }

        public bool ReviewerExists(int reviewerId)
        {
            throw new NotImplementedException();
        }
    }
}
