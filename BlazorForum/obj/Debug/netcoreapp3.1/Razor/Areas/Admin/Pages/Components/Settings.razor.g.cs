#pragma checksum "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d9745b9c4d65c351b085d199ac5c2ae1642bb03"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Areas.Admin.Pages.Components
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/settings/")]
    public partial class Settings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Themes</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
 if (themeInfoList != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "forum-ul");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<li>\r\n            <div class=\"font-weight-bold\">Default Theme</div>\r\n            <div>The default theme is the fallback theme. It will be used when no other theme is selected.</div>\r\n        </li>\r\n");
#nullable restore
#line 15 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
         foreach (var theme in themeInfoList)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "font-weight-bold");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.AddContent(12, 
#nullable restore
#line 19 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
                     theme.ThemeName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddContent(16, 
#nullable restore
#line 21 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
                      theme.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "small");
            __builder.AddContent(19, "Author: ");
            __builder.AddContent(20, 
#nullable restore
#line 22 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
                                theme.Author

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " | Version: ");
            __builder.AddContent(22, 
#nullable restore
#line 22 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
                                                         theme.Version

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "<br>\r\n");
#nullable restore
#line 23 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
                 if(selectedTheme == theme.TextDomain)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "                    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
                                      UnselectTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "class", "btn btn-sm btn-blazorforum");
            __builder.AddContent(28, "Unselect");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 26 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                    ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
                                      (() => SelectTheme(theme.TextDomain))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "class", "btn btn-sm btn-blazorforum");
            __builder.AddContent(34, "Select Theme");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 30 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
                }  

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 32 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 34 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Settings.razor"
       
    private Theme sitetheme = new Theme();
    private List<ThemeInfo> themeInfoList = new List<ThemeInfo>();
    private string selectedTheme;

    protected override async Task OnInitializedAsync()
    {
        selectedTheme = await manageThemes.GetSelectedThemeNameAsync();

        var themes = System.IO.Directory.GetDirectories("wwwroot/custom-themes/");

        foreach (var theme in themes)
        {
            var lines = System.IO.File.ReadLines(theme + "/styles.css");

            if (lines != null && lines.Count() > 0)
            {
                var themeInfo = new ThemeInfo
                {
                    ThemeName = GetThemeInfo(lines, "Theme Name").Replace("Theme Name:", "").Trim(),
                    TextDomain = GetThemeInfo(lines, "Text Domain").Replace("Text Domain:", "").Trim(),
                    Author = GetThemeInfo(lines, "Author").Replace("Author:", "").Trim(),
                    Description = GetThemeInfo(lines, "Description").Replace("Description:","").Trim(),
                    Version = GetThemeInfo(lines, "Version").Replace("Version:","").Trim()
                };
                themeInfoList.Add(themeInfo);
            }
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await jsRuntime.InvokeVoidAsync("setDocTitle", "Settings | Administration");
    }

    private string GetThemeInfo(IEnumerable<string> lines, string ThemeProperty)
    {
        var line = lines.SkipWhile(p => !p.Contains(ThemeProperty + ":"))
            .TakeWhile(p => p.Contains(ThemeProperty + ":")).FirstOrDefault();
        return line;
    }

    private async Task UnselectTheme()
    {
        var removed = await manageThemes.RemoveThemesAsync();
        if(removed)
            selectedTheme = await manageThemes.GetSelectedThemeNameAsync();
        StateHasChanged();
    }

    private async Task SelectTheme(string textDomain)
    {
        var added = await manageThemes.AddThemeAsync(textDomain);
        if(added)
            selectedTheme = await manageThemes.GetSelectedThemeNameAsync();
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageThemes manageThemes { get; set; }
    }
}
#pragma warning restore 1591
