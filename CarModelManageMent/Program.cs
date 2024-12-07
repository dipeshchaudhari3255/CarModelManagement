using CarModelManageMent.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Configure the database context
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container
builder.Services.AddControllers(); // Add support for controllers
builder.Services.AddSwaggerGen(); // Add Swagger
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Use Swagger middleware only in development or when debugging

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Show detailed error pages in development
    app.UseSwagger(); // Enable Swagger
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarModelManagement API"));
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers(); // Enable attribute-based routing
});

app.Run();
