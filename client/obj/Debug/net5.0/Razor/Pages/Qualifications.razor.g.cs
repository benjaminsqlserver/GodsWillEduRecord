#pragma checksum "C:\GodswillEduRecord\client\Pages\Qualifications.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0752ca7fbd733db92348d1dd650928145ea155ad"
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
#line 5 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
using GodswillEduRecord.Models.ConData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/qualifications")]
    public partial class Qualifications : GodswillEduRecord.Pages.QualificationsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Qualifications");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(11);
                __builder2.AddAttribute(12, "Icon", "add_circle_outline");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(14, "Text", "Add");
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(17);
                __builder2.AddAttribute(18, "Icon", "get_app");
                __builder2.AddAttribute(19, "style", "margin-left: 10px; margin-bottom: 10px");
                __builder2.AddAttribute(20, "Text", "Export");
                __builder2.AddAttribute(21, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#nullable restore
#line 16 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                               Splitbutton0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(23);
                    __builder3.AddAttribute(24, "Text", "Excel");
                    __builder3.AddAttribute(25, "Value", "xlsx");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(27);
                    __builder3.AddAttribute(28, "Text", "CSV");
                    __builder3.AddAttribute(29, "Value", "csv");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                __builder2.AddAttribute(32, "Placeholder", "Search ...");
                __builder2.AddAttribute(33, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(34, "Name", "Textbox0");
                __builder2.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await grid0.GoToPage(0);await grid0.Reload();}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGrid<GodswillEduRecord.Models.ConData.Qualification>>(37);
                __builder2.AddAttribute(38, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                       FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<GodswillEduRecord.Models.ConData.Qualification>>(
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                                                          getQualificationsResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                                                                                           getQualificationsCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                                                                                                                                                                                     Grid0LoadData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(45, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GodswillEduRecord.Models.ConData.Qualification>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GodswillEduRecord.Models.ConData.Qualification>(this, 
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                                                                                                                                                                                                                Grid0RowSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(46, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<GodswillEduRecord.Models.ConData.Qualification>>(47);
                    __builder3.AddAttribute(48, "Property", "QualificationID");
                    __builder3.AddAttribute(49, "Title", "Qualification ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<GodswillEduRecord.Models.ConData.Qualification>>(51);
                    __builder3.AddAttribute(52, "Property", "QualificationName");
                    __builder3.AddAttribute(53, "Title", "Qualification Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<GodswillEduRecord.Models.ConData.Qualification>>(55);
                    __builder3.AddAttribute(56, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                                      false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "Width", "70px");
                    __builder3.AddAttribute(59, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 32 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                                                                     TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "Template", (Microsoft.AspNetCore.Components.RenderFragment<GodswillEduRecord.Models.ConData.Qualification>)((godswillEduRecordModelsConDataQualification) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(61);
                        __builder4.AddAttribute(62, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 34 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(63, "Icon", "close");
                        __builder4.AddAttribute(64, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 34 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, godswillEduRecordModelsConDataQualification)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(66, "onclick", 
#nullable restore
#line 34 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                                                                                                                                                                                                                           true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(67, (__value) => {
#nullable restore
#line 26 "C:\GodswillEduRecord\client\Pages\Qualifications.razor"
                              grid0 = (Radzen.Blazor.RadzenDataGrid<GodswillEduRecord.Models.ConData.Qualification>)__value;

#line default
#line hidden
#nullable disable
                }
                );
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
