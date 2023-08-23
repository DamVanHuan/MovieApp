using MediatR;

namespace MovieApp.Applications.Queries.Movies
{
    public class GetReactionsQuery : IRequest<ReactionDTO>
    {
        public int UserId { get; private set; }

        public GetReactionsQuery(int userId)
        {
            UserId = userId;
        }
    }

    public class ReactionDTO
    {
        public IEnumerable<int> Likeds { get; set; }
        public IEnumerable<int> Dislikeds { get; set; }
    }
}
