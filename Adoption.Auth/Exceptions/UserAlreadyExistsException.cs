﻿using Adoption.Shared.Abstractions.Exceptions;
using System.Net;

namespace Adoption.Auth.Exceptions
{
    public class UserAlreadyExistsException : CustomException
    {
        public UserAlreadyExistsException() : base($"User already exists.")
        {
        }
    }
}
