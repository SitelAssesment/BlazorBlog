#pragma checksum "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e67b2735ca68a00e2e48cfbe1b6e2ed80a2955f2"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Edit Topic</h3>\r\n");
#nullable restore
#line 9 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
 if (_topic != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "section");
            __builder.AddAttribute(3, "class", "content-container");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                         _topic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                                UpdateTopicAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "input-group");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<div class=\"input-group-prepend\">\r\n                    <label class=\"input-group-text\">Title</label>\r\n                </div>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                        _topic.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _topic.Title = __value, _topic.Title))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _topic.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __Blazor.BlazorForum.Areas.Admin.Pages.Components.Forums.ForumTopicEdit.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#nullable restore
#line 20 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                      () => _topic.Title

#line default
#line hidden
#nullable disable
                , 25, "text-danger");
                __builder2.AddMarkupContent(26, "\r\n\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "container-fluid p-0");
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "row");
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-12 col-md-6");
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "input-group mt-2");
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.AddMarkupContent(39, "<div class=\"input-group-prepend\">\r\n                                <label class=\"input-group-text\">Is Approved</label>\r\n                            </div>\r\n                            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(43);
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                                            _topic.IsApproved

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _topic.IsApproved = __value, _topic.IsApproved))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => _topic.IsApproved));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-12 col-md-6");
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "input-group mt-2");
                __builder2.AddMarkupContent(56, "\r\n                            ");
                __builder2.AddMarkupContent(57, "<div class=\"input-group-prepend\">\r\n                                <label class=\"input-group-text\">Flags</label>\r\n                            </div>\r\n                            ");
                __Blazor.BlazorForum.Areas.Admin.Pages.Components.Forums.ForumTopicEdit.TypeInference.CreateInputNumber_1(__builder2, 58, 59, "form-control", 60, 
#nullable restore
#line 39 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                                      _topic.Flags

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _topic.Flags = __value, _topic.Flags)), 62, () => _topic.Flags);
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n\r\n            ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "mt-2 ckeditor-container");
                __builder2.AddMarkupContent(70, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(71);
                __builder2.AddAttribute(72, "id", "TopicText");
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                                                           _topic.TopicText

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _topic.TopicText = __value, _topic.TopicText))));
                __builder2.AddAttribute(76, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _topic.TopicText));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n\r\n            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "mt-2");
                __builder2.AddMarkupContent(81, "\r\n                ");
                __builder2.AddMarkupContent(82, "<button class=\"btn btn-blazorforum mr-2\" type=\"submit\">Update</button>\r\n                ");
                __builder2.OpenElement(83, "a");
                __builder2.AddAttribute(84, "class", "btn btn-blazorforum");
                __builder2.AddAttribute(85, "href", 
#nullable restore
#line 52 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
                          String.Format("/admin/forums/{0}/categories/{1}/topics/{2}", 
                          forumId, categoryId, topicId)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(86, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 57 "C:\Users\remio\OneDrive\Documents\GitHub\BlazorBlog\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopicEdit.razor"
}

#line default
#line hidden
#nullable disable
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
namespace __Blazor.BlazorForum.Areas.Admin.Pages.Components.Forums.ForumTopicEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
