using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel1.Product.ProductRow>;
using MyRow = AdminPanel1.Product.ProductRow;

namespace AdminPanel1.Product;

public interface IProductListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProductListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductListHandler
{
    public ProductListHandler(IRequestContext context)
            : base(context)
    {
    }
}