﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace FagElGamousExcavation.Pages
{
    [Authorize(Roles = "Admins")]
    public class AdminPageModel: PageModel
    {
    }
}
