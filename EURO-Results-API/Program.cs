var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    options =>
    {
        options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
        {
            Title = "Football Data API",
            Version = "v1",
            Description = "API for fetching football data including standings and matches.",
            Contact = new Microsoft.OpenApi.Models.OpenApiContact
            {
                Name = "EURO Results API",
                Email = "ziadhani64@gmail.com",
                Url = new Uri("https://github.com/ziadhanii/euro-2024-results-using-blazor-web-assembly")
            }
        });
    });

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI(
    options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Football Data API V1");
        options.RoutePrefix = string.Empty;
    });


app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();