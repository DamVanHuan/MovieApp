using Microsoft.AspNetCore.Diagnostics;
using MovieApp.DTOs.Commons;
using MovieApp.DTOs.Exceptions;
using MovieApp.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net;
using System.Net.Mime;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var currentAssembly = Assembly.GetExecutingAssembly();

// Add services to the container.
JsonConvert.DefaultSettings = () => new JsonSerializerSettings
{
    NullValueHandling = NullValueHandling.Ignore,
    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
    ContractResolver = new DefaultContractResolver()
    {
        NamingStrategy = new CamelCaseNamingStrategy()
    }
};
builder.Services.AddControllers();
builder.Services.ConfigureCors(builder.Configuration);
builder.Services.ConfigureAuth(builder.Configuration);
builder.Services.AddCustomDbContext(builder.Configuration);
builder.Services.AddAutoMapper(currentAssembly);
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(currentAssembly));
builder.Services.ConfigureFluentValidation(currentAssembly);


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseExceptionHandler(new ExceptionHandlerOptions
{
    AllowStatusCode404Response = true,
    ExceptionHandler = async context =>
    {
        context.Response.ContentType = MediaTypeNames.Application.Json;

        var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
        var exception = exceptionHandlerPathFeature?.Error;
        if (exception is ExceptionBase ex)
        {
            context.Response.StatusCode = ex.StatusCode;
            await context.Response.WriteAsync(ex.ToString()).ConfigureAwait(false);
        }
        else
        {
            context.Response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
            var error = new ResponseBase("InternalServerError", "An error has occur, please try again");

            var resp = JsonConvert.SerializeObject(new { code = error.Code, message = error.Message });
            await context.Response.WriteAsync(resp).ConfigureAwait(false);
        }
    }
});

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapGet("/", async context =>
{
    await context.Response.WriteAsJsonAsync(new { State = "Api running ...", Time = DateTime.Now });
});

app.Run();
