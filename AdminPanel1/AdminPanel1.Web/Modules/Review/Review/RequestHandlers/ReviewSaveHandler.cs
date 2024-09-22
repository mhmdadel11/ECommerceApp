using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel1.Review.ReviewRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel1.Review.ReviewRow;

namespace AdminPanel1.Review;

public interface IReviewSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewSaveHandler
{
    public ReviewSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}