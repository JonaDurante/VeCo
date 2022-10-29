using Microsoft.EntityFrameworkCore;
using VeCo.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Agrego context
builder.Services.AddDbContext<VecoContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DataConnection")));
// -- Fin agregado

var app = builder.Build();

// -- agregado para poder utilizar entityframework migrations
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<VecoContext>();
    dbContext.Database.EnsureCreated();           //Nos permite crear la db si no está creada, pero si modificamos nuestra entidad, no modifica esta en la base
    //dbContext.Database.Migrate();
}
// -- Fin agregado


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
