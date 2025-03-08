using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace R29_backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            AppContext.SetSwitch("System.Net.Security.RemoteCertificateValidationCallback", true);
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(
                    _options => _options.AddPolicy("PoliticasdeAcceso",
                                _builder => _builder.AllowAnyOrigin()
                                                    .AllowAnyMethod()
                                                    .AllowAnyHeader()
                                                    .AllowCredentials())
            );
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            string scretKey = "";
            scretKey = varGlobal.sql.ExecuteSqlQuery("crisgtk.SecretKey", null, varGlobal.DataBase).Rows[0][0].ToString();
            // configure jwt authentication

            var key = System.Text.Encoding.ASCII.GetBytes(scretKey);
            services.AddAuthentication(optionAuth =>
            {
                optionAuth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                optionAuth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(optionHeader =>
            {
                optionHeader.RequireHttpsMetadata = false;
                optionHeader.SaveToken = true;
                optionHeader.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
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
                varGlobal.Environment("prod");
                app.UseHttpsRedirection();
                app.UseHsts();
            }

            app.UseCors("PoliticasdeAcceso");
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
