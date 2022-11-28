using Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<VireoXmosaicContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("VireoXmosaic")));

var app = builder.Build();


//Creazione del database
using(IServiceScope scope = app.Services.CreateScope())
{
    var contenxt = scope.ServiceProvider.GetRequiredService<VireoXmosaicContext>();
    contenxt.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
