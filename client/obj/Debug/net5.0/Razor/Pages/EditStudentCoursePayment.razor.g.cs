#pragma checksum "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0f091bc52ca48d2f060c95daf850cb657973406"
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
#line 5 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
using GodswillEduRecord.Models.ConData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-student-course-payment/{PaymentID}")]
    public partial class EditStudentCoursePayment : GodswillEduRecord.Pages.EditStudentCoursePaymentComponent
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
#line 12 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
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
#line 16 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(17, "Text", "Close");
                __builder2.AddAttribute(18, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                                              !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
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
#line 22 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
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
#line 26 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
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
#line 26 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                                                               hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<GodswillEduRecord.Models.ConData.StudentCoursePayment>>(44);
                __builder2.AddAttribute(45, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GodswillEduRecord.Models.ConData.StudentCoursePayment>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                                 studentcoursepayment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                                                                  studentcoursepayment != null && canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GodswillEduRecord.Models.ConData.StudentCoursePayment>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GodswillEduRecord.Models.ConData.StudentCoursePayment>(this, 
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
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
                    __builder3.AddAttribute(55, "Text", "Student Biodatum");
                    __builder3.AddAttribute(56, "Component", "BiodataID");
                    __builder3.AddAttribute(57, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.EditStudentCoursePayment.TypeInference.CreateRadzenDropDown_0(__builder3, 61, 62, 
#nullable restore
#line 40 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                       getStudentBiodataResult

#line default
#line hidden
#nullable disable
                    , 63, "Surname", 64, "BiodataID", 65, "Choose StudentBiodatum", 66, "display: block; width: 100%", 67, "BiodataID", 68, 
#nullable restore
#line 40 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                                                                                                                                         studentcoursepayment.BiodataID

#line default
#line hidden
#nullable disable
                    , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentcoursepayment.BiodataID = __value, studentcoursepayment.BiodataID)), 70, () => studentcoursepayment.BiodataID);
                    __builder3.AddMarkupContent(71, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(72);
                    __builder3.AddAttribute(73, "Component", "BiodataID");
                    __builder3.AddAttribute(74, "Text", "BiodataID is required");
                    __builder3.AddAttribute(75, "style", "position: absolute");
                    __builder3.AddAttribute(76, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 42 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                                                                     0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(80, "class", "row");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(83);
                    __builder3.AddAttribute(84, "Text", "School Course");
                    __builder3.AddAttribute(85, "Component", "CourseOfStudyID");
                    __builder3.AddAttribute(86, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\n              ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.EditStudentCoursePayment.TypeInference.CreateRadzenDropDown_1(__builder3, 90, 91, 
#nullable restore
#line 52 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                       getSchoolCoursesResult

#line default
#line hidden
#nullable disable
                    , 92, "CourseOfStudyName", 93, "CourseOfStudyID", 94, "Choose SchoolCourse", 95, "display: block; width: 100%", 96, "CourseOfStudyID", 97, 
#nullable restore
#line 52 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                                                                                                                                                     studentcoursepayment.CourseOfStudyID

#line default
#line hidden
#nullable disable
                    , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentcoursepayment.CourseOfStudyID = __value, studentcoursepayment.CourseOfStudyID)), 99, () => studentcoursepayment.CourseOfStudyID);
                    __builder3.AddMarkupContent(100, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(101);
                    __builder3.AddAttribute(102, "Component", "CourseOfStudyID");
                    __builder3.AddAttribute(103, "Text", "CourseOfStudyID is required");
                    __builder3.AddAttribute(104, "style", "position: absolute");
                    __builder3.AddAttribute(105, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 54 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                                                                                 0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(109, "class", "row");
                    __builder3.OpenElement(110, "div");
                    __builder3.AddAttribute(111, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(112);
                    __builder3.AddAttribute(113, "Text", "Payment Date");
                    __builder3.AddAttribute(114, "Component", "PaymentDate");
                    __builder3.AddAttribute(115, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(116, "\n              ");
                    __builder3.OpenElement(117, "div");
                    __builder3.AddAttribute(118, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.EditStudentCoursePayment.TypeInference.CreateRadzenDatePicker_2(__builder3, 119, 120, "dd/MM/yyyy", 121, "display: block; width: 100%", 122, "PaymentDate", 123, 
#nullable restore
#line 64 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                                             studentcoursepayment.PaymentDate

#line default
#line hidden
#nullable disable
                    , 124, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentcoursepayment.PaymentDate = __value, studentcoursepayment.PaymentDate)), 125, () => studentcoursepayment.PaymentDate);
                    __builder3.AddMarkupContent(126, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(127);
                    __builder3.AddAttribute(128, "Component", "PaymentDate");
                    __builder3.AddAttribute(129, "Text", "PaymentDate is required");
                    __builder3.AddAttribute(130, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(131, "\n            ");
                    __builder3.OpenElement(132, "div");
                    __builder3.AddAttribute(133, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(134, "class", "row");
                    __builder3.OpenElement(135, "div");
                    __builder3.AddAttribute(136, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(137);
                    __builder3.AddAttribute(138, "Text", "Course Fee");
                    __builder3.AddAttribute(139, "Component", "CourseFee");
                    __builder3.AddAttribute(140, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(141, "\n              ");
                    __builder3.OpenElement(142, "div");
                    __builder3.AddAttribute(143, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.EditStudentCoursePayment.TypeInference.CreateRadzenNumeric_3(__builder3, 144, 145, "display: block; width: 100%", 146, "CourseFee", 147, 
#nullable restore
#line 76 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                  studentcoursepayment.CourseFee

#line default
#line hidden
#nullable disable
                    , 148, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentcoursepayment.CourseFee = __value, studentcoursepayment.CourseFee)), 149, () => studentcoursepayment.CourseFee);
                    __builder3.AddMarkupContent(150, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(151);
                    __builder3.AddAttribute(152, "Component", "CourseFee");
                    __builder3.AddAttribute(153, "Text", "CourseFee is required");
                    __builder3.AddAttribute(154, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(155, "\n            ");
                    __builder3.OpenElement(156, "div");
                    __builder3.AddAttribute(157, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(158, "class", "row");
                    __builder3.OpenElement(159, "div");
                    __builder3.AddAttribute(160, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(161);
                    __builder3.AddAttribute(162, "Text", "Amount Paid");
                    __builder3.AddAttribute(163, "Component", "AmountPaid");
                    __builder3.AddAttribute(164, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(165, "\n              ");
                    __builder3.OpenElement(166, "div");
                    __builder3.AddAttribute(167, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.EditStudentCoursePayment.TypeInference.CreateRadzenNumeric_4(__builder3, 168, 169, "display: block; width: 100%", 170, "AmountPaid", 171, 
#nullable restore
#line 88 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                  studentcoursepayment.AmountPaid

#line default
#line hidden
#nullable disable
                    , 172, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentcoursepayment.AmountPaid = __value, studentcoursepayment.AmountPaid)), 173, () => studentcoursepayment.AmountPaid);
                    __builder3.AddMarkupContent(174, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(175);
                    __builder3.AddAttribute(176, "Component", "AmountPaid");
                    __builder3.AddAttribute(177, "Text", "AmountPaid is required");
                    __builder3.AddAttribute(178, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(179, "\n            ");
                    __builder3.OpenElement(180, "div");
                    __builder3.AddAttribute(181, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(182, "class", "row");
                    __builder3.OpenElement(183, "div");
                    __builder3.AddAttribute(184, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(185);
                    __builder3.AddAttribute(186, "Text", "Balance");
                    __builder3.AddAttribute(187, "Component", "Balance");
                    __builder3.AddAttribute(188, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(189, "\n              ");
                    __builder3.OpenElement(190, "div");
                    __builder3.AddAttribute(191, "class", "col-md-9");
                    __Blazor.GodswillEduRecord.Client.Pages.EditStudentCoursePayment.TypeInference.CreateRadzenNumeric_5(__builder3, 192, 193, "display: block; width: 100%", 194, "Balance", 195, 
#nullable restore
#line 100 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                  studentcoursepayment.Balance

#line default
#line hidden
#nullable disable
                    , 196, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => studentcoursepayment.Balance = __value, studentcoursepayment.Balance)), 197, () => studentcoursepayment.Balance);
                    __builder3.AddMarkupContent(198, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(199);
                    __builder3.AddAttribute(200, "Component", "Balance");
                    __builder3.AddAttribute(201, "Text", "Balance is required");
                    __builder3.AddAttribute(202, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(203, "\n            ");
                    __builder3.OpenElement(204, "div");
                    __builder3.AddAttribute(205, "class", "row");
                    __builder3.OpenElement(206, "div");
                    __builder3.AddAttribute(207, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(208);
                    __builder3.AddAttribute(209, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 108 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(210, "Icon", "save");
                    __builder3.AddAttribute(211, "Text", "Save");
                    __builder3.AddAttribute(212, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 108 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(213, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(214);
                    __builder3.AddAttribute(215, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 110 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(216, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(217, "Text", "Cancel");
                    __builder3.AddAttribute(218, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\GodswillEduRecord\client\Pages\EditStudentCoursePayment.razor"
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
namespace __Blazor.GodswillEduRecord.Client.Pages.EditStudentCoursePayment
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
        public static void CreateRadzenNumeric_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
