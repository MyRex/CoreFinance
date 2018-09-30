using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using ZFine.Code;

namespace ZFine.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddMemoryCache();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //注意：一定要加 sslmode=none 
            var connectString = Configuration.GetConnectionString("MysqlConnection"); services.AddDbContext<Domain.Entity.ZFineDbContext>(options =>

            {
                options.UseMySql(connectString);
                options.UseLoggerFactory(
new LoggerFactory().AddConsole()); //加入该句会把EF Core执行过程中的Sql语句在控制台输出
            });
            //var connection = Configuration.GetConnectionString("MysqlConnection");
            //services.AddDbContext<Domain.Entity.ZFineDbContext>(options => options.UseMySql(connection, b => b.MigrationsAssembly("ZFine.Web")));
            //services.Add(new ServiceDescriptor(typeof(Domain.Entity.ZFineDbContext), new Domain.Entity.ZFineDbContext(Configuration.GetConnectionString("DefaultConnection"))));
            services.AddSession();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseStaticHttpContext();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "area",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id}",
                    defaults: new { controller = "Login", action = "Index", id = "" });

            });
        }
    }
}
