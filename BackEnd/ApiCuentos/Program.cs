using ApiCuentos.Services;
using Microsoft.Net.Http.Headers;
using Microsoft.Azure.Cosmos;
using Azure.Identity;


var builder = WebApplication.CreateBuilder(args);
//CORS configuration
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000")
                          .AllowAnyHeader();

                      });
});

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton((s) =>
{
    return new CosmosClient(
        accountEndpoint: "https://cosmos-apicuentos.documents.azure.com:443/",
        tokenCredential: new DefaultAzureCredential());
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<CosmosService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
