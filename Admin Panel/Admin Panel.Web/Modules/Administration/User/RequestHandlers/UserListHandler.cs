using MyRequest = Admin_Panel.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<Admin_Panel.Administration.UserRow>;
using MyRow = Admin_Panel.Administration.UserRow;

namespace Admin_Panel.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}