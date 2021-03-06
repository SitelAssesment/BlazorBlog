#pragma checksum "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Pages\Components\Theme\ThemeSetter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc446ade10ca289f007a181b24767380cd8014c8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Pages.Components.Theme
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
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
#line 11 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\_Imports.razor"
using BlazorForum.Models;

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
    public partial class ThemeSetter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Pages\Components\Theme\ThemeSetter.razor"
   
    // This may need to be changed using an await if it starts causing issues with DbContext conflicts
    string themeName = ThemeName;

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Pages\Components\Theme\ThemeSetter.razor"
       
    [Parameter] public string ThemeName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        ThemeName = await themeManager.GetSelectedThemeNameAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageThemes themeManager { get; set; }
    }
}
#pragma warning restore 1591
