using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel1.Review.ReviewRow>;
using MyRow = AdminPanel1.Review.ReviewRow;

namespace AdminPanel1.Review;

public interface IReviewListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IReviewListHandler
{
    public ReviewListHandler(IRequestContext context)
            : base(context)
    {
    }
}