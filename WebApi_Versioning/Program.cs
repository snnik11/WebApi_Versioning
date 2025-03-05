using Asp.Versioning;
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var title = "Our versioned API";
    var description = "This is a web API demonstration";
    var terms = new Uri("https://localhost:/7294/terms");
    var license = new OpenApiLicense()
    {
        Name = "Full lincesseddd"
    };
    var contact = new OpenApiContact()
    {
        Name = "Nnn",
        Url = new Uri("https://google.com")
    };
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = $"{title} v1 (Deprecated)",
        Description = description
    });
    options.SwaggerDoc("v2", new OpenApiInfo
    {
        Version = "v2",
        Title = $"{title} v2",
        Description = description,
        TermsOfService  = terms
    });
});

var apiVersionBuilder = builder.Services.AddApiVersioning(opts =>
{
    opts.AssumeDefaultVersionWhenUnspecified = true;
    opts.DefaultApiVersion = new ApiVersion(2, 0);
    opts.ReportApiVersions = true;
   
}  );

apiVersionBuilder.AddApiExplorer(op =>
{
    op.GroupNameFormat = "'v'VVV";
    op.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json","v1");
        options.SwaggerEndpoint("/swagger/v2/swagger.json","v2");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
