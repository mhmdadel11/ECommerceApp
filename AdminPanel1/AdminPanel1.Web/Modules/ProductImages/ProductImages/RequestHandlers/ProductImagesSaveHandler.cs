using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel1.ProductImages.ProductImagesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel1.ProductImages.ProductImagesRow;

namespace AdminPanel1.ProductImages;

public interface IProductImagesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagesSaveHandler
{
    public ProductImagesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}