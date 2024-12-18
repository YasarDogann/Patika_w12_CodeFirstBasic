using Microsoft.EntityFrameworkCore; // Entity Framework Core kütüphanesi
using patika_w12_CodeFirstBasic.Data; // Proje içindeki veri eriþim katmanýný dahil ediyoruz

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// add dbcontext
// DbContext'i Dependency Injection'a ekliyoruz
// "PatikaFirstDbContext" sýnýfýný kullanarak veritabaný iþlemleri yapacaðýz
// Baðlantý dizesi "appsettings.json" dosyasýndan okunuyor
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
