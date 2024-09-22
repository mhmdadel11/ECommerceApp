using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel1.SouqCom.CartRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel1.SouqCom.CartRow;

namespace AdminPanel1.SouqCom;

public interface ICartSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CartSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICartSaveHandler
{
    public CartSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}