﻿namespace AdminPanel1.Administration;

public class UserPermissionUpdateRequest : ServiceRequest
{
    public int? UserID { get; set; }
    public List<UserPermissionRow> Permissions { get; set; }
}