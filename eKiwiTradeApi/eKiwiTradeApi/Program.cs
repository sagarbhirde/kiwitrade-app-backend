using eKiwiTradeApi.Data;
using eKiwiTradeApi.Data.DataHelper;
using eKiwiTradeApi.Logic;
using eKiwiTradeApi.Logic.Interface;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "eKiwiTrade API Command", Version = "v1" });
});

// Configure MongoDB settings
builder.Services.Configure<DbConfiguration>(builder.Configuration.GetSection("MongoDbConnection"));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add logging configuration (optional: configure more options)
builder.Logging.ClearProviders(); // Clear default providers
builder.Logging.AddConsole(); // Add console logging (optional: add file or other providers)


// Add application services
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

// Add controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MongoDB CRUD API V1");
});

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
