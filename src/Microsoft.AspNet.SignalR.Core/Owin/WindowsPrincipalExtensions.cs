// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using System.Security.Principal;

namespace Microsoft.AspNet.SignalR.Owin
{
    internal static class WindowsPrincipalExtensions
    {
        public static WindowsPrincipal Copy(this WindowsPrincipal principal)
        {
            // TODO: Check if Identity is null or isn't a WindowsIdentity
            var userToken = ((WindowsIdentity)principal.Identity).Token;
            // TODO: Are we using the correct ctor for WindowsIdentity
            return new WindowsPrincipal(new WindowsIdentity(userToken));
        }
    }
}
