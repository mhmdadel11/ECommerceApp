using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel1.Product.ProductRow>;
using MyRow = AdminPanel1.Product.ProductRow;

namespace AdminPanel1.Product;

public interface IProductRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductRetrieveHandler
{
    public ProductRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}