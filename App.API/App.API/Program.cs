using App.Application.Services;
using App.Persistence.InfrastructureRegistiration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

Registiration.AddRepository(builder.Services, builder.Configuration);


builder.Services.AddApplicationServices();

builder.Services.AddHttpClient();




builder.Services.AddControllers().AddJsonOptions(opt =>
 {
     opt.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
 });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
