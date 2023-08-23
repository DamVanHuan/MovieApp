using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MovieApp.Applications.Bahaviors;
using MovieApp.Data;
using MovieApp.DTOs.Commons;
using System.Reflection;
using System.Text;

namespace MovieApp.Extensions
{
    public static class ServiceExtension
    {
        public static void AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var cnnString = configuration.GetConnectionString("movie_app");
            services.AddDbContext<MovieContext>(options =>
            {
                options.UseNpgsql(
                    cnnString,
                    options =>
                    {
                        options.MigrationsAssembly(typeof(MovieContext).Assembly.ToString());
                        options.EnableRetryOnFailure(3, TimeSpan.FromSeconds(30), null);
                    });
            });
        }

        public static void ConfigureAuth(this IServiceCollection services, IConfiguration config)
        {
            var jwt = config.GetSection("JWT").Get<JWT>();
            services.AddSingleton(jwt);

            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidAudience = jwt.ValidAudience,
                        ValidIssuer = jwt.ValidIssuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Secret))
                    };
                });
        }

        public static void ConfigureFluentValidation(this IServiceCollection services, Assembly assembly)
        {
            services.AddValidatorsFromAssembly(assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorBehavior<,>));
        }

        public static void ConfigureCors(this IServiceCollection services, IConfiguration configuration)
        {
            var corsOrigin = configuration["CorsOrigin"];

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    if (corsOrigin == "*")
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    }
                    else
                    {
                        var origins = corsOrigin.Split(";");
                        builder.SetIsOriginAllowedToAllowWildcardSubdomains();
                        builder.WithOrigins(origins).AllowAnyHeader();
                        builder.WithOrigins(origins).AllowAnyMethod();
                    }
                });
            });
        }
    }
}
