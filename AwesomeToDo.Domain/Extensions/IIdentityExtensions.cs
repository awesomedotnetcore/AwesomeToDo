﻿using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using AwesomeToDo.Core.Exceptions;

namespace AwesomeToDo.Domain.Extensions
{
    public static class IIdentityExtensions
    {
        public static Guid GetUserIdIfExist(this IIdentity identity)
        {
            var id = identity.Name;
            if (string.IsNullOrEmpty(id))
            {
                throw new AwesomeToDoException(ErrorCode.InvalidUserClaimName);
            }
            return Guid.Parse(id);
        }
    }
}
