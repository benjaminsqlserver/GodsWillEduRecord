#pragma checksum "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ef12a7e4ba1298748cc6e99c10541390ba6ec4"
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
#line 5 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
using GodswillEduRecord.Models.ConData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-next-of-kin")]
    public partial class AddNextOfKin : GodswillEduRecord.Pages.AddNextOfKinComponent
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
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<GodswillEduRecord.Models.ConData.NextOfKin>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GodswillEduRecord.Models.ConData.NextOfKin>(
#nullable restore
#line 12 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                   nextofkin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                         nextofkin != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GodswillEduRecord.Models.ConData.NextOfKin>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GodswillEduRecord.Models.ConData.NextOfKin>(this, 
#nullable restore
#line 12 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                                                                         Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", "Student Biodatum");
                    __builder3.AddAttribute(19, "Component", "BiodataID");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.AddNextOfKin.TypeInference.CreateRadzenDropDown_0(__builder3, 24, 25, 
#nullable restore
#line 20 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                       getStudentBiodataResult

#line default
#line hidden
#nullable disable
                    , 26, "Surname", 27, "BiodataID", 28, "Choose StudentBiodatum", 29, "display: block; width: 100%", 30, "BiodataID", 31, 
#nullable restore
#line 20 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                                                                                                                                         nextofkin.BiodataID

#line default
#line hidden
#nullable disable
                    , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nextofkin.BiodataID = __value, nextofkin.BiodataID)), 33, () => nextofkin.BiodataID);
                    __builder3.AddMarkupContent(34, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(35);
                    __builder3.AddAttribute(36, "Component", "BiodataID");
                    __builder3.AddAttribute(37, "Text", "BiodataID is required");
                    __builder3.AddAttribute(38, "style", "position: absolute");
                    __builder3.AddAttribute(39, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                                                                     0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\n            ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(43, "class", "row");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(46);
                    __builder3.AddAttribute(47, "Text", "Name Of Next Of Kin");
                    __builder3.AddAttribute(48, "Component", "NameOfNextOfKin");
                    __builder3.AddAttribute(49, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\n              ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(53);
                    __builder3.AddAttribute(54, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                          250

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(56, "Name", "NameOfNextOfKin");
                    __builder3.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                                  nextofkin.NameOfNextOfKin

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nextofkin.NameOfNextOfKin = __value, nextofkin.NameOfNextOfKin))));
                    __builder3.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nextofkin.NameOfNextOfKin));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(61);
                    __builder3.AddAttribute(62, "Component", "NameOfNextOfKin");
                    __builder3.AddAttribute(63, "Text", "NameOfNextOfKin is required");
                    __builder3.AddAttribute(64, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(68, "class", "row");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(71);
                    __builder3.AddAttribute(72, "Text", "Relationship");
                    __builder3.AddAttribute(73, "Component", "RelationshipID");
                    __builder3.AddAttribute(74, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.AddNextOfKin.TypeInference.CreateRadzenDropDown_1(__builder3, 78, 79, 
#nullable restore
#line 44 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                       getRelationshipsResult

#line default
#line hidden
#nullable disable
                    , 80, "RelationshipName", 81, "RelationshipID", 82, "Choose Relationship", 83, "display: block; width: 100%", 84, "RelationshipID", 85, 
#nullable restore
#line 44 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                                                                                                                                                   nextofkin.RelationshipID

#line default
#line hidden
#nullable disable
                    , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nextofkin.RelationshipID = __value, nextofkin.RelationshipID)), 87, () => nextofkin.RelationshipID);
                    __builder3.AddMarkupContent(88, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(89);
                    __builder3.AddAttribute(90, "Component", "RelationshipID");
                    __builder3.AddAttribute(91, "Text", "RelationshipID is required");
                    __builder3.AddAttribute(92, "style", "position: absolute");
                    __builder3.AddAttribute(93, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 46 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                                                                               0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\n            ");
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(97, "class", "row");
                    __builder3.OpenElement(98, "div");
                    __builder3.AddAttribute(99, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(100);
                    __builder3.AddAttribute(101, "Text", "Next Of Kin Phone No");
                    __builder3.AddAttribute(102, "Component", "NextOfKinPhoneNo");
                    __builder3.AddAttribute(103, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\n              ");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(107);
                    __builder3.AddAttribute(108, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 56 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                          50

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(109, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(110, "Name", "NextOfKinPhoneNo");
                    __builder3.AddAttribute(111, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                                 nextofkin.NextOfKinPhoneNo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(112, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nextofkin.NextOfKinPhoneNo = __value, nextofkin.NextOfKinPhoneNo))));
                    __builder3.AddAttribute(113, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nextofkin.NextOfKinPhoneNo));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(115);
                    __builder3.AddAttribute(116, "Component", "NextOfKinPhoneNo");
                    __builder3.AddAttribute(117, "Text", "NextOfKinPhoneNo is required");
                    __builder3.AddAttribute(118, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n            ");
                    __builder3.OpenElement(120, "div");
                    __builder3.AddAttribute(121, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(122, "class", "row");
                    __builder3.OpenElement(123, "div");
                    __builder3.AddAttribute(124, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(125);
                    __builder3.AddAttribute(126, "Text", "Next Of Kin Email");
                    __builder3.AddAttribute(127, "Component", "NextOfKinEmail");
                    __builder3.AddAttribute(128, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(129, "\n              ");
                    __builder3.OpenElement(130, "div");
                    __builder3.AddAttribute(131, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(132);
                    __builder3.AddAttribute(133, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 68 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                          50

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(134, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(135, "Name", "NextOfKinEmail");
                    __builder3.AddAttribute(136, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                                 nextofkin.NextOfKinEmail

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(137, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nextofkin.NextOfKinEmail = __value, nextofkin.NextOfKinEmail))));
                    __builder3.AddAttribute(138, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nextofkin.NextOfKinEmail));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(139, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(140);
                    __builder3.AddAttribute(141, "Component", "NextOfKinEmail");
                    __builder3.AddAttribute(142, "Text", "NextOfKinEmail is required");
                    __builder3.AddAttribute(143, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(144, "\n            ");
                    __builder3.OpenElement(145, "div");
                    __builder3.AddAttribute(146, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(147, "class", "row");
                    __builder3.OpenElement(148, "div");
                    __builder3.AddAttribute(149, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(150);
                    __builder3.AddAttribute(151, "Text", "Next Of Kin Contact Address");
                    __builder3.AddAttribute(152, "Component", "NextOfKinContactAddress");
                    __builder3.AddAttribute(153, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(154, "\n              ");
                    __builder3.OpenElement(155, "div");
                    __builder3.AddAttribute(156, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(157);
                    __builder3.AddAttribute(158, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(159, "Name", "NextOfKinContactAddress");
                    __builder3.AddAttribute(160, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                  nextofkin.NextOfKinContactAddress

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(161, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nextofkin.NextOfKinContactAddress = __value, nextofkin.NextOfKinContactAddress))));
                    __builder3.AddAttribute(162, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nextofkin.NextOfKinContactAddress));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(163, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(164);
                    __builder3.AddAttribute(165, "Component", "NextOfKinContactAddress");
                    __builder3.AddAttribute(166, "Text", "NextOfKinContactAddress is required");
                    __builder3.AddAttribute(167, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(168, "\n            ");
                    __builder3.OpenElement(169, "div");
                    __builder3.AddAttribute(170, "class", "row");
                    __builder3.OpenElement(171, "div");
                    __builder3.AddAttribute(172, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(173);
                    __builder3.AddAttribute(174, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 88 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(175, "Icon", "save");
                    __builder3.AddAttribute(176, "Text", "Save");
                    __builder3.AddAttribute(177, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 88 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(178, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(179);
                    __builder3.AddAttribute(180, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 90 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(181, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(182, "Text", "Cancel");
                    __builder3.AddAttribute(183, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\GodswillEduRecord\client\Pages\AddNextOfKin.razor"
                                                                                                              Button2Click

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
namespace __Blazor.GodswillEduRecord.Client.Pages.AddNextOfKin
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
