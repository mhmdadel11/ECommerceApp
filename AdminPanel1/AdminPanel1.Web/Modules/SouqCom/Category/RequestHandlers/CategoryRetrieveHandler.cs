using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel1.SouqCom.CategoryRow>;
using MyRow = AdminPanel1.SouqCom.CategoryRow;

namespace AdminPanel1.SouqCom;

public interface ICategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CategoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryRetrieveHandler
{
    public CategoryRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}