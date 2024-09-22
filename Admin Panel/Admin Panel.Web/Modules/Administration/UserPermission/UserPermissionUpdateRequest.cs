﻿namespace Admin_Panel.Administration;

public class UserPermissionUpdateRequest : ServiceRequest
{
    public int? UserID { get; set; }
    public List<UserPermissionRow> Permissions { get; set; }
}