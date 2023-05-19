
using FruityVice.Services;
using FruityVice.Services.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
});


// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IFruityViceService, FruityViceService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());
app.UseAuthorization();

app.MapControllers();

app.Run();
