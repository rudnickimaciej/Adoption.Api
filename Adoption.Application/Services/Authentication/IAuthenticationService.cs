﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
        Task<AuthenticationResult> Login(string email, string password);

    }
}
