﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetApp.Controllers
{
    public class UserController : Controller
    {
        public UserController(UserManager<UserController> userManager)
        {

        }
    }
}
