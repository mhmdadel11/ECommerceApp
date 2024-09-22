using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel1.SouqCom.CategoryRow>;
using MyRow = AdminPanel1.SouqCom.CategoryRow;

namespace AdminPanel1.SouqCom;

public interface ICategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryListHandler
{
    public CategoryListHandler(IRequestContext context)
            : base(context)
    {
    }
}