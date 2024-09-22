﻿using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Admin_Panel.Administration;
public partial class RoleCheckEditorAttribute : CustomEditorAttribute
{
    public const string Key = "Admin_Panel.Administration.RoleCheckEditor";

    public RoleCheckEditorAttribute()
        : base(Key)
    {
    }
}