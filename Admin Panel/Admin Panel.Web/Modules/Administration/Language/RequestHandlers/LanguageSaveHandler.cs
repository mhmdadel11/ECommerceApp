using MyRequest = Serenity.Services.SaveRequest<Admin_Panel.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Admin_Panel.Administration.LanguageRow;


namespace Admin_Panel.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}