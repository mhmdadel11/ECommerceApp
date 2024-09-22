using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel1.ProductImages.ProductImagesRow>;
using MyRow = AdminPanel1.ProductImages.ProductImagesRow;

namespace AdminPanel1.ProductImages;

public interface IProductImagesListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagesListHandler
{
    public ProductImagesListHandler(IRequestContext context)
            : base(context)
    {
    }
}