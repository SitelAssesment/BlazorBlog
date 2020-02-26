﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorForum.Domain.Utilities.Membership
{
    public class UserInfo
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly AuthenticationStateProvider _authStateProvider;

        public UserInfo(UserManager<IdentityUser> userManager, AuthenticationStateProvider authStateProvider)
        {
            _userManager = userManager;
            _authStateProvider = authStateProvider;
        }

        public async Task<string> GetUserId()
        {
            var user = await GetCurrentUser();
            return user?.Id;
        }

        private async Task<IdentityUser> GetCurrentUser()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                var currentUser = await _userManager.GetUserAsync(user);
                return currentUser;
            }
            return null;
        }
    }
}
