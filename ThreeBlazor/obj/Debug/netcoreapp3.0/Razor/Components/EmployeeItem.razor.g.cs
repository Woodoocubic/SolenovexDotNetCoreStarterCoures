#pragma checksum "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\EmployeeItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c7c0cd75c7f213986933d594bf3a00c722c257"
// <auto-generated/>
#pragma warning disable 1591
namespace ThreeBlazor.Components
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
#line 1 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\EmployeeItem.razor"
using gRPCApi;

#line default
#line hidden
#nullable disable
    public partial class EmployeeItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "td");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\EmployeeItem.razor"
         Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 6 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\EmployeeItem.razor"
         Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\EmployeeItem.razor"
         Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 8 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\EmployeeItem.razor"
          Employee.Fired ? "Yes":""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 10 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\EmployeeItem.razor"
         if (!Employee.Fired)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "javascript:void(0) ");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\EmployeeItem.razor"
                                                    HandleFire

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "\r\n                Fire\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 15 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\EmployeeItem.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\EmployeeItem.razor"
 
    [Parameter]
    public Employee Employee { get; set; }

    private async void HandleFire()
    {
        await employeeService.Fire(Employee.Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591
