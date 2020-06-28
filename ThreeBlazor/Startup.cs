using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gRPCApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ThreeBlazor.Services;
using Employee = gRPCApi.Employee;

namespace ThreeBlazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddSingleton<IClock, UtcClock>();
            services.AddSingleton<IDepartmentService, DepartmentService>();
            services.AddSingleton<IEmployeeService, EmployeeService>();

            services.AddGrpcClient<Departments.DepartmentsClient>
                (o =>o.Address = new Uri("https://localhost:50000/"));
            services.AddGrpcClient<Employees.EmployeesClient>
                (o => o.Address = new Uri("https://localhost:50000/"));

            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencrytedSupport",true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
