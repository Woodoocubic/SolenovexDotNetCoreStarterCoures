#pragma checksum "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddDepartment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beec0c831ac86253136868e55d44c62ba0a1d62c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddDepartment.razor"
using gRPCApi;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-department")]
    public partial class AddDepartment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Greg\source\repos\TeacherYangStartersCourse\ThreeBlazor\Pages\AddDepartment.razor"
 
    private readonly Department department = new Department();

    private async Task HandleValidSubmit()
    {
        await departmentService.Add(department);
        navigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDepartmentService departmentService { get; set; }
    }
}
#pragma warning restore 1591
