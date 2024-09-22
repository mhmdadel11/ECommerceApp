using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel1.Review.ReviewRow>;
using MyRow = AdminPanel1.Review.ReviewRow;

namespace AdminPanel1.Review;

public interface IReviewRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewRetrieveHandler
{
    public ReviewRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}