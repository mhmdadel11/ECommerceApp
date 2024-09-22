﻿using MyRequest = AdminPanel1.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel1.Administration.UserRow>;
using MyRow = AdminPanel1.Administration.UserRow;

namespace AdminPanel1.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}