#pragma checksum "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8b6cc4aa29703d9cc644eaa0dfa6a81f22790d4"
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
#line 5 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
using GodswillEduRecord.Models.ConData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-student-education-history")]
    public partial class AddStudentEducationHistory : GodswillEduRecord.Pages.AddStudentEducationHistoryComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<GodswillEduRecord.Models.ConData.StudentEducationHistory>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GodswillEduRecord.Models.ConData.StudentEducationHistory>(
#nullable restore
#line 12 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                   studenteducationhistory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                                                       studenteducationhistory != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GodswillEduRecord.Models.ConData.StudentEducationHistory>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GodswillEduRecord.Models.ConData.StudentEducationHistory>(this, 
#nullable restore
#line 12 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
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
                    __Blazor.GodswillEduRecord.Client.Pages.AddStudentEducationHistory.TypeInference.CreateRadzenDropDown_0(__builder3, 24, 25, 
#nullable restore
#line 20 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                       getStudentBiodataResult

#line default
#line hidden
#nullable disable
                    , 26, "Surname", 27, "BiodataID", 28, "Choose StudentBiodatum", 29, "display: block; width: 100%", 30, "BiodataID", 31, 
#nullable restore
#line 20 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                                                                                                                                                                                         studenteducationhistory.BiodataID

#line default
#line hidden
#nullable disable
                    , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studenteducationhistory.BiodataID = __value, studenteducationhistory.BiodataID)), 33, () => studenteducationhistory.BiodataID);
                    __builder3.AddMarkupContent(34, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(35);
                    __builder3.AddAttribute(36, "Component", "BiodataID");
                    __builder3.AddAttribute(37, "Text", "BiodataID is required");
                    __builder3.AddAttribute(38, "style", "position: absolute");
                    __builder3.AddAttribute(39, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
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
                    __builder3.AddAttribute(47, "Text", "Name Of Institution");
                    __builder3.AddAttribute(48, "Component", "NameOfInstitution");
                    __builder3.AddAttribute(49, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\n              ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(53);
                    __builder3.AddAttribute(54, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                          350

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(56, "Name", "NameOfInstitution");
                    __builder3.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                                                                                  studenteducationhistory.NameOfInstitution

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studenteducationhistory.NameOfInstitution = __value, studenteducationhistory.NameOfInstitution))));
                    __builder3.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => studenteducationhistory.NameOfInstitution));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(61);
                    __builder3.AddAttribute(62, "Component", "NameOfInstitution");
                    __builder3.AddAttribute(63, "Text", "NameOfInstitution is required");
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
                    __builder3.AddAttribute(72, "Text", "Start Date");
                    __builder3.AddAttribute(73, "Component", "StartDate");
                    __builder3.AddAttribute(74, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.AddStudentEducationHistory.TypeInference.CreateRadzenDatePicker_1(__builder3, 78, 79, "dd/MM/yyyy", 80, "display: block; width: 100%", 81, "StartDate", 82, 
#nullable restore
#line 44 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                                                                                             studenteducationhistory.StartDate

#line default
#line hidden
#nullable disable
                    , 83, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studenteducationhistory.StartDate = __value, studenteducationhistory.StartDate)), 84, () => studenteducationhistory.StartDate);
                    __builder3.AddMarkupContent(85, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(86);
                    __builder3.AddAttribute(87, "Component", "StartDate");
                    __builder3.AddAttribute(88, "Text", "StartDate is required");
                    __builder3.AddAttribute(89, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\n            ");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(93, "class", "row");
                    __builder3.OpenElement(94, "div");
                    __builder3.AddAttribute(95, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(96);
                    __builder3.AddAttribute(97, "Text", "End Date");
                    __builder3.AddAttribute(98, "Component", "EndDate");
                    __builder3.AddAttribute(99, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\n              ");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.AddStudentEducationHistory.TypeInference.CreateRadzenDatePicker_2(__builder3, 103, 104, "dd/MM/yyyy", 105, "width: 100%", 106, "EndDate", 107, 
#nullable restore
#line 56 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                                                                             studenteducationhistory.EndDate

#line default
#line hidden
#nullable disable
                    , 108, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studenteducationhistory.EndDate = __value, studenteducationhistory.EndDate)), 109, () => studenteducationhistory.EndDate);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(110, "\n            ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(113, "class", "row");
                    __builder3.OpenElement(114, "div");
                    __builder3.AddAttribute(115, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(116);
                    __builder3.AddAttribute(117, "Text", "Qualification");
                    __builder3.AddAttribute(118, "Component", "QualificationObtainedID");
                    __builder3.AddAttribute(119, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\n              ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.AddStudentEducationHistory.TypeInference.CreateRadzenDropDown_3(__builder3, 123, 124, 
#nullable restore
#line 66 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                       getQualificationsResult

#line default
#line hidden
#nullable disable
                    , 125, "QualificationName", 126, "QualificationID", 127, "Choose Qualification", 128, "display: block; width: 100%", 129, "QualificationObtainedID", 130, 
#nullable restore
#line 66 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                                                                                                                                                                                                       studenteducationhistory.QualificationObtainedID

#line default
#line hidden
#nullable disable
                    , 131, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studenteducationhistory.QualificationObtainedID = __value, studenteducationhistory.QualificationObtainedID)), 132, () => studenteducationhistory.QualificationObtainedID);
                    __builder3.AddMarkupContent(133, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(134);
                    __builder3.AddAttribute(135, "Component", "QualificationObtainedID");
                    __builder3.AddAttribute(136, "Text", "QualificationObtainedID is required");
                    __builder3.AddAttribute(137, "style", "position: absolute");
                    __builder3.AddAttribute(138, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 68 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                                                                                                                                                 0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(139, "\n            ");
                    __builder3.OpenElement(140, "div");
                    __builder3.AddAttribute(141, "class", "row");
                    __builder3.OpenElement(142, "div");
                    __builder3.AddAttribute(143, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(144);
                    __builder3.AddAttribute(145, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 74 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(146, "Icon", "save");
                    __builder3.AddAttribute(147, "Text", "Save");
                    __builder3.AddAttribute(148, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 74 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(149, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(150);
                    __builder3.AddAttribute(151, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 76 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(152, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(153, "Text", "Cancel");
                    __builder3.AddAttribute(154, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\GodswillEduRecord\client\Pages\AddStudentEducationHistory.razor"
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
namespace __Blazor.GodswillEduRecord.Client.Pages.AddStudentEducationHistory
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
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
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
