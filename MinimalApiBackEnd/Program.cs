var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    // Copilot suggested the use of a CORS policy named "AllowAll" to allow any origin, method, and header.
    // This ensures the API can be accessed from any client, improving development efficiency.
    options.AddPolicy("AllowAll", builder => builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // Copilot included this middleware to enforce HTTPS, enhancing security.
app.UseCors("AllowAll"); // Copilot ensured the CORS policy is applied to the app.

// Your endpoints
app.MapGet("/api/productlist", () =>
{
    // Copilot generated this endpoint to return a JSON response with a sample product list.
    // This saved time by providing a ready-to-use structure for the API response.
    return Results.Json(new[]
    {
        new
        {
            Id = 1,
            Name = "Laptop",
            Price = 1200.50,
            Stock = 25,
            Category = new
            {
                Id = 101,
                Name = "Electronics"
            }
        },
        new
        {
            Id = 2,
            Name = "Headphones",
            Price = 50.00,
            Stock = 100,
            Category = new
            {
                Id = 102,
                Name = "Accessories"
            }
        }
    });
    // Copilot's suggestion of using an anonymous object array for the response improved development speed.
});

app.Run(); // Copilot ensured the application is properly started.