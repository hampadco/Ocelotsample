using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

//add json file Ocelot.json


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//ocelot
builder.Configuration.AddJsonFile("Ocelot.json");
builder.Services.AddOcelot(builder.Configuration);
//AddSwaggerForOcelot
builder.Services.AddSwaggerForOcelot(builder.Configuration);

var app = builder.Build();
app.UseSwaggerForOcelotUI(opt =>
        {
            opt.DownstreamSwaggerEndPointBasePath = "/swagger/docs";
        });

app.UseOcelot().Wait();

app.UseHttpsRedirection();

app.UseAuthorization();



app.MapControllers();

app.Run();
