using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel1.SouqCom.CartRow;

namespace AdminPanel1.SouqCom;

public interface ICartDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CartDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICartDeleteHandler
{
    public CartDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}