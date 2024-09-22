using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel1.SouqCom.CartRow>;
using MyRow = AdminPanel1.SouqCom.CartRow;

namespace AdminPanel1.SouqCom;

public interface ICartListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CartListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICartListHandler
{
    public CartListHandler(IRequestContext context)
            : base(context)
    {
    }
}