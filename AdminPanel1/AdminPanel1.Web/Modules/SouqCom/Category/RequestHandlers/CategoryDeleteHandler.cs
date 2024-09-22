using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel1.SouqCom.CategoryRow;

namespace AdminPanel1.SouqCom;

public interface ICategoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CategoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryDeleteHandler
{
    public CategoryDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}