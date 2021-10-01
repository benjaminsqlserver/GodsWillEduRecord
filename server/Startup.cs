using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

using GodswillEduRecord.Data;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Builder;
namespace GodswillEduRecord
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        partial void OnConfigureServices(IServiceCollection services);

        partial void OnConfiguringServices(IServiceCollection services);

        public void ConfigureServices(IServiceCollection services)
        {
            OnConfiguringServices(services);

            services.AddHttpContextAccessor();
            services.AddCors(options =>
            {
                options.AddPolicy(
                    "AllowAny",
                    x =>
                    {
                        x.AllowAnyHeader()
                        .AllowAnyMethod()
                        .SetIsOriginAllowed(isOriginAllowed: _ => true)
                        .AllowCredentials();
                    });
            });
            services.AddOData();
            services.AddODataQueryFilter();

            services.AddDbContext<GodswillEduRecord.Data.ConDataContext>(options =>
            {
              options.UseSqlServer(Configuration.GetConnectionString("ConDataConnection"));
            });

            services.AddRazorPages();
            OnConfigureServices(services);
        }

        partial void OnConfigure(IApplicationBuilder app, IWebHostEnvironment env);
        partial void OnConfigureOData(ODataConventionModelBuilder builder);
        partial void OnConfiguring(IApplicationBuilder app, IWebHostEnvironment env);

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            OnConfiguring(app, env);
            if (env.IsDevelopment())
            {
                Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.Use((ctx, next) =>
                {
                    return next();
                });
            }
            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();
            IServiceProvider provider = app.ApplicationServices.GetRequiredService<IServiceProvider>();
            app.UseCors("AllowAny");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
                endpoints.Count().Filter().OrderBy().Expand().Select().MaxTop(null).SetTimeZoneInfo(TimeZoneInfo.Utc);

                var oDataBuilder = new ODataConventionModelBuilder(provider);

                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.Gender>("Genders");
                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.NextOfKin>("NextOfKins");
                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.Qualification>("Qualifications");
                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.Relationship>("Relationships");
                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.SchoolCourse>("SchoolCourses");
                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.State>("States");
                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.StudentBiodatum>("StudentBiodata");
                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.StudentCoursePayment>("StudentCoursePayments");
                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.StudentCourseRegistration>("StudentCourseRegistrations");
                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.StudentEducationHistory>("StudentEducationHistories");
                oDataBuilder.EntitySet<GodswillEduRecord.Models.ConData.StudySession>("StudySessions");

                this.OnConfigureOData(oDataBuilder);

                var model = oDataBuilder.GetEdmModel();

                endpoints.MapODataRoute("odata", "odata/ConData", model);

            });

            OnConfigure(app, env);
        }
    }


}
