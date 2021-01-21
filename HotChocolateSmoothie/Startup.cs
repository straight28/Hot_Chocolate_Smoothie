using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.ApplicationCore.Interfaces;
using HotChocolateSmoothie.Hubs;
using IceSmoothie.Infrastructrue.Utilities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HotChocolateSmoothie
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //������ ������ ���� �� ���ΰ�ħ�ϸ� �ݿ���
            //Nuget�� ���� Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation ��ġ �� AddRazorRuntimeCompilation() �߰�
            //services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddRazorPages();
            services.AddSignalR();


            ///��Ű�� �̿��� Authentication
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
            //{
            //    ///����� ��Ű �߰� 
            //    ///5�еڸ� expire
            //    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
            //    options.LoginPath = "/Account/LogIn";
            //    options.LogoutPath = "/Account/Logout";
            //    options.AccessDeniedPath = "/Account/LogIn";
            //})
            //.AddCookie(Constants.AdminAuthenticationScheme, options=> 
            //{
            //    ///������ ��Ű �߰�
            //    ///1�ð� �ڸ� expire
            //    options.ExpireTimeSpan = TimeSpan.FromHours(1);
            //    options.LoginPath = "/Admin/SignIn";
            //    options.LogoutPath = "/Admin/Signout";
            //    options.AccessDeniedPath = "/Admin/SignIn";
            //});

            //services.AddTransient<EmailSender>();
            //services.AddTransient<IEmailSmsText, EmailSmsText>();

            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<ChatHub>("/chathub");

            });
        }
    }
}
