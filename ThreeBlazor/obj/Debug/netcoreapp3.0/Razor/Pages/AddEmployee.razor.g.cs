#pragma checksum "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a731fa6a665dd2c4a8b5018d9a607af9164b1adf"
// <auto-generated/>
#pragma warning disable 1591
namespace ThreeBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\_Imports.razor"
using ThreeBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\_Imports.razor"
using ThreeBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\_Imports.razor"
using ThreeBlazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor"
using gRPCApi;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-employee/{DepartmentId}")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor"
                  employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor"
                                            HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row form-group");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<div class=\"offset-md-2 col-md-2\">\r\n            <label for=\"firstName\">First Name</label>\r\n        </div>\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-md-2");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "firstName");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor"
                                    employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employee.FirstName = __value, employee.FirstName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => employee.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "row form-group");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<div class=\"col-md-2 offset-md-2\">\r\n            <label for=\"lastName\">Last Name</label>\r\n        </div>\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-md-2");
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "id", "lastName");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor"
                                    employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employee.LastName = __value, employee.LastName))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => employee.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "row form-group");
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.AddMarkupContent(44, "<div class=\"col-md-2 offset-md-2\">\r\n            <label for=\"gender\">Gender</label>\r\n        </div>\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "col-md-2");
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "select");
                __builder2.AddAttribute(49, "id", "gender");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "onchange", "OnGenderSelected");
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.OpenElement(53, "option");
                __builder2.AddAttribute(54, "selected", true);
                __builder2.AddAttribute(55, "hidden", true);
                __builder2.AddAttribute(56, "disabled", true);
                __builder2.AddContent(57, "-----Please Select Gender-----");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n");
#nullable restore
#line 35 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor"
                 foreach (var item in Enum.GetValues(typeof(Gender)).Cast<Gender>())
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(59, "                    ");
                __builder2.OpenElement(60, "option");
                __builder2.AddAttribute(61, "value", 
#nullable restore
#line 37 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor"
                                    item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(62, 
#nullable restore
#line 37 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor"
                                           item.ToString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n");
#nullable restore
#line 38 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(64, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.AddMarkupContent(68, "<div class=\"row\">\r\n        <div class=\"col-md-2 offset-md-2\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">submit</button>\r\n        </div>\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddEmployee.razor"
 
    [Parameter]
    public string DepartmentId { get; set; }

    private gRPCApi.Employee employee = new gRPCApi.Employee();

    private void OnGenderSelected(ChangeEventArgs e)
    {
        var gender = Enum.Parse(typeof(Gender), (string) e.Value);
        employee.Gender = (Gender) gender;
    }

    private async Task HandleValidSubmit()
    {
        employee.DepartmentId = int.Parse(DepartmentId);
        await employeeService.Add(employee);
        navigationManager.NavigateTo($"/employee/{DepartmentId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591
