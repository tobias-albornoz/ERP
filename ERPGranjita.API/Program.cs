using ERPGranjita.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CarniceriaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ERPGranjita.API.Repositories.VentasRepository>();
builder.Services.AddScoped<ERPGranjita.API.Services.VentasService>();

// --- HABILITAR CORS ---
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// --- USAR CORS ANTES DE AUTORIZACIÓN ---
app.UseCors();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();