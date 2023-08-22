using Core.DependencyResolvers;
using Core.Utilities.IoC;
using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Core.Extensions;
using Autofac.Core;
using System;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            ///////Scaffold///////

            //bir þeyler ekledim ama ne ne için bilmiyorum bir sýkýntý çýkarsa silersin gülüm
            //services.AddDbContext<CrmContext>(options =>options.UseSqlServer("Server=DESKTOP-UGD7FQ4\\SQLEXPRESS;Database=CustomerRelationshipManagement;Trusted_Connection=True;"));

            //***
            //services.AddDbContext<ContactAPIDbContext>(options =>options.UseSqlServer("Server=DESKTOP-UGD7FQ4\\SQLEXPRESS;Database=CustomerRelationshipManagement;Trusted_Connection=True;"));
            //services.AddMvc();
            //services.Configure<MvcOptions>(options => options.EnableEndpointRouting = false);
            //***

            //services.AddDbContext<ProductsAPIDbContext>(options => options.UseInMemoryDatabase("ProductsDb"));

            //services.AddDbContext<CrmContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString")));
            //services.AddMvc();
            ///////Scaffold///////

            //Automapper
            //services.AddAutoMapper(typeof(Startup));
            //services.AddAutoMapper();
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //services.AddAutoMapper(typeof(MappingProfile));
            //
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //apimize bizim dýþýmýzdan bir veri gelirse onun için izin veriyoruz
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                //bilmem ne localhosttan gelen verileri kabul ettiðimizi yazdýk
                builder => builder.WithOrigins("http://localhost:3000"));
            });

            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });

            services.AddDependencyResolvers(new ICoreModule[] {
               new CoreModule()
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            ///////Scaffold///////
            ///*
            //app.UseMvc(options => options.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}"));
            //***
            ///////Scaffold///////


            //app.ConfigureCustomExceptionMiddleware();

            //bilmem ne localhost tan gelen verilere cevap ver demek
            app.UseCors(builder => builder.WithOrigins("http://localhost:3000").AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication(); //eve girmek için anahtar

            app.UseAuthorization(); // annemle ayný evde yaþýyorum ama o benim odama girmez

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
