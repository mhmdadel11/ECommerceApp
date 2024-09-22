using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel1.SouqCom.CategoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel1.SouqCom.CategoryRow;

namespace AdminPanel1.SouqCom;

public interface ICategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CategorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategorySaveHandler
{
    public CategorySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}