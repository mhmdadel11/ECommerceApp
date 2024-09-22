using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel1.Product.ProductRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel1.Product.ProductRow;

namespace AdminPanel1.Product;

public interface IProductSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductSaveHandler
{
    public ProductSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}