using Microsoft.EntityFrameworkCore; // Entity Framework Core k�t�phanesi
using patika_w12_CodeFirstBasic.Data; // Proje i�indeki veri eri�im katman�n� dahil ediyoruz

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// add dbcontext
// DbContext'i Dependency Injection'a ekliyoruz
// "PatikaFirstDbContext" s�n�f�n� kullanarak veritaban� i�lemleri yapaca��z
// Ba�lant� dizesi "appsettings.json" dosyas�ndan okunuyor
builder.Services.AddDbContext<PatikaFirstDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
