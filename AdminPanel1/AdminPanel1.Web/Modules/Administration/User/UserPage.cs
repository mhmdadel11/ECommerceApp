﻿using System.Threading.Tasks;

namespace AdminPanel1.Administration.Pages;
[PageAuthorize(typeof(UserRow))]
public class UserPage : Controller
{
    [Route("Administration/User")]
    public ActionResult Index()
    {
        return this.GridPage("@/Administration/User/UserPage",
            UserRow.Fields.PageTitle());
    }
}