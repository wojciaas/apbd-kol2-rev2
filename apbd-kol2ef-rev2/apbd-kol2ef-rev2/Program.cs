using apbd_kol2ef_rev2.Context;
using apbd_kol2ef_rev2.Middlewares;
using apbd_kol2ef_rev2.Repositories;
using apbd_kol2ef_rev2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IMusicLabelsService, MusicLabelsService>();
builder.Services.AddScoped<IMuzykService, MuzykService>();
builder.Services.AddScoped<IMuzykRepository, MuzykRepository>();
builder.Services.AddDbContext<MusicLabelsDbContext>(opt => 
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MusicLabelCon"))
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();