#pragma checksum "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "887ebb79e9cb846752027b8c2063d0828984b26f"
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
#line 1 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
using gRPCApi;

#line default
#line hidden
#nullable disable
    public partial class DepartmentItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "td");
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
         Department.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 4 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
         Department.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 5 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
     if (Department.EmployeeCount > 50)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "        ");
            __builder.OpenElement(9, "td");
            __builder.OpenElement(10, "strong");
            __builder.AddContent(11, 
#nullable restore
#line 7 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
                     Department.EmployeeCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 8 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 11 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
             Department.EmployeeCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 12 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 13 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
         Department.EmployeeCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "td");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/employee/" + (
#nullable restore
#line 15 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
                            Department.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Employees");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Components\DepartmentItem.razor"
 
    [Parameter]
    public Department Department { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591