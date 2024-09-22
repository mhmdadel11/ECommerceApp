using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel1.SouqCom.CartRow>;
using MyRow = AdminPanel1.SouqCom.CartRow;

namespace AdminPanel1.SouqCom;

public interface ICartRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CartRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICartRetrieveHandler
{
    public CartRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}