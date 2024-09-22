using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel1.ProductImages.ProductImagesRow>;
using MyRow = AdminPanel1.ProductImages.ProductImagesRow;

namespace AdminPanel1.ProductImages;

public interface IProductImagesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagesRetrieveHandler
{
    public ProductImagesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}