#pragma checksum "C:\GodswillEduRecord\client\Pages\EditStudySession.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99202fcc022f00fc10995045847f02dffc0d4537"
// <auto-generated/>
#pragma warning disable 1591
namespace GodswillEduRecord.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\GodswillEduRecord\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GodswillEduRecord\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GodswillEduRecord\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GodswillEduRecord\client\_Imports.razor"
using GodswillEduRecord.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GodswillEduRecord\client\_Imports.razor"
using GodswillEduRecord.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
using GodswillEduRecord.Models.ConData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-study-session/{StudySessionID}")]
    public partial class EditStudySession : GodswillEduRecord.Pages.EditStudySessionComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
                __builder2.AddAttribute(8, "style", "font-weight: bold");
                __builder2.AddAttribute(9, "Text", "Item no longer available.");
                __builder2.AddAttribute(10, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                           !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\n      ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 16 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(17, "Text", "Close");
                __builder2.AddAttribute(18, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                              !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                                                 CloseButtonClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(25);
                __builder2.AddAttribute(26, "style", "font-weight: bold");
                __builder2.AddAttribute(27, "Text", "Another user has made conflicting changes to one or more of the fields you have modified. Please reload.");
                __builder2.AddAttribute(28, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                                                                                         hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n      ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(32);
                __builder2.AddAttribute(33, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Icon", "autorenew");
                __builder2.AddAttribute(35, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(36, "Text", "Reload");
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                                               hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                                                                   Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<GodswillEduRecord.Models.ConData.StudySession>>(44);
                __builder2.AddAttribute(45, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GodswillEduRecord.Models.ConData.StudySession>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                         studysession

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                                  studysession != null && canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GodswillEduRecord.Models.ConData.StudySession>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GodswillEduRecord.Models.ConData.StudySession>(this, 
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                                                                             Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(51, "class", "row");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Text", "Study Session Name");
                    __builder3.AddAttribute(56, "Component", "StudySessionName");
                    __builder3.AddAttribute(57, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(61);
                    __builder3.AddAttribute(62, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 40 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                          50

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(64, "Name", "StudySessionName");
                    __builder3.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                 studysession.StudySessionName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studysession.StudySessionName = __value, studysession.StudySessionName))));
                    __builder3.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => studysession.StudySessionName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(69);
                    __builder3.AddAttribute(70, "Component", "StudySessionName");
                    __builder3.AddAttribute(71, "Text", "StudySessionName is required");
                    __builder3.AddAttribute(72, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(76, "class", "row");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(79);
                    __builder3.AddAttribute(80, "Text", "Time");
                    __builder3.AddAttribute(81, "Component", "Time");
                    __builder3.AddAttribute(82, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\n              ");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(86);
                    __builder3.AddAttribute(87, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 52 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                          50

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(89, "Name", "Time");
                    __builder3.AddAttribute(90, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                 studysession.Time

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studysession.Time = __value, studysession.Time))));
                    __builder3.AddAttribute(92, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => studysession.Time));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(94);
                    __builder3.AddAttribute(95, "Component", "Time");
                    __builder3.AddAttribute(96, "Text", "Time is required");
                    __builder3.AddAttribute(97, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\n            ");
                    __builder3.OpenElement(99, "div");
                    __builder3.AddAttribute(100, "class", "row");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(103);
                    __builder3.AddAttribute(104, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 60 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(105, "Icon", "save");
                    __builder3.AddAttribute(106, "Text", "Save");
                    __builder3.AddAttribute(107, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 60 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(109);
                    __builder3.AddAttribute(110, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 62 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(111, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(112, "Text", "Cancel");
                    __builder3.AddAttribute(113, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\GodswillEduRecord\client\Pages\EditStudySession.razor"
                                                                                                              Button4Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
