using MyRequest = Serenity.Services.SaveRequest<AdminPanel1.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel1.Administration.LanguageRow;


namespace AdminPanel1.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}