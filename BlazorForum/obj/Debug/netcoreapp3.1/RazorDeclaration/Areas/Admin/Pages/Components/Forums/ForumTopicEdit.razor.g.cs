#pragma checksum "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e67b2735ca68a00e2e48cfbe1b6e2ed80a2955f2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorForum.Areas.Admin.Pages.Components.Forums
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 9 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using BlazorForum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using BlazorForum.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using Domain.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using BlazorForum.Domain.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using Domain.Utilities.Formatting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/forums/{forumId:int}/categories/{categoryId:int}/topics/{topicId:int}/edit")]
    public partial class ForumTopicEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
       
    [Parameter] public int forumId { get; set; }
    [Parameter] public int categoryId { get; set; }
    [Parameter] public int topicId { get; set; }
    private Models.ForumTopic _topic = new Models.ForumTopic();

    protected override async Task OnInitializedAsync()
    {
        _topic = await manageTopics.GetForumTopicAsync(topicId);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("methods.loadEditor", "TopicText");
        }
    }

    private async void UpdateTopicAsync()
    {
        // Should probably eventually validate to make sure topic text isn't empty (CKEditor has a placeholder tag)...but only administrators can edit it at this point.
        _topic.TopicText = await jsRuntime.InvokeAsync<string>("methods.getEditorText");
        _topic.IsModeratorChanged = true;
        _topic.EditedDate = DateTime.Now.ToUniversalTime();
        _topic.EditedBy = await new Domain.Utilities.Membership.UserInfo(userManager, authStateProvider).GetUserId();

        var updated = await manageTopics.UpdateTopicAsync(_topic);
        if (updated)
            navManager.NavigateTo(String.Format("/admin/forums/{0}/categories/{1}/topics/{2}", forumId, categoryId, topicId));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumTopics manageTopics { get; set; }
    }
}
#pragma warning restore 1591
